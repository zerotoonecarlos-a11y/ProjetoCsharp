namespace FundamentosCSharp;

public class LINQ2
{
    public static void Executar()
    {
        var alunos = new List<Aluno>()
        {
            new() {Nome = "Carlos",  Idade = 23, Nota = 10.0},
            new() {Nome = "Andre",   Idade = 20, Nota = 5.50},
            new() {Nome = "Ana",     Idade = 22, Nota = 9.5},
            new() {Nome = "Ricardo", Idade = 43, Nota = 6.54},
            new() {Nome = "Lucas",   Idade = 33, Nota = 5.75},
            new() {Nome = "Vitor",   Idade = 34, Nota = 9.5},
            new() {Nome = "Jairo",   Idade = 27, Nota = 7.5},
            new() {Nome = "Ana",     Idade = 24, Nota = 8.5},
        };

        var carlos = alunos.Single(a => a.Nome.Equals("Carlos"));

        Console.WriteLine($"{carlos.Nome} {carlos.Nota}");

        var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));
        if (fulano == null) Console.WriteLine("Aluno inexistente");

        var ana = alunos.First(a => a.Nome.Equals("Ana"));
        Console.WriteLine(ana.Nota);

        var sicrano = alunos.FirstOrDefault(a => a.Nome.Equals("Sicrano"));
        if(sicrano == null) Console.WriteLine("Aluno inexistente");

        var outraAna = alunos.Last(a => a.Nome.Equals("Ana"));
        Console.WriteLine(outraAna.Nota);

        var exemploSkip = alunos.Skip(1).Take(3);
        foreach(var item in exemploSkip) Console.WriteLine(item);

        var maiorNota = alunos.Max(aluno => aluno.Nota);
        Console.WriteLine(maiorNota);

        var menorNota = alunos.Min(aluno => aluno.Nota);
        Console.WriteLine(menorNota);

        var somatorioNota = alunos.Sum(aluno => aluno.Nota);
        Console.WriteLine(somatorioNota);

        var mediaNota = alunos.Where(aluno => aluno.Nota >= 7).Average(aluno => aluno.Nota);
        Console.WriteLine(mediaNota);
    }
}
