# Especificação de APIs

> A especificação de APIs descreve os principais endpoints da API RESTful do produto
> de software, os métodos HTTP associados a cada endpoint, suas descrições, os formatos
> de respostas, os parâmetros de URL esperados e o mecanismo de autenticação e autorização 
> utilizado.

## Endpoints API

| Endpoint                            | Método  | Descrição                                  | Parâmetros                       | Formato da Resposta | Autenticação e Autorização |
|-------------------------------------|---------|--------------------------------------------|----------------------------------|---------------------|----------------------------|
| /api/agenda/                        | POST    | Criar uma nova agenda                      | agenda (objeto JSON)             | JSON                | JWT Token                   |
| /api/agenda/{id}                    | GET     | Obter detalhes de uma agenda específica    | id (int)                         | JSON                | JWT Token                   |
| /api/agenda/{id}                    | PUT     | Atualizar uma agenda existente             | id (int), agenda (objeto JSON)   | JSON                | JWT Token                   |
| /cadastro/                          | POST    | Criar um novo usuário                      | user (objeto JSON)               | JSON                | JWT Token                   |
| /cadastro/{id}                      | GET     | Obter detalhes de um usuário específico    | id (int)                         | JSON                | JWT Token                   |
| /cadastro/{id}                      | PUT     | Atualizar um usuário existente             | id (int), user (objeto JSON)     | JSON                | JWT Token                   |
| /ViagemEventos/                          | POST    | Criar um novo Evento de Viagens                     | ViagemEventos (objeto JSON)               | JSON                | JWT Token                   |
| /ViagemEventos/{id}                      | GET     | Obter detalhes de um Evento de Viagens específico    | id (int)                         | JSON                | JWT Token                   |
| /ViagemEventos/{id}                      | PUT     | Atualizar um Evento de Viagens existente             | id (int), user (objeto JSON)     | JSON                | JWT Token                   |

[Retorna](../README.md)
