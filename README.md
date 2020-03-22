<p align="center">
  <img alt="ctdig logo" src="logo.png" />
</p>

## Execução do projeto
Para executar o projeto:

```
git clone https://github.com/willmont1982/ctdig.git
cd ctdig
docker-compose up --build -d
```
## Sobre
A Aplicação CtDig simula um banco digital, contendo a área do cliente da agência e area administrativa onde o mesmo podera fazer depósitos e transferências.

## Acesso da Aplicação com CNPJ e Senha:

CNPJ: 03569262000160

Senha: 123456

## Iniciando o projeto
- Na tela de inicio da aplicação pela primeira devera ser cadastrado a agência junto com user admin.
- Criando a conta o cliente ficará pendente até que o admin aprove o seu cadastro.
- Caso aprove ou recuse, um evento de envio de simulação de e-mail sera emitido avisando o cliente.
- Aprovando, cria-se uma conta junto ao cliente sem saldo.
- Disponibilidade de depositos online que ao cadastrado ficará como pendente, efetuado posteriormente.
- Clientes realizarão uma transferência para outras contas solicitando a transferência ela ficará como pendente, sendo adicionada posteriormente ou cancelada.
- Depósito ou transferência forem cancelados será disparado um evento simulando o envio de e-mail notificando os clientes.
- Depósito ou transferência forem efetuados sem restrição, a movimentação sera dada como OK.

## Informações extras do projeto
- Moedas em centavos convertidas em reais para o cliente
- A cada transação terá 30 segundos de espera para uma nova.
- O projeto pode levar alguns segundos para iniciar, pois o serviço de filas do RabbitMQ possui um delay. 

## Autor 👦

* Willian Roberto Montrezol - [GitHub](https://github.com/willmont1982)
