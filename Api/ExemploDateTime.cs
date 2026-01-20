namespace FundamentosCSharp;

public class ExemploDateTime
{
    public static void Executar()
    {
        var dataTime = new DateTime(year: 2026, month: 1, day: 18);

        Console.WriteLine(dataTime.Year);
        Console.WriteLine(dataTime.Month);
        Console.WriteLine(dataTime.Day);

        var hoje = DateTime.Today;
        Console.WriteLine(hoje);

        var diaAtual = DateTime.Now;

        Console.WriteLine(diaAtual);
        Console.WriteLine("Horas: " + diaAtual.Hour);
        Console.WriteLine("Minutos: " + diaAtual.Minute);

        var ontem = diaAtual.AddDays(1);
        Console.WriteLine(ontem);

        Console.WriteLine(diaAtual.ToString("dd"));
        Console.WriteLine(diaAtual.ToString("d"));
        Console.WriteLine(diaAtual.ToString("D"));
        Console.WriteLine(diaAtual.ToString("g"));
        Console.WriteLine(diaAtual.ToString("G"));
    }
}
