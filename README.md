# Documentação do Projeto de Estudos em C#

## Descrição

Este projeto é uma aplicação de console em C# desenvolvida para demonstrar e praticar conceitos fundamentais de Programação Orientada a Objetos (POO) e funcionalidades avançadas da linguagem, como Delegates e expressões Lambda. O código está estruturado em diferentes arquivos, cada um focando em um conceito específico.

O namespace utilizado em todo o projeto é `encapsulamento`.

## Conceitos Demonstrados

O projeto ilustra os seguintes conceitos:

### Programação Orientada a Objetos (POO)

- **Abstração:** Através da classe abstrata `Celular` e suas implementações.
- **Encapsulamento:** Utilizado na classe `Pessoa`, onde o acesso a certas propriedades é controlado.
- **Polimorfismo:** Demonstrado com o método `Comer` da classe `Pessoa`, que aceita qualquer objeto derivado de `Comida`.
- **Interfaces:** Representado pela interface `IOperacaoBinaria` e sua implementação.
- **Herança:** Utilizada em várias classes que herdam de classes base como `Celular` e `Comida`.
- **Classes Seladas (Sealed):** Demonstração de classes que não podem ser herdadas.

### Métodos e Funções Avançadas

- **Delegates:** Uso de delegates para referenciar métodos, incluindo passagem de delegates como parâmetros.
- **Métodos Anônimos:** Uso de `delegate` para criar métodos anônimos.
- **Expressões Lambda:** Demonstração da sintaxe concisa de expressões lambda em substituição a métodos anônimos.
- **Métodos de Extensão:** O arquivo `MetodosDeExtensao.cs` mostra como adicionar novos métodos a tipos existentes sem modificar o código-fonte original.

### Manipulação de Arquivos (API de I/O)

- **Criação e Escrita de Arquivos:** O arquivo `PrimeiroArquivo.cs` usa `StreamWriter` para criar e escrever em arquivos de texto.
- **Leitura de Arquivos:** `LendoArquivo.cs` demonstra como ler o conteúdo de arquivos.
- **Uso da classe `Path`:** `ExemploPath.cs` mostra como extrair informações de caminhos de arquivos (diretório, nome do arquivo, extensão).
- **Uso de `FileInfo` e `DirectoryInfo`:** Os arquivos `ExemploFileInfo.cs` e `ExemploDirectoryInfo.cs` ilustram a manipulação de informações de arquivos e diretórios de forma orientada a objetos.
- **Listagem de Diretórios:** `Diretorios.cs` mostra como listar os diretórios.

### Tratamento de Exceções

- **Exceções Comuns:** `PrimeiraExcecao.cs` demonstra o bloco `try-catch-finally` para capturar exceções, como `FileNotFoundException`.
- **Exceções Personalizadas:** `ExcecoesPersonalizadas.cs` ensina como criar suas próprias classes de exceção herdando de `Exception`.

## Estrutura do Projeto

O projeto está organizado nos seguintes diretórios e arquivos:

- **`Program.cs`**: Ponto de entrada da aplicação. Inicia a interação com o usuário através da classe `Menu`.
- **`Menu.cs`**: Responsável por exibir um menu interativo no console, permitindo ao usuário escolher qual exemplo executar.

### `POO/`
- **`Abstract.cs`**: Demonstra o uso de classes abstratas (`Celular`).
- **`Interface.cs`**: Demonstra o uso de interfaces (`IOperacaoBinaria`).
- **`Polimorfismo.cs`**: Demonstra polimorfismo (`Pessoa` e `Comida`).
- **`Sealed.cs`**: Contém exemplos de classes seladas.

### `MetodosEFuncoes/`
- **`UsandoDelegate.cs`**: Exemplo básico de declaração e uso de um delegate.
- **`DelegateComoParametro.cs`**: Mostra como passar um delegate como parâmetro para outro método.
- **`DelegateFuncAnonima.cs`**: Demonstra a criação de um método anônimo usando a palavra-chave `delegate`.
- **`ExemploLambda.cs` / `LambdasDelegate.cs`**: Ilustram o uso de expressões lambda para criar funções de forma mais concisa.

### Arquivos de Projeto
- **`encapsulamento.csproj`**: Arquivo de projeto C# que define as configurações, como o TargetFramework (`net10.0`).
- **`encapsulamento.sln`**: Arquivo de solução do Visual Studio.

## Como Executar

Para compilar e executar o projeto, siga os passos abaixo:

1. **Abra um terminal** na pasta raiz do projeto.

2. **Execute o seguinte comando** para restaurar as dependências, compilar e rodar a aplicação:
   ```bash
   dotnet run
   ```

3. **Siga as instruções no console** para interagir com o menu e executar os exemplos desejados.