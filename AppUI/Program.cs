using AppLib;
using AppUI.Properties;
using Microsoft.Win32;
using System.Reflection;

namespace AppUI;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        try
        {
            LocalDbManager.Main().Wait();
        }
        catch (Exception ex)
        {
            ErrorMessage.Show($"Ocorreu um erro desconhecido!\nErro: {ex.Message}", Level.FatalError);
            return;
        }

        try
        {
            DatabaseManager.Main().Wait();
        }
        catch (Exception ex)
        {
            ErrorMessage.Show($"Ocorreu um erro desconhecido!\nErro: {ex.Message}", Level.FatalError);
            return;
        }

        UIConfig.SetTheme(Theme.Dark);

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new Menu());
    }
}