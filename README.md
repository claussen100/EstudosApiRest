# Minimal API RESTful em .NET — Estudo e Prática

Este projeto foi desenvolvido com o objetivo de estudar conceitos essenciais de APIs RESTful utilizando Minimal APIs no .NET, além de explorar boas práticas modernas do ecossistema. Vamos explorar todos os conceitos possíveis durante o desenvolvimento e preencher as lacunas de conhecimento que julgar defasadas durante todo o processo.

## 🎯 Objetivo do Projeto

Aqui foram estudados e aplicados:

- Os princípios fundamentais de uma API RESTful;
- Organização de rotas com MapGroup;
- Persistência com Entity Framework Core + SQLite;
- Diferença entre PUT, PATCH, GET, POST e DELETE;
- Documentação com Swagger/OpenAPI;
- Fluxo assíncrono com async/await e impacto em threads;
- Uso de dotnet watch run para Hot Reload no desenvolvimento.

## 🛠️ Tecnologias Utilizadas

- .NET 9 / C#
- ASP.NET Core Minimal API
- Swagger / Swashbuckle
- Entity Framework Core (SQLite e Migrations)

## 📁 Estrutura Simplificada

EstudosApiRest/
 ├── Data/
 │    └── AppDbContext.cs
 ├── Models/
 │    ├── PersonModel.cs
 │    └── PersonRequest.cs
 ├── Routes/
 │    └── PersonRoute.cs
 ├── Migrations/
 ├── Program.cs
 └── README.md

## 🚀 Como Executar

Clone o repositório:
git clone https://github.com/seuusuario/EstudosApiRest.git
cd EstudosApiRest

Execute com Hot Reload (recomendado):
dotnet watch run

Ou execute normalmente:
dotnet run

Acesse o Swagger:
https://localhost:<porta>/swagger

## 📚 O que foi aprendido neste projeto

Minimal APIs:
- Como criar uma API sem controllers
- Uso de MapGet, MapPost, MapPut, MapDelete, MapPatch
- Agrupamento de rotas com MapGroup
- Organização por módulos (/Routes/PersonRoute.cs)

REST e HTTP:
- Diferença entre REST (arquitetura) e HTTP (protocolo)
- Métodos HTTP e semântica correta

PATCH vs PUT:
- PUT reescreve o objeto completo
- PATCH atualiza apenas campos enviados

EF Core + SQLite:
- Configuração de AppDbContext
- Migrations
- Persistência em banco
- Diferença entre Model e DTO

Async/Await + Threading:
- await libera a thread
- Melhor escalabilidade da API

Desenvolvimento Produtivo:
- dotnet watch run
- Hot Reload vs Ctrl + R
- Atualização do Swagger

## 🔧 Endpoints

Pessoas (/people):
- GET /
- GET /{id}
- POST /
- PUT /{id}
- PATCH /{id}
- DELETE /{id}

## 🔮 Próximos Passos (opcionais):

- Alterar o projeto para implementar o método HTTP Patch
- Camadas Service/Repository
- JSON Patch (RFC 6902)

## Conclusão

O projeto serviu como um laboratório completo para entender Minimal APIs, REST, Persistência, Async, Swagger, Hot Reload e organização moderna de APIs no .NET.
