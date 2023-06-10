using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUI;
public enum Level
{
    FatalError, Warning, Success, Unknown
}

public static class ErrorMessage
{
    private static readonly IReadOnlyDictionary<Level, string> captions =
        new Dictionary<Level, string>()
        {
            { Level.FatalError, "Ocorreu um Erro Fatal" },
            { Level.Warning, "Aviso!" },
            { Level.Success, "Erro Capturado com Sucesso!" },
            { Level.Unknown, "Erro Desconhecido!" }
        };

    private static readonly IReadOnlyDictionary<Level, MessageBoxIcon> icons =
        new Dictionary<Level, MessageBoxIcon>()
        {
            { Level.FatalError, MessageBoxIcon.Error },
            { Level.Warning, MessageBoxIcon.Warning },
            { Level.Success, MessageBoxIcon.Information },
            { Level.Unknown, MessageBoxIcon.Error }
        };

    public static void Show(string message, Level level)
    {
        MessageBox.Show(
            message,
            captions[level],
            MessageBoxButtons.OK,
            icons[level],
            MessageBoxDefaultButton.Button1,
            MessageBoxOptions.ServiceNotification);
    }
}
