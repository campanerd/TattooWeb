# ADR-003 — ArtistSpecialty como Enum

## Status
Aceito

## Contexto
O campo `specialty` do artista poderia ser uma string livre, permitindo qualquer valor.

## Decisão
Criamos o enum `ArtistSpecialty` com valores fixos: Blackwork, Realismo, Aquarela, Geometrico, OldSchool, Mandala, Fineline, Tribal, Japones, Neotradicional.

## Motivos
- Evita valores inválidos ou inconsistentes no banco
- O GraphQL expõe o enum como string legível (ex: `BLACKWORK`) em vez de número
- Mais fácil de filtrar e exibir no frontend

## Consequências
- Para adicionar uma nova especialidade é necessário alterar o enum e criar uma migration
- O banco armazena como `integer` — o EF Core converte automaticamente
