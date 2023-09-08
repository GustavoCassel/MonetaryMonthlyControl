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

    public static async Task<Configurations> GetConfigurationAsync()
    {
        string path = GetConfigurationFileName();

        using Stream stream = File.Open(path, FileMode.OpenOrCreate);

        return await JsonSerializer.DeserializeAsync<Configurations>(stream)
            ?? throw new NullReferenceException();
    }

    public static async Task SaveConfigurationAsync(Configurations configurations)
    {
        string path = GetConfigurationFileName();

        using Stream stream = File.Create(path);

        await JsonSerializer.SerializeAsync(stream, configurations);
    }

    private static string GetConfigurationFileName()
    {
        const string Version = "v1";

        const string FileName = $"MonetaryMonthlyControl-{nameof(ConfigurationsManager)}-{Version}.json";

        string appDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        return $"{appDataFolder}\\{FileName}";
    }
}