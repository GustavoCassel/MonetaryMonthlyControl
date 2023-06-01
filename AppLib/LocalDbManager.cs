using System.Diagnostics;

namespace AppLib;

public enum LocalDbCommand
{
    Create,
    Stop,
    Info
}

public static class LocalDbManager
{
    public static void RunCommandOnCmd(LocalDbCommand localDbCommand)
    {
        ProcessStartInfo processStartInfo = new()
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            FileName = "cmd.exe",
            Arguments = $"/C SQLLocalDB {localDbCommand} \"{Global.SqlLocalDbServerName}\"",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        Process process = new()
        {
            StartInfo = processStartInfo
        };

        process.Start();
        process.WaitForExit();
    }

    public static List<string>? GetLocalDBInstances()
    {
        ProcessStartInfo processStartInfo = new()
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            FileName = "cmd.exe",
            Arguments = $"/C SQLLocalDB {LocalDbCommand.Info}",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        Process process = new()
        {
            StartInfo = processStartInfo
        };

        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        // If LocalDb is not installed then it will return that 'sqllocaldb' is not recognized as an internal or external command operable program or batch file.
        if (string.IsNullOrWhiteSpace(output) || output.Contains("not recognized"))
        {
            return null;
        }

        string[] instances = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        List<string> lstInstances = new(instances);
        lstInstances.RemoveAll(instance => instance.Trim().Length <= 0);

        return lstInstances;
    }
}