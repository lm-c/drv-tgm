using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using LmCorbieUI.Metodos.AtributosCustomizados;

namespace TGM_DRV {
  internal class W_Registro {

    [Browsable(false)]
    public int Codigo { get; set; }

    [LarguraColunaGrid(100)]
    [DisplayName("Data")]
    //[Formatacao("ddd - dd/MM/yyyy")]
    [AlinhamentoColunaGrid(System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft)]
    public DateTime Data { get; set; }
    public string Coluna1 { get; set; }
    public string Coluna2 { get; set; }
    public string Coluna3 { get; set; }
    public string Coluna4 { get; set; }
    public string Coluna5 { get; set; }
    public string Coluna6 { get; set; }
    public string Coluna7 { get; set; }
    public string Coluna8 { get; set; }
    public string Coluna9 { get; set; }
    public string Coluna10 { get; set; }
    public string Coluna11 { get; set; }
    public string Coluna12 { get; set; }
    public string Coluna13 { get; set; }
    public string Coluna14 { get; set; }
    public string Coluna15 { get; set; }
    public string Coluna16 { get; set; }
    public string Coluna17 { get; set; }
    public string Coluna18 { get; set; }
    public string Coluna19 { get; set; }
    public string Coluna20 { get; set; }
    public string Coluna21 { get; set; }
    public string Coluna22 { get; set; }
    public string Coluna23 { get; set; }
    public string Coluna24 { get; set; }
    public string Coluna25 { get; set; }
    public string Coluna26 { get; set; }
    public string Coluna27 { get; set; }
    public string Coluna28 { get; set; }
    public string Coluna29 { get; set; }
    public string Coluna30 { get; set; } 
  }

}

