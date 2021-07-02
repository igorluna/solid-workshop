// Software entities (e.g. classes, modules, functions) should be open for extension but closed for modification.

public class AplicacaoServiceNew
{
    private IIntegrador _integrador;

    // Agora posso repassar uma instancia do tipo de integrador que quero que ele faça(Api, Email, ou qualquer outro que possa aparecer)
    public AplicacaoServiceNew(IIntegrador integrador)
    {
        _integrador = integrador;
    }

    public void Integra()
    {
        _integrador.Integrar();
    }
}

public class IntegradorEmailNovo : IIntegrador
{
    public bool Integrar()
    {
        // Obtem email destino

        // Obtem configuracao SMTP

        // Obtem a utlima mensagem 

        // Envia o email
        return true;
    }
}

public class IntegradorApi : IIntegrador
{
    public bool Integrar()
    {
        // Obtem configuração da API

        // Obtem dados para enviar para a API

        //Envia para API
        return true;
    }
}
public interface IIntegrador { 
    bool Integrar();
}


