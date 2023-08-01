namespace AppUI;

public enum Level
{
    FatalError, Warning, Success, Unknown
}

public static class UserMessage
{
    private static readonly IReadOnlyDictionary<Level, string> _captions =
        new Dictionary<Level, string>()
        {
            { Level.FatalError, "An fatal error occurred" },
            { Level.Warning, "Warning!" },
            { Level.Success, "An error was captured with success!" },
            { Level.Unknown, "An unknown error occurred!" }
        };

    private static readonly IReadOnlyDictionary<Level, MessageBoxIcon> _icons =
        new Dictionary<Level, MessageBoxIcon>()
        {
            { Level.FatalError, MessageBoxIcon.Error },
            { Level.Warning, MessageBoxIcon.Warning },
            { Level.Success, MessageBoxIcon.Information },
            { Level.Unknown, MessageBoxIcon.Error }
        };

    public static void ShowError(string message, Level level)
    {
        MessageBox.Show(
            message,
            _captions[level],
            MessageBoxButtons.OK,
            _icons[level],
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.ServiceNotification);
    }

    public static void ShowSuccess(string message)
    {
        MessageBox.Show(
            message,
            "Process finished with success!",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information,
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.ServiceNotification);
    }
}