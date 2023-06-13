using AppLib.Properties;
using System.Diagnostics;

namespace AppLib;

public static class LocalDbManager
{
    public static async Task Main()
    {
        if (!await IsLocalDBInstalled())
        {
            throw new LocalDBNotInstalledException();
        }

        if (!await IsInstanceCreated())
        {
            throw new LocalDBNotFoundException();
        }
    }

    private static async Task<IReadOnlyCollection<string>?> GetLocalDBInstances()
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
        {
            return null;
        }

        string[] instances = output.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
        List<string> lstInstances = new(instances);

        lstInstances.RemoveAll(string.IsNullOrWhiteSpace);

        return lstInstances.AsReadOnly<string>();
    }

    private static async Task<bool> IsLocalDBInstalled()
    {
        return await GetLocalDBInstances() != null;
    }

    private static async Task<bool> IsInstanceCreated()
    {
        IReadOnlyCollection<string>? instances = await GetLocalDBInstances();

        if (instances == null)
        {
            return false;
        }

        return instances.Any(instance => instance == Resources.SqlLocalDBName);
    }
}