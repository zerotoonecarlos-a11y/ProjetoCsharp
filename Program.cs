using encapsulamento;

// Menu.Iniciando();

var arroz = new Arroz(0.4);
var feijao = new Feijao(0.25);
var carne = new Carne(0.3);
var pessoa = new Pessoa(80.2);

pessoa.Comer(carne);
Console.WriteLine($"Peso atual: {pessoa.Peso} kg");