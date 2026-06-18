# ADR-001 — GraphQL em vez de REST puro

## Status
Aceito

## Contexto
O projeto TattooWeb precisa de uma API para ser consumida por um frontend. A abordagem tradicional seria REST com múltiplos endpoints.

## Decisão
Adotamos GraphQL via Hot Chocolate como principal forma de exposição da API, mantendo os controllers REST apenas como camada legada.

## Motivos
- O frontend pode pedir exatamente os campos que precisa, sem over-fetching
- Um único endpoint `/graphql` em vez de vários endpoints REST
- Filtros, ordenação e paginação gerados automaticamente pelo Hot Chocolate + EF Core
- Alinhado com a direção do projeto IcrHub, que também está migrando para GraphQL

## Consequências
- Curva de aprendizado maior para quem não conhece GraphQL
- Queries e mutations substituem GET/POST/PUT/DELETE
