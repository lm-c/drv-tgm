using LiveCharts;
using LiveCharts.Wpf;
using LmCorbieUI;
using LmCorbieUI.Controls;
using LmCorbieUI.Design;
using LmCorbieUI.LmForms;
using LmCorbieUI.Metodos;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmDashboard : LmChildForm {
    private LiveCharts.WinForms.CartesianChart columnChart;
    private LiveCharts.WinForms.PieChart pieChart;

    SortableBindingList<W_Registro> _lancamentos = new SortableBindingList<W_Registro>();

    GridStyle gridStyle = new GridStyle();

    public FrmDashboard() {
      InitializeComponent();

      columnChart = new LiveCharts.WinForms.CartesianChart {
        Dock = DockStyle.Fill,
        BackColor = Color.Transparent
      };
      pieChart = new LiveCharts.WinForms.PieChart {
        Dock = DockStyle.Fill,
        BackColor = Color.Transparent
      };

      this.pnlGraf1.Controls.Add(columnChart);
      this.pnlGraf2.Controls.Add(pieChart);

      DefinirFiltroPadrao();
    }

    private void FrmDashboard_Loaded(object sender, EventArgs e) {
      Invoke(new MethodInvoker(delegate () {
        this.Modo = Modo.Padrao;

        dgv.ColunasBloqueadasGrid = "";
        foreach (var col in ColumnInfo.model.Columns) {
          if (string.IsNullOrEmpty(col.Display)) {
            dgv.ColunasBloqueadasGrid += col.Name + "^";
          }
        }
        if (dgv.ColunasBloqueadasGrid.EndsWith("^"))
          dgv.ColunasBloqueadasGrid = dgv.ColunasBloqueadasGrid.Substring(0, dgv.ColunasBloqueadasGrid.Length - 1);

        dgv.PosColunasGrid = gridStyle.PosicaoColuna;
        dgv.ColunaOrdenacaoGrid = gridStyle.OrdemColuna;
        dgv.ColunasOcultasGrid = gridStyle.ColunaOculta;
        dgv.ColunasOcultasImpressGrid = gridStyle.ColunaOcultaImpressao;
        dgv.TituloRelatorio = "Relatório de Consumo de Agregados";
      }));
    }

    private void FormatarGrid() {
      try {
        foreach (var col in ColumnInfo.model.Columns) {
          if (string.IsNullOrEmpty(col.Display)) {
            break;
          } else {
            var gridColumn = dgv.Grid.Columns[col.Name];
            gridColumn.HeaderText = col.Display;

            gridColumn.Width = col.LarguraColuna;

            var align = 
              col.AlinhamentoColuna == DgvAlignment.Esquerda 
              ? DataGridViewContentAlignment.MiddleLeft 
              : col.AlinhamentoColuna == DgvAlignment.Centro 
              ? DataGridViewContentAlignment.MiddleCenter 
              : DataGridViewContentAlignment.MiddleRight;
            gridColumn.DefaultCellStyle.Alignment = align;
            gridColumn.HeaderCell.Style.Alignment = align;
          }
        }
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Formatar Grid");
      }
    }

    private void BtnPesquisar_Click(object sender, EventArgs e) {
      try {
        Invoke(new MethodInvoker(async delegate () {
          dgv.ShowMsgGrid("Pesquisando, Aguarde...");

          DateTime ini = new DateTime(2001, 02, 01);
          DateTime fim = new DateTime(2100, 02, 01);

          if (!string.IsNullOrEmpty(txtIni.Text))
            ini = Convert.ToDateTime(txtIni.Text.FormatarData());

          if (!string.IsNullOrEmpty(txtFim.Text))
            fim = Convert.ToDateTime(txtFim.Text.FormatarData());

          _lancamentos = await Task.Run(() =>
          Registro.Selecionar(ini, fim));


          if (IsClosing) return;

          CarregarDgv();

          dgv.CloseMsgGrid();
        }));
      } catch (Exception ex) {
        if (!IsClosing)
          LmException.ShowException(ex, "Erro ao pesquisar");
      }
    }

    private void BtnLimpar_Click(object sender, EventArgs e) {
      DefinirFiltroPadrao();
      _lancamentos = new SortableBindingList<W_Registro>();
      CarregarDgv();
    }

    private void DefinirFiltroPadrao() {
      try {
        Controles.Clear(gpbFiltro);
        txtIni.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).ToShortDateString();
        txtFim.Text = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month)).ToShortDateString();

      } catch (Exception ex) {
        LmException.ShowException(ex, $"Erro ao definir filtro padrão '{this.Text}'");
      }
    }

    private void CarregarDgv() {
      dgv.CarregarGrid(_lancamentos);
      FormatarGrid();

      System.Threading.Thread t = new System.Threading.Thread(() => {
        CalcularTotal();
      }) { IsBackground = true };
      t.Start();
    }

    private void CalcularTotal() {
      try {
        Invoke(new MethodInvoker(delegate () {
          dgv.flpRodape.Controls.OfType<LmLabel>().ToList().ForEach(x => x.Text = string.Empty);

          foreach (DataGridViewRow row in dgv.Grid.Rows) {
            foreach (var col in ColumnInfo.model.Columns) {
              if (string.IsNullOrEmpty(col.Display))
                break;

              if (!string.IsNullOrEmpty(col.Name) && col.CalcularTotalGrid == Verdade.Sim &&
              (col.Type == LmValueType.Num_Inteiro || col.Type == LmValueType.Num_Real)) {
                var val = row.Cells[col.Name].Value?.ToString();
                if (string.IsNullOrEmpty(val))
                  val = "0";

                var rdp = dgv.flpRodape.Controls.OfType<LmLabel>().FirstOrDefault(x => x.Name == $"rdp" + col.Name);
                if (rdp != null) {
                  if (string.IsNullOrEmpty(rdp.Text))
                    rdp.Text = col.Type == LmValueType.Num_Inteiro ? "0" : "0,0";
                  rdp.Text = col.Type == LmValueType.Num_Inteiro
                  ? (Convert.ToInt32(rdp.Text) + Convert.ToInt32(val)).ToString()
                  : (Convert.ToDouble(rdp.Text.Replace(".", ",")) + Convert.ToDouble(val.Replace(".", ","))).ToString();
                }
              }
            }
          }
          // Montando Gráfico
          List<Tuple<string, double>> columnsToPlot = new List<Tuple<string, double>>();
          foreach (var col in ColumnInfo.model.Columns) {
            if (string.IsNullOrEmpty(col.Display))
              break;
            if (!string.IsNullOrEmpty(col.Name) && col.CalcularTotalGrid == Verdade.Sim && col.GerarGrafico == Verdade.Sim &&
            (col.Type == LmValueType.Num_Inteiro || col.Type == LmValueType.Num_Real)) {
              var rdp = dgv.flpRodape.Controls.OfType<LmLabel>().FirstOrDefault(x => x.Name == $"rdp" + col.Name);
              if (rdp != null) {
                var total = !string.IsNullOrEmpty(rdp.Text) ? Convert.ToDouble(rdp.Text.Replace(".", ",")) : 0.0;
                columnsToPlot.Add(new Tuple<string, double>(col.Display, total));
              }
            }
          }
          GenerateChart(columnsToPlot);
        }));
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Calcular Total");
      }
    }

    private void GenerateChart(List<Tuple<string, double>> columnsToPlot) {
      try {
        var columnSeriesCollection = new SeriesCollection();
        var pieSeriesCollection = new SeriesCollection();

        foreach (var column in columnsToPlot) {
          AddColumnSeries(columnSeriesCollection, column.Item1, column.Item2);
          AddPieSeries(pieSeriesCollection, column.Item1, column.Item2);
        }

        // Configure column chart
        columnChart.Series = columnSeriesCollection;
        columnChart.AxisX.Clear();
        columnChart.AxisX.Add(new Axis {
          Title = "Componentes",
          Labels = new string[7],
          //LabelsRotation = -60, // Rotacionar as labels
          Separator = new Separator { Step = 1, IsEnabled = false }
        });
        columnChart.AxisY.Clear();
        columnChart.AxisY.Add(new Axis {
          Title = "Valores",
          LabelFormatter = value => value.ToString("N")
        });

        // Configure pie chart
        pieChart.Series = pieSeriesCollection;
        pieChart.LegendLocation = LegendLocation.Left;
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Montar Gráficos");
      }
    }

    private void AddColumnSeries(SeriesCollection seriesCollection, string title, double value) {
      seriesCollection.Add(new ColumnSeries {
        Title = title,
        Values = new ChartValues<double> { value },
        LabelsPosition = BarLabelPosition.Perpendicular,
      });
    }

    private void AddPieSeries(SeriesCollection seriesCollection, string title, double value) {
      seriesCollection.Add(new PieSeries {
        Title = title,
        Values = new ChartValues<double> { value },
        DataLabels = true
      });
    }

    private void Dgv_ProcurarTextChanged(object sender, EventArgs e) {
      CarregarDgv();
    }

    private void Dgv_RowIndexChanged(object sender, EventArgs e) {
      btnDetalhar.Enabled = sender != null;
    }

    private void BtnDetalhar_Click(object sender, EventArgs e) {
      var frm = new FrmRegistroDetalha(dgv.Grid.CurrentRow);
      frm.ShowDialog();
    }

    private void Dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
      if (btnDetalhar.Enabled)
        BtnDetalhar_Click(sender, e);
    }
  }
}
