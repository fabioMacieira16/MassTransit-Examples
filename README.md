# Recursos ultilizados

.Net Core SDK 5.0
RabbitMQ 
Masstransit
Masstransit.RabbitMQ
Masstransit.AspNetCore

** Interfaces a recursos mais usados com Asp .Net Core: **
 - IBusControl -> Usado para iniciar/para o bus.
 - IBus -> Public/Envia Mensagem no bus iniciando uma nova comunica��o.
 - ISendEndpoint -> Envias as mensagem a parti das depend�ncias do consumer.
 - AddMassTransit -> M�todo ultilizado para registrar os tipos para outros components
 - MassTrasitHostService -> Inicia/para automaticamente a aplica��o

 ** Filas **
 	- rabbitmq://localhost/orderTicketQueue
