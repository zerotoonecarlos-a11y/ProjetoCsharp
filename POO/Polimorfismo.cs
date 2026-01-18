namespace FundamentosCSharp;

using System;

public class Comida(double peso)
{
    // Propriedade pública somente leitura (set privado)
    public double Peso { get; private set; } = peso;
}

public class Carne(double peso) : Comida(peso)
{
}

public class Arroz(double peso): Comida(peso)
{
   
}

public class Feijao(double peso) : Comida(peso)
{
    
}

public class Pessoa(double pesoInicial = 0)
{
    // Uso de propriedade com encapsulamento
    public double Peso { get; private set; } = pesoInicial;

    

    // Método polimórfico: aceita qualquer Comida
    public void Comer(Comida comida)
    {
        Peso += comida.Peso;
        Console.WriteLine($"Você acabou de ganhar {comida.Peso} kg de peso corporal!");
    }
}

public class Polimorfismo
{ }
// Classe apenas para ilustrar o namespace; a lógica está nas classes acima.
