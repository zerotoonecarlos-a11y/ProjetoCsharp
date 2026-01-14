using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace encapsulamento;

public abstract class Celular
{
    public Celular()
    {
        
    }
    
    public abstract string Tocar();

    public abstract  string Carregando();

    public  void Ligar()
    {
        Console.WriteLine("Ligando......");
    }

    public abstract void Assistente();
}

public class Iphone : Celular
{
    public Iphone()
    {
        
    }

    public override string Tocar()
    {
        return "Som do iPhone";
    }

    public override string Carregando()
    {
        return "Iphone conectado ao carregador";
    }

    public override void Assistente()
    {
        Console.WriteLine("Olá! Eu sou a Siri!");
    }
}

public class Motorola : Celular
{
        public override string Tocar()
    {
        return "Som do Motorola";
    }

    public override string Carregando()
    {
        return "Motorola conectado ao carregador";
    }

    public override void Assistente()
    {
        Console.WriteLine("Ola! Eu sou o google assistente!");
    }
}

public class Samsung : Celular
{
    public override string Tocar()
    {
        return "Som do Samsung";
    }

    public override string Carregando()
    {
       return "Samsung conectando ao carregador"; 
    }

    public override void Assistente()
    {
        Console.WriteLine("Olá! Eu sou a Bixby!");
    }
}
public static class Abstract
{

 public static void Executar()
    {
        // o new faz a chamada ao construtor padrão
     

        var celulares = new List<Celular>(){
            
            new Iphone(),
            new Samsung(),
            new Motorola()
        };

        foreach( var celular in celulares)
        {
            celular.Assistente();
        }
    }
 
}
