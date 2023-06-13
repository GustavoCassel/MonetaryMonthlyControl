namespace AppLib;

public sealed class LocalDBNotInstalledException : Exception
{
    public LocalDBNotInstalledException() : base("SQLLocalDb não está instalado corretamente!")
    { }
}

public sealed class LocalDBNotFoundException : Exception
{
    public LocalDBNotFoundException() : base("Instância local não encontrada!")
    { }
}