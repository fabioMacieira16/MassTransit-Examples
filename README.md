# Recursos ultilizados

.Net Core SDK 5.0
RabbitMQ 
Masstransit
Masstransit.RabbitMQ
Masstransit.AspNetCore

** Interfaces a recursos mais usados com Asp .Net Core: **
 - IBusControl -> Usado para iniciar/para o bus.
 - IBus -> Public/Envia Mensagem no bus iniciando uma nova comunicação.
 - ISendEndpoint -> Envias as mensagem a parti das dependências do consumer.
 - AddMassTransit -> Método ultilizado para registrar os tipos para outros components
 - MassTrasitHostService -> Inicia/para automaticamente a aplicação

 ** Filas **
 	- rabbitmq://localhost/orderTicketQueue
