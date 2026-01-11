# Documentação do Projeto C# de Oriencatação a Objetos

## Descrição

Este projeto é uma aplicação de console em C# desenvolvida para demonstrar e praticar conceitos fundamentais de Programação Orientada a Objetos (POO). O código está estruturado em diferentes arquivos, cada um focando em um conceito específico como abstração, interfaces, e polimorfismo.

O namespace utilizado em todo o projeto é `encapsulamento`, conforme definido nos arquivos `.cs`.
Em algum outro momento pode ser alterador.

## Conceitos Demonstrados

O projeto ilustra os seguintes conceitos de POO:

- **Abstração:** Através da classe abstrata `Celular` e suas implementações `Iphone`, `Motorola`, e `Samsung`.
- **Encapsulamento:** Utilizado na classe `Pessoa`, onde o `Peso` é uma propriedade com um `set` privado, controlando como o valor é modificado.
- **Polimorfismo:** Demonstrado no método `Comer` da classe `Pessoa`, que pode receber qualquer objeto que herde de `Comida`.
- **Interfaces:** Representado pela interface `IOperacaoBinaria` e a sua implementação na classe `Soma`.
- **Herança:** As classes `Iphone`, `Motorola`, `Samsung`, `Carne`, `Arroz`, e `Feijao` herdam de `Celular` e `Comida`, respectivamente.

## Estrutura do Código

O projeto está organizado nos seguintes arquivos:

- **`Program.cs`**: Ponto de entrada da aplicação. Ele inicia a interação com o usuário chamando a classe `Menu`.

- **`Menu.cs`**: Contém a classe `Menu`, responsável por exibir um menu interativo no console. O usuário pode escolher qual exemplo de POO deseja executar.

- **`Abstract.cs`**: Demonstra o uso de classes abstratas.
    - `Celular`: Classe abstrata que define um contrato para diferentes tipos de celulares.
    - `Iphone`, `Motorola`, `Samsung`: Classes que herdam de `Celular` e implementam seus métodos abstratos.
    - `Abstract`: Classe estática com um método `Executar` para rodar o exemplo de abstração.

- **`Interface.cs`**: Demonstra o uso de interfaces.
    - `IOperacaoBinaria`: Interface que define a assinatura de uma operação binária.
    - `Soma`: Classe que implementa a interface `IOperacaoBinaria` para realizar uma soma.
    - `Interface`: Classe com um método `Executar` para rodar o exemplo de interface.

- **`Polimorfismo.cs`**: Demonstra o polimorfismo.
    - `Comida`: Classe base para diferentes tipos de alimentos.
    - `Carne`, `Arroz`, `Feijao`: Classes que herdam de `Comida`.
    - `Pessoa`: Classe que possui um método `Comer` que aceita qualquer tipo de `Comida`, demonstrando polimorfismo.

- **`encapsulamento.csproj`**: Arquivo de projeto do C#, que define as configurações do projeto, como o `TargetFramework`.

## Como Executar

Para compilar e executar o projeto, siga os passos abaixo:

1. **Abra um terminal** na pasta raiz do projeto.

2. **Execute o seguinte comando** para compilar e rodar a aplicação:

   ```bash
   dotnet run
   ```

3. **Siga as instruções no console** para interagir com o menu e executar os exemplos de POO.
