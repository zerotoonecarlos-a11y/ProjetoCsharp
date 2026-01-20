using System.Security.Cryptography;

namespace FundamentosCSharp;

public class Aluno
{
    public string Nome = " ";
    public int Idade = 0;
    public double Nota = 0;
}

public class LINQ1
{
    public static void Executar()
    {
        var alunos = new List<Aluno>()
        {
            new() {Nome = "Carlos",  Idade = 23, Nota = 10.0},
            new() {Nome = "Andre",   Idade = 20, Nota = 5.50},
            new() {Nome = "Ricardo", Idade = 43, Nota = 6.54},
            new() {Nome = "Lucas",   Idade = 33, Nota = 5.75},
            new() {Nome = "Vitor",   Idade = 34, Nota = 9.5},
            new() {Nome = "Jairo",   Idade = 27, Nota = 7.5},
            new() {Nome = "Ana",     Idade = 24, Nota = 8.5},
        };

        Console.WriteLine("== Aprovados =========");
        var aprovados = alunos.Where(a => a.Nota > 7).OrderBy(a => a.Nome);
        foreach (var aluno in aprovados) Console.WriteLine(aluno.Nome);


        Console.WriteLine("\n== Chamada ============");
        var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
        foreach(var aluno in chamada) Console.WriteLine(aluno);


        Console.WriteLine("\n== Aprovados (por idade)");
        var alunosAprovados =
            from aluno in alunos
            where(aluno.Nota >= 7)
            orderby(aluno.Idade)
            select aluno.Nome;

        foreach(var aluno in alunosAprovados) Console.WriteLine(aluno);
    }
}
