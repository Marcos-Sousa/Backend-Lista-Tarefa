# Backend
  O projeto utiliza-se o entity framework in-memory, com isso, a integridade dos dados, são apenas em tempo de execução.
  Para rodar o projeto, basta apenas ter o visual studio, e startarmos o projeto.
 
 # Sobre a arquitetura do projeto
 Para realização de um código mais legível e organizado, utiliza-se de boas práticas de desenvolvimento, como por exemplo, criar comandos de entrada, para verificar se o modelo que está sendo inserido, está válido, criação de manipuladores para retirar a responsabilidade de adicionar e atualizar o item pelo controller,
 assim deixamos um controller com menos responsabilidade. Criação de interfaces, assim temos contrato, e com isso ganhamos na injenção de dependência, 
 ficamos vinculados a abstração e não a implementação. E também foi o utilizado o framework swagger, que irá auxiliar no consumo e visualização dos serviços da api.
 
  
  
  
