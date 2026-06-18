# ADR-002 — Repository Pattern

## Status
Aceito

## Contexto
Os Use Cases precisam acessar o banco de dados. A abordagem mais simples seria injetar o DbContext diretamente nos Use Cases.

## Decisão
Adotamos o Repository Pattern com uma interface genérica `IBaseRepository<T>` no Domain e implementações concretas no Infrastructure.

## Motivos
- Application não conhece Infrastructure — depende apenas de interfaces do Domain
- Facilita testes unitários (mock do repositório em vez do DbContext)
- Se trocar PostgreSQL por outro banco, só muda a implementação no Infrastructure

## Consequências
- Mais arquivos para criar (interface + implementação por entidade)
- Camada de Application completamente desacoplada do EF Core
