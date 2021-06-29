# Solid Workshop

Este projeto tem como intuido meramente academico para explicar o que são e mostrar problemas e soluções que os principios SOLID estão direcionando.

# S.O.L.I.D.

Esse termo é um acronimo:
* **S**ingle Responsibility Principle
* **O**pen/Closed Principle
* **L**iskov Substitution Principle
* **I**nterface Segregation Principle
* **D**ependency Inversion

São principios para auxiliar o desenvolvimento de um software saudável. Não são regras, nem leis que devemos seguir. Servem principalmente como guias e ideias que devemos lembrar durante o desenvolvimento para evitar retrabalho e problemas durante o projeto.

# Single Responsibility Principle

> "Nunca deve haver mais de uma razão para uma classe mudar"

Em outras palavras: "Cada classe deve ter apenas uma responsabilidade."

Esse principio tem como intuito evitar classes com multiplas responsabilidades e acabarem virando a tão famosa classe "Deus"(que faz tudo no sistema).

Classes que tem muitas responsabilidades tem problemas com rastreabilidade na identificacao de mudancas, revisão de código, testes unitários, maior risco de alterações na classe impactar em outras funcionalidades. 

# Open/Closed Principle

> "Entidades de Software ... devem ser abertas para extensão, mas fechadas para modificação"

O software evolui e muda, se para cada mudança vamos precisar sempre alterar a mesma classe, isso pode facilmente impactar em outras funcionalidades. Mudar é risco, extender é garantir que o que estava implementado funciona e a "mudança" é apenas uma extensão de algo que já existe.

Uma ótima ferramenta para aplicar isso são interfaces. Neste exemplo, o piloto utiliza um IAutomovel

```C#
public interface IAutomovel 
{
    void Move();
    void Buzina();
}

public class Piloto
{
    public void AvisarChegada(IAutomovel automovel)
    {
        automovel.Buzina();
    }

    public void Dirige(IAutomovel automovel)
    {
        automovel.Move();
    }
}
```

Como essa implementação, nosso Piloto pode "Avisar sua chegada" e "Dirigir", qualquer tipo de IAutomovel.

# Liskov Substitution Principle
> "Functions that use pointers or references to base classes must be able to use objects of derived classes without knowing it"."

O problema que esse principio tenta resolver é quando precisamos criar novas funcionalidades para algo que já desenvolvemos. Vamos considerar que temos um processo de integração em nosso sistema:

```c#
public class Integrador
{
    public void EnviaEmail(string conteudo)
    {
        // Obtem o conteudo...
        // Envia para alguem
    }
}

public class Sistema
{
    public void Integra()
    {
        Integrador integrador = new Integrador();
        integrador.EnviaEmail("Conteudo!");
    }
}
```

Caso precisemos adicionar uma integração via API, vamos precisar adicionar mais um metodo no nosso integrador e provavelmente um if no nosso metodo Sistema.Integra(). Alem disso a nossa classe Sistema precisa "entender" que tipo de integração ele vai fazer(API ou Email).

Para evitar isso, podemos, mais uma vez, usar interfaces!


```c#
public interface IIntegrador
{
    void Envia(string conteudo);
}

public class IntegradorEmail : IIntegrador
{
    public void Envia(string conteudo)
    {
        // Faz lógica de EMAIL
    }
}

public class IntegradorAPI : IIntegrador
{
    public void Envia(string conteudo)
    {
        // Faz a lógica de API
    }
}

public class Sistema
{
    public void Integra(IIntegrador integrador)
    {
        integrador.Envia("Conteudo!");
    }
}
```

# Interface Segregation Principle
> Many client-specific interfaces are better than one general-purpose interface.

# Dependency Inversion
> "Depend upon abstractions, [not] concretions"


# Links para continuar o assunto:

https://en.wikipedia.org/wiki/SOLID

https://stackify.com/solid-design-principles/

https://github.com/learnasyougo/S.O.L.I.D