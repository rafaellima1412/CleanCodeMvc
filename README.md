# CleanCodeMvc
Portifolio em C#
# Clean Architecture
## APLICATION
Camada onde contem todos detalhes técnicos configurações e implementações.
- dto -> Objeto de transferência de dados usado nos limites de uma aplicação.

## DOMAIN
Camada onde fica a interface do Projeto. Sem dependencias externas.
- entities -> atributos do sistema.
- interfaces -> interface de comunicação.

## INFRA-DATA
A implementação da assinatura do Repository.
- interfaces -> ações do sistema como crud.

## INFRASTRUTURE
Injection -> E um condutor que vai depender apenas do pacote domain para executar as regras de negocio.
O código nesta camada contém regras de negócios específicas do aplicativo. Ele encapsula e implementa todos os casos de uso do sistema. Esses casos de uso orquestram o fluxo de dados  para as entidades e direcionam essas entidades a usar suas regras de negócios  para atingir as metas do caso de uso.
