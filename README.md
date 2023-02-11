# CleanCodeMvc
Portifolio em C#
# Clean Architecture
## APLICATION
Camada onde contem todos detalhes técnicos configurações e implementações.
- Dto -> Objeto de transferência de dados usado nos limites de uma aplicação.
- Interfaces -> Esta pasta é usada para adicionar todas as especificações.
- Services -> Pasta onde estar todos serviços personalizados do sistema.

## DOMAIN
Camada onde fica a interface do Projeto. Sem dependencias externas.
- Entities -> atributos do sistema.
- Interfaces -> interface de comunicação.

## INFRA-DATA
Adicione a pasta Data na camada de infraestrutura que é usada para adicionar a classe de contexto do banco de dados.
- Interfaces -> A implementação de todas asa ssinaturas dos Repositories que estão na pasta interfaces no domain que são as ações do sistema como crud.
- Context -> Propriedades do DbSet, para migração.

## INFRASTRUTURE
- Injection -> E um condutor que vai depender apenas do pacote domain para executar as regras de negocio.
O código nesta camada contém regras de negócios específicas do aplicativo. Ele encapsula e implementa todos os casos de uso do sistema. Esses casos de uso orquestram o fluxo de dados  para as entidades e direcionam essas entidades a usar suas regras de negócios  para atingir as metas do caso de uso.
