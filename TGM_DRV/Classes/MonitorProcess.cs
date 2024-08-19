namespace TGM_DRV {
  internal class MonitorProcess {
    public static string StartProcess(string command) {
      using (System.Diagnostics.Process processo = new System.Diagnostics.Process()) {
        processo.StartInfo.FileName = System.Environment.GetEnvironmentVariable("comspec");

        processo.StartInfo.Arguments = string.Format(@"/c {0}", command);

        processo.StartInfo.RedirectStandardOutput = true;
        processo.StartInfo.UseShellExecute = false;
        processo.StartInfo.CreateNoWindow = true;

        processo.Start();
        processo.WaitForExit(30000);

        string saida = processo.StandardOutput.ReadToEnd();
        return saida;
      }
    }
  }
}
