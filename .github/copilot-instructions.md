# Sobre o Projeto: Coleção de Exemplos em C#

Este projeto é uma aplicação de console em .NET 10, criada como um repositório de exemplos práticos para demonstrar diversos conceitos fundamentais e avançados da linguagem C#.

## Objetivo

O propósito principal é servir como uma ferramenta educacional e de consulta rápida para desenvolvedores C#. Ele é estruturado para que cada conceito seja isolado em seu próprio arquivo, facilitando o estudo e a compreensão.

## Estrutura de Diretórios

O código-fonte está organizado nos seguintes diretórios, cada um focado em uma área específica da linguagem:

-   **/POO/**: Contém exemplos relacionados aos pilares da Programação Orientada a Objetos.
    -   `Abstract.cs`: Demonstra o uso de classes e métodos abstratos.
    -   `Interface.cs`: Exemplo de implementação de interfaces.
    -   `Polimorfismo.cs`: Exemplo prático de polimorfismo.
    -   `Sealed.cs`: Demonstra o conceito de classes seladas (atualmente vazio).

-   **/MetodosEFuncoes/**: Focado em funções, delegados e expressões lambda.
    -   `DelegateComoParametro.cs`
    -   `DelegateFuncAnonima.cs`
    -   `ExemploLambda.cs`
    -   `LambdasDelegate.cs`
    -   `MetodosDeExtensao.cs`: Demonstra como criar e usar métodos de extensão.
    -   `UsandoDelegate.cs`

-   **/Excecoes/**: Contém exemplos de tratamento de exceções.
    -   `ExcecoesPersonalizadas.cs`: Como criar classes de exceção customizadas.
    -   `PrimeiraExcecao.cs`

-   **/Api/**: Atualmente, contém um exemplo simples de manipulação de arquivos.
    -   `PrimeiroArquivo.cs`: Demonstra operações básicas de leitura e escrita de arquivos.

## Como Executar o Projeto

A arquitetura principal foi projetada para ser controlada por um menu interativo.

### Executando o Menu Principal (Uso Pretendido)

A classe `Menu.cs` contém a lógica para exibir um menu no console, permitindo que o usuário escolha qual exemplo de código deseja executar. Para usar o projeto da forma como foi idealizado:

1.  Abra o arquivo `Program.cs`.
2.  Comente ou remova a linha `PrimeiroArquivo.Executar();`.
3.  Descomente ou adicione a linha `Menu.Iniciando();`.

Após essa alteração, ao executar o projeto (`dotnet run`), o menu principal será exibido.

### Execução Atual

No estado atual, o ponto de entrada (`Program.cs`) está configurado para executar diretamente o exemplo de manipulação de arquivos:

```csharp
// Program.cs
PrimeiroArquivo.Executar();
```

Isso significa que, ao rodar o projeto, apenas a funcionalidade de leitura e escrita de arquivos da classe `PrimeiroArquivo` será executada.

### Testando Outros Exemplos

Alguns exemplos, como os de polimorfismo e métodos de extensão, foram testados diretamente no `Program.cs` (como pode ser visto no código comentado). Para testá-los individualmente, você pode seguir o mesmo padrão: chamar o método de execução correspondente diretamente do método `Main`.