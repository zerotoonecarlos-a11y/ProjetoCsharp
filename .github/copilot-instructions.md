# Copilot Instructions for Encapsulamento Project

## Project Overview
Educational C# console application demonstrating core OOP concepts and advanced language features. Single-namespace project (`encapsulamento`) with .NET 10.0 target framework. Each module isolates specific concepts for learning.

## Architecture & Module Organization

**Four dedicated concept areas:**
- **`POO/`** - OOP fundamentals: Abstract classes (Abstract.cs), interfaces (Interface.cs), polymorphism (Polimorfismo.cs), sealed classes (Sealed.cs)
- **`MetodosEFuncoes/`** - Delegates, lambdas, anonymous methods, extension methods
- **`Excecoes/`** - Exception handling with custom exceptions (ExcecoesPersonalizadas.cs)
- **`Api/`** - Utility extensions; `PrimeiroArquivo.cs` demonstrates file I/O and extension methods

**Entry point:** Program.cs activates specific examples; Menu.cs provides interactive navigation.

## Key Patterns & Conventions

### Extension Methods
Defined as `public static` methods on static classes (e.g., `ExtensaoString.ParseHome()`). Used for cross-platform string utilities like path parsing.

### Primary Constructor Pattern
Classes use C# 12 primary constructors:
```csharp
public class Comida(double peso) { public double Peso { get; private set; } = peso; }
```
Base class inheritance: `public class Carne(double peso) : Comida(peso) {}`

### Property Encapsulation
Strict access control via `{ get; private set; }` or `{ private set; }` to enforce data integrity. Example: `Pessoa.Peso` prevents external modification.

### Polymorphism Through Base Classes
Subclasses override base methods for behavior variation (e.g., `Celular` abstract class with `Iphone` and `Motorola` implementations).

### Delegate Usage Patterns
- **Simple delegate:** `delegate double Soma(double a, double b);`
- **Delegates as parameters:** Pass methods matching delegate signatures
- **Anonymous methods & lambdas:** Prefer lambdas (`Func<>`, `Action`) for concise syntax

### Exception Handling
Try-catch-finally pattern shown in `PrimeiraExcepcao.cs`. Custom exceptions inherit from base exception types.

## Build & Run Workflow

```bash
dotnet build encapsulamento.csproj    # Compile; outputs to bin/Debug/net10.0/
dotnet run                             # Execute with Program.cs entry point
```

**Note:** Program.cs has most examples commented out. Uncomment specific module calls (e.g., `Menu.Iniciando()`, `Abstract.Executar()`) to run examples.

## Cross-File Communication & Naming

- **Single namespace:** All public types use `namespace encapsulamento;` at file top
- **Static Executar() methods:** Standard pattern for module execution: `ClassName.Executar()`
- **Console-driven interaction:** All examples write directly to console; no external dependencies

## Important Files & Patterns by Task

| Task | File | Pattern |
|------|------|---------|
| Add OOP example | `POO/NewConcept.cs` | Implement abstract/interface members; add `Executar()` method |
| Add functional example | `MetodosEFuncoes/NewFeature.cs` | Define delegates/lambdas; use `Func<>` and `Action` types |
| Add utility | `Api/Utilities.cs` | Use static extension class; mark methods `public static` |
| Test locally | Program.cs | Uncomment target class call; run `dotnet run` |
| Add to menu | Menu.cs | Add case in switch statement; call `ClassName.Executar()` |

## Development Notes

- **Namespace management:** All files already declare `namespace encapsulamento;` at top—maintain this consistently
- **File I/O cross-platform:** Use `Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)` and `Path.Combine()` for OS-agnostic paths
- **No external NuGet dependencies** visible; project self-contained for educational purposes
- **Nullable reference types:** Project uses nullable annotations; use `string?` and null-coalescing operators appropriately
