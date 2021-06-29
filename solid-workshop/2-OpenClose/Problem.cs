// Software entities (e.g. classes, modules, functions) should be open for extension but closed for modification.

public class Sistema
{
    private IntegradorEmail _integrador = new IntegradorEmail(
        new Configurador(),
        new Repositorio());

    public Sistema(IntegradorEmail integrador)
    {
        _integrador = integrador;
    }
    public void Principal()
    {
        _integrador.Integrar();
    }
}

public class IntegradorEmail
{
    private Configurador _configurador;
    private Repositorio _repositorio;

    public IntegradorEmail(
        Configurador configurador,
        Repositorio repositorio)
    {
        _configurador = configurador;
        _repositorio = repositorio;
    }
    
    public bool Integrar()
    {
        // Obtem email destino
        string emailDestino = _configurador.ObtemEmailCliente();

        // Obtem configuracao SMTP
        ConfigSMTP configSmtp = _configurador.ObtemConfigSMTP();

        // Obtem a utlima mensagem 
        string mensagem = _repositorio.ObtemUltimaIntegracao();

        // Envia o email
        return EnviarEmail(configSmtp, emailDestino, mensagem);
    }

    private bool EnviarEmail(ConfigSMTP configSmtp, string emailDestino, string mensagem)
    {
        // Enviou o email
        return true;
    }
}
