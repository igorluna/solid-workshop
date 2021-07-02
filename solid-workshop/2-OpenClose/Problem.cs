// "Entidades (classes, modulos, funcoes) devem ser abertas para extensão e fechadas para modificações"
// "Uma classe está fechada, quando ela está compilada, armasenada em uma biblioteca e usada por classes clientes"
// "A classe está aberta, quando outras classes podem usa-la por heranca, adicionando novas funcionalidades."


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
