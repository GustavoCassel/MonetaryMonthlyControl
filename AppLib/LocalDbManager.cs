using AppLib.Properties;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AppLib;

public static class LocalDbManager
{
    /// <summary>
    /// 
    /// </summary>
    public static async Task Main()
    {
        _ = await GetLocalDBInstances();
    }

    /// <summary>
    /// Get all SQLLocalDB instances with a cmd command
    /// </summary>
    /// <returns></returns>
    /// <exception cref="LocalDBNotInstalledException"></exception>
    /// <exception cref="LocalDBNotFoundException"></exception>
    private static async Task<IReadOnlyCollection<string>> GetLocalDBInstances()
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

        string output = await process.StandardOutput.ReadToEndAsync();

        await process.WaitForExitAsync();

        // If LocalDb is not installed then it will return that 'sqllocaldb' is not
        // recognized as an internal or external command operable program or batch file.
        if (string.IsNullOrWhiteSpace(output) || output.Contains("not recognized"))
            throw new LocalDBNotInstalledException();

        string[] instances = output.Split(Environment.NewLine, StringSplitOptions.None);

        List<string> lstInstances = new(instances);

        lstInstances.RemoveAll(string.IsNullOrWhiteSpace);

        if (!lstInstances.Contains(Resources.SqlLocalDBName))
            throw new LocalDBNotFoundException();

        return lstInstances.AsReadOnly();
    }

}