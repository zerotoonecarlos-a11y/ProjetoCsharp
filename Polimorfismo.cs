namespace encapsulamento;

using System;

public class Comida(double peso)
{
    // Propriedade pública somente leitura (set privado)
    public double Peso { get; private set; } = peso;
}

public class Carne : Comida
{
    public Carne(double peso) : base(peso) { }
}

public class Arroz : Comida
{
    public Arroz(double peso) : base(peso) { }
}

public class Feijao : Comida
{
    public Feijao(double peso) : base(peso) { }
}

public class Pessoa
{
    // Uso de propriedade com encapsulamento
    public double Peso { get; private set; }

    public Pessoa(double pesoInicial = 0)
    {
        Peso = pesoInicial;
    }

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
