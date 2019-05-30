# ArquiteturaCamadas
Este é um projeto simples que não possui evolução visual, foi feito apenas para apresentar o esqueleto de uma arquitetura que utiliza camadas de UI, Serviço e Interfaces, conta também com uma biblioteca para Enumeradores. 

A camada de UI utiliza a camada de Interfaces para utilizar os objetos de transferência de dados (Dto's), que são os utilizados como models na camada UI, esta camada utiliza a camada de interface para criar uma interface de serviços de usuário com a finalidade de acessar os serviços do sistema. 
A camada de Serviço possui uma camada dentro que é a de Repositório, os serviços fazem toda a validação e convertem os Dto em Objeto de Negócio para que, por exemplo, o repositório possa salvar, ou converte o Objeto de Negócio para Dto quando é efetuada uma consulta pelo repositório. A camada de repositório possui os mapeadores que mapeiam o objeto de negócio com a tabela equivalente do banco de dados e realiza todas as ações diretas ao banco de dados.

Basicamente é esta estrutura que utilizo em projeto web em C#.
