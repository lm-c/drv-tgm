using LmCorbieUI;
using LmCorbieUI.Controls;
using LmCorbieUI.Design;
using LmCorbieUI.LmForms;
using LmCorbieUI.Metodos;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TGM_DRV {
  public partial class FrmColunas : LmChildForm {
    public FrmColunas() {
      InitializeComponent();
    }

    private void FrmColunas_Load(object sender, EventArgs e) {
      var tipoIgnorados =
        $"{LmValueType.Monetario}^" +
        $"{LmValueType.Email}^" +
        $"{LmValueType.Cpf_Cnpj}^" +
        $"{LmValueType.ComboBox}^" +
        $"{LmValueType.ComboBox_Enum}^" +
        $"{LmValueType.Senha}";
      txtTipo.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo1.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo2.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo3.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo4.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo5.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo6.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo7.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo8.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo9.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo10.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo11.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo12.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo13.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo14.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);
      txtTipo15.CarregarComboBoxEnum(typeof(LmValueType), tipoIgnorados);

      txtAlinh.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh1.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh2.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh3.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh4.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh5.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh6.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh7.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh8.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh9.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh10.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh11.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh12.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh13.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh14.CarregarComboBoxEnum(typeof(DgvAlignment));
      txtAlinh15.CarregarComboBoxEnum(typeof(DgvAlignment));

      txtCalc.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc1.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc2.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc3.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc4.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc5.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc6.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc7.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc8.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc9.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc10.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc11.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc12.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc13.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc14.CarregarComboBoxEnum(typeof(Verdade));
      txtCalc15.CarregarComboBoxEnum(typeof(Verdade));

      txtGerarGraf.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf1.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf2.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf3.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf4.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf5.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf6.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf7.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf8.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf9.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf10.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf11.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf12.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf13.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf14.CarregarComboBoxEnum(typeof(Verdade));
      txtGerarGraf15.CarregarComboBoxEnum(typeof(Verdade));
    }

    private void FrmColunas_Loaded(object sender, EventArgs e) {
      Invoke(new MethodInvoker(delegate () {
        for (int i = 0; i < ColumnInfo.model.Columns.Count; i++) {
          ColumnInfo cln = ColumnInfo.model.Columns[i];
          if (!string.IsNullOrEmpty(cln.Display)) {
            var pName = i > 0 ? "pnlCol" + i : "pnlCol";
            var pCol = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pName);
            pCol.Controls.OfType<LmButton>().ToList().ForEach(x => x.Visible = true);
            pCol.Visible = true;

            if (i > 1) {
              var pNameAnt = "pnlCol" + (i - 1);
              var pColAnt = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pNameAnt);
              pColAnt.Controls.OfType<LmButton>().ToList().ForEach(x => x.Visible = false);
            }

            var txtNome = i > 0 ? "txtNome" + i : "txtNome";
            var tNome = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtNome);
            tNome.Text = cln.Display;

            var txtTipo = i > 0 ? "txtTipo" + i : "txtTipo";
            var tTipo = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtTipo);
            tTipo.SelectedValue = cln.Type;

            var txtLarg = i > 0 ? "txtLarg" + i : "txtLarg";
            var tLarg = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtLarg);
            tLarg.Text = cln.LarguraColuna.ToString();

            var txtAlinh = i > 0 ? "txtAlinh" + i : "txtAlinh";
            var tAlinh = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtAlinh);
            tAlinh.SelectedValue = cln.AlinhamentoColuna;

            var txtCalc = i > 0 ? "txtCalc" + i : "txtCalc";
            var tCalc = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtCalc);
            tCalc.SelectedValue = cln.CalcularTotalGrid;

            var txtGerarGraf = i > 0 ? "txtGerarGraf" + i : "txtGerarGraf";
            var tGerarGraf = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtGerarGraf);
            tGerarGraf.SelectedValue = cln.CalcularTotalGrid;
          }
        }
        panelFlow.Enabled = true;
      }));
    }

    private void BtnAdd_Click(object sender, EventArgs e) {
      try {
        var btn = (LmButton)sender;
        var i = btn.Name.SomenteNumerosToInt();
        var pnlCol = "pnlCol" + i;
        var pnlColNext = "pnlCol" + (i + 1);

        var pCol = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pnlCol);

        if (Controles.PossuiCamposInvalidos(pCol))
          return;

        pCol.Controls.OfType<LmButton>().ToList().ForEach(x => x.Visible = false);

        var panelNext = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pnlColNext);
        panelNext.Visible = true;

        panelNext.Controls.OfType<LmTextBox>().ToList().ForEach(x => x.CampoObrigatorio = true);

      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Adicionar");
      }
    }

    private void BtnCanc_Click(object sender, EventArgs e) {
      try {
        var btn = (LmButton)sender;
        var i = btn.Name.SomenteNumerosToInt();

        var pnlCol = "pnlCol" + i;
        var pnlColAnt = "pnlCol" + (i - 1);

        var pCol = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pnlCol);
        pCol.Controls.OfType<LmTextBox>().ToList().ForEach(x => x.CampoObrigatorio = false);
        pCol.Visible = false;

        var pColAnt = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pnlColAnt);
        pColAnt.Controls.OfType<LmButton>().ToList().ForEach(x => x.Visible = true);

        var txtNome = "txtNome" + i;
        var tNome = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtNome);
        tNome.Text = "";
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Remover");
      }
    }

    private void BtnSalvar_Click(object sender, EventArgs e) {
      try {
        if (Controles.PossuiCamposInvalidos(panelFlow))
          return;

        for (int i = 1; i < ColumnInfo.model.Columns.Count; i++) {
          var pName = "pnlCol" + i;
          var pCol = panelFlow.Controls.OfType<LmPanel>().FirstOrDefault(x => x.Name == pName);
          if (pCol == null)
            break;

          ColumnInfo cln = ColumnInfo.model.Columns[i];

          var txtNome = "txtNome" + i;
          var tNome = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtNome);
          if (tNome.Text != null)
            cln.Display = tNome.Text;

          var txtTipo = "txtTipo" + i;
          var tTipo = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtTipo);
          if (tTipo.SelectedValue != null)
            cln.Type = (LmValueType)tTipo.SelectedValue;

          var txtLarg = "txtLarg" + i;
          var tLarg = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtLarg);
          if (!string.IsNullOrEmpty(tLarg.Text))
            cln.LarguraColuna = Convert.ToInt32(tLarg.Text);

          var txtAlinh = "txtAlinh" + i;
          var tAlinh = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtAlinh);
          if (tAlinh.SelectedValue != null)
            cln.AlinhamentoColuna = (DgvAlignment)tAlinh.SelectedValue;

          var txtCalc = "txtCalc" + i;
          var tCalc = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtCalc);
          if (tCalc.SelectedValue != null)
            cln.CalcularTotalGrid = (Verdade)tCalc.SelectedValue;

          var txtGerarGraf = "txtGerarGraf" + i;
          var tGerarGraf = pCol.Controls.OfType<LmTextBox>().FirstOrDefault(x => x.Name == txtGerarGraf);
          if (tGerarGraf.SelectedValue != null)
            cln.GerarGrafico = (Verdade)tGerarGraf.SelectedValue;
        }

        ColumnInfo.Salvar();
      } catch (Exception ex) {
        LmException.ShowException(ex, "Erro ao Salvar Colunas");
      }
    }
  }
}
