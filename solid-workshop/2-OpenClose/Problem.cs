// Software entities (e.g. classes, modules, functions) should be open for extension but closed for modification.

public class AplicacaoService
{
    public void Integra()
    {
        new Integrador().IntegrarEmail();
    }
}

public class Integrador
{
    // Esse metodo integra por email!
    public bool IntegrarEmail()
    {
        // Obtem email destino
        // string emailDestino = _configurador.ObtemEmailCliente();

        // Obtem configuracao SMTP
        // ConfigSMTP configSmtp = _configurador.ObtemConfigSMTP();

        // Obtem a utlima mensagem 
        // string mensagem = _repositorio.ObtemUltimaIntegracao();

        // Envia o email

        return true;
    }
}
