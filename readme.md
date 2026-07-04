# ByteBankIO

Projeto de estudo em C# para explorar operações de entrada e saída com arquivos em .NET.

## Objetivo

O ByteBankIO demonstra como trabalhar com diferentes formas de leitura e escrita de arquivos, incluindo:

- arquivos texto;
- arquivos CSV;
- arquivos binários;
- streams de leitura e escrita.

O projeto também utiliza classes simples de domínio para representar clientes e contas correntes.

## Estrutura do projeto

- [ByteBankIO/Program.cs](ByteBankIO/Program.cs): ponto de entrada da aplicação.
- [ByteBankIO/Domain/Cliente.cs](ByteBankIO/Domain/Cliente.cs): modelo de cliente.
- [ByteBankIO/Domain/ContaCorrente.cs](ByteBankIO/Domain/ContaCorrente.cs): modelo de conta corrente.
- [ByteBankIO/Handlers](ByteBankIO/Handlers): classes responsáveis pelas operações com arquivos.

## Funcionalidades demonstradas

- escrita e leitura de dados em formato binário com BinaryWriter e BinaryReader;
- leitura de contas a partir de arquivos de texto;
- criação de arquivos CSV e TXT;
- uso de FileStream para manipulação direta de bytes.

## Requisitos

- .NET SDK 10.0 ou superior
- terminal/console para executar a aplicação

## Como executar

No diretório raiz do projeto, execute:

```bash
dotnet run --project ByteBankIO/ByteBankIO.csproj
```

## Observações

Alguns exemplos do projeto utilizam caminhos absolutos para arquivos na estrutura do workspace. Se você mover o projeto para outro diretório, pode ser necessário ajustar esses caminhos.
