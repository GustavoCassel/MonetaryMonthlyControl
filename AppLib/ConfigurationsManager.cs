using System.IO;
using System.Text.Json;

namespace AppLib;

public enum Theme
{
    Black,
    White
}

public enum Language
{
    English,
    Portuguese
}

public static class ConfigurationsManager
{
    public static Configurations? Configurations { get; set; }

    public static async Task<Configurations> GetConfigurationAsync(CancellationToken cancellationToken)
    {
        string path = GetConfigurationFileName();
        if (!File.Exists(path))
            return new();

        using Stream stream = File.Open(path, FileMode.OpenOrCreate);

        return await JsonSerializer.DeserializeAsync<Configurations>(
            stream, cancellationToken: cancellationToken)
            ?? throw new NullReferenceException();
    }

    public static async Task SaveConfigurationAsync(Configurations configurations, CancellationToken cancellationToken)
    {
        string path = GetConfigurationFileName();

        using Stream stream = File.Create(path);

        await JsonSerializer.SerializeAsync(
            stream, configurations,
            cancellationToken: cancellationToken);
    }

    private static string GetConfigurationFileName()
    {
        const string Version = "v1";

        const string FileName = $"MonetaryMonthlyControl-{nameof(ConfigurationsManager)}-{Version}.json";

        string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        return $"{appDataFolder}\\{FileName}";
    }
}