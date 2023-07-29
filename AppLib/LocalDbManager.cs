using System.Diagnostics;

namespace AppLib;

public static class LocalDbManager
{
    /// <returns>
    ///     Gets if the nedded SQLLocalDB instance is installed
    /// </returns>
    public static async Task CheckLocalDBInstance(CancellationToken cancellationToken)
    {
        ProcessStartInfo processStartInfo = new()
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            FileName = "cmd.exe",
            Arguments = $"/C SQLLocalDB Info",
            CreateNoWindow = true,
            WindowStyle = ProcessWindowStyle.Hidden
        };

        Process process = new()
        {
            StartInfo = processStartInfo
        };

        process.Start();

        string output = await process.StandardOutput.ReadToEndAsync(cancellationToken);

        await process.WaitForExitAsync(cancellationToken);

        // If LocalDb is not installed then it will return that 'sqllocaldb' is not
        // recognized as an internal or external command operable program or batch file.
        if (string.IsNullOrWhiteSpace(output) || output.Contains("not recognized"))
            throw new Exception("SQLLocalDB is not installed correctly!");

        string[] instances = output.Split(Environment.NewLine, StringSplitOptions.None);

        List<string> lstInstances = new(instances);

        lstInstances.RemoveAll(string.IsNullOrWhiteSpace);

        if (!lstInstances.Contains(DatabaseManager.LocalDBName))
            throw new Exception("SQLLocalDB instance not found!");
    }
}