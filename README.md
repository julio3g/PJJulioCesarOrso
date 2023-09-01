# Prog-II-Atividade: Configurando um Projeto ASP.NET MVC com Entity Framework Core

Este README fornece um guia passo a passo para criar um projeto ASP.NET MVC que utiliza Entity Framework Core para gerenciamento de dados. O objetivo é criar um aplicativo web simples para gerenciar informações de psicólogos.

## Requisitos
- Visual Studio instalado
- SQL Server
- .NET SDK

## Passos para Configuração

### Passo 1: Criação do Projeto
1. Abra o Visual Studio.
2. Vá em `File > New > Project`.
3. Selecione "ASP.NET Core Web App (MVC)" como template.
4. Nomeie o projeto como `PjNomeSobrenome`.
5. Escolha a versão do .NET e desative o HTTPS.

### Passo 2: Configurando NuGet Packages
1. Abra o gerenciador de pacotes NuGet (`Tools > NuGet Package Manager > Manage NuGet Packages for Solution`).
2. Instale os seguintes pacotes:
    - `Microsoft.AspNetCore.Identity.EntityFrameworkCore`
    - `Microsoft.EntityFrameworkCore.Design`
    - `Microsoft.EntityFrameworkCore.SqlServer`

### Passo 3: Definindo o Modelo
1. Crie uma pasta chamada `Models` dentro do projeto.
2. Adicione duas classes C# chamadas `AppUser` e `Psicologo`.
3. Em `AppUser`, defina os objetos comuns para todos os cadastros (por exemplo, `Id`, `Username`, `Email`).
4. Em `Psicologo`, defina objetos específicos (`Id`, `Name`, `Crmv`, `Liberate`) e herde de `AppUser`.

### Passo 4: Configurando DbContext
1. Crie uma nova pasta chamada `Data`.
2. Dentro de `Data`, adicione uma nova classe chamada `AppDbContext`.
3. Faça a classe herdar de `IdentityDbContext<AppUser>`.

### Passo 5: Configurando a String de Conexão
1. Abra o arquivo `appsettings.json`.
2. Adicione uma string de conexão para o SQL Server.

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=your_server;Database=your_db;User Id=your_user;Password=your_password;"
  }
}
```

### Passo 6: Configurando o Program.cs
1. Abra o arquivo `Program.cs`.
2. Adicione os parâmetros necessários para configuração dos serviços da aplicação.

### Passo 7: Configurando o Entity Framework
1. Abra o terminal e vá até a pasta do projeto.
2. Instale o Entity Framework CLI usando `dotnet tool install --global dotnet-ef`.
3. Execute `dotnet ef migrations add Initial` para criar a migração inicial.
4. Execute `dotnet ef database update` para atualizar o banco de dados.

## Conclusão

Ao seguir esses passos, você terá um projeto ASP.NET MVC com uma implementação básica de Entity Framework Core para gerenciar dados de psicólogos.
