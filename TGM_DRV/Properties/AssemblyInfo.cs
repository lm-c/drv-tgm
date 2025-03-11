using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(InfoAssembly.TitleView)]
[assembly: AssemblyDescription(InfoAssembly.DescrView)]
[assembly: AssemblyConfiguration(InfoAssembly.Configuration)]
[assembly: AssemblyCompany(InfoAssembly.Company)]
[assembly: AssemblyProduct(InfoAssembly.Product)]
[assembly: AssemblyCopyright(InfoAssembly.Copyright)]
[assembly: AssemblyTrademark(InfoAssembly.Trademark)]
[assembly: AssemblyCulture(InfoAssembly.Culture)]

[assembly: ComVisible(false)]

[assembly: Guid("13dec6af-7826-4bf8-bd37-0a8f1a2c8d8f")]

[assembly: AssemblyVersion(InfoAssembly.Version)]
[assembly: AssemblyFileVersion(InfoAssembly.Version)]

public class InfoAssembly {
  public const string Version = "1.0.0.5";

  public const string TitleView = "TGM Data Report Viewer";

  public const string DescrView = "TGM Data Report Viewer";

  public const string Copyright = "Copyright © 2024 Leonardo Adriano Michalak. Todos os direitos reservados.";
  public const string Company = "Leonardo Adriano Michalak";
  public const string Product = "TGM Data Report Viewer";
  public const string Configuration = "";
  public const string Trademark = "";
  public const string Culture = "";
}
