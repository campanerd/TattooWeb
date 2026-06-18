# ADR-005 — Service Name como Unique

## Status
Aceito

## Contexto
O campo `name` da tabela `service` inicialmente não tinha restrição de unicidade, permitindo dois serviços com o mesmo nome.

## Decisão
Adicionamos `unique` no campo `name` da tabela `service` no schema e na migration.

## Motivos
- Regra de negócio do salão: não existem dois serviços com o mesmo nome
- Permite busca por nome via `FindByNameAsync` no repositório com garantia de retorno único
- Evita duplicatas acidentais no cadastro

## Consequências
- Tentativa de cadastrar serviço com nome existente retorna erro do banco
- A aplicação deve tratar esse erro e retornar mensagem adequada ao usuário
