# ADR-004 — Connection String no appsettings.Development.json

## Status
Aceito

## Contexto
A connection string do PostgreSQL contém senha e não deve ser exposta no repositório.

## Decisão
A connection string fica no `appsettings.Development.json`, que está no `.gitignore`. O `appsettings.json` contém apenas a chave vazia como referência.

## Motivos
- Senha não vai para o repositório
- Cada desenvolvedor configura sua própria connection string localmente
- O `docker-compose.yml` já documenta os dados de conexão necessários

## Consequências
- Novo desenvolvedor precisa criar o `appsettings.Development.json` manualmente ao clonar
- O `docker-compose.yml` serve como referência para os dados de conexão
