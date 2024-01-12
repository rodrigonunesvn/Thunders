# Gerenciador de Tarefas

## Introdução
O Gerenciador de Tarefas é uma aplicação desenvolvida para permitir a inclusão, exclusão, consulta e alteração de tarefas.

## Tecnologias Utilizadas

- .NET Core: Para o backend da aplicação.
-  SQL Server: Como sistema de gerenciamento de banco de dados.
-  Docker: Para contêinerização e fácil implantação.

## Instruções de Instalação e Configuração
Antes de começar, certifique-se de ter o Docker instalado em sua máquina. Clone o repositório para o seu ambiente local usando o Git.

## Como executar a aplicação

Navegue até a pasta raiz do projeto e execute o comando

```bash
  docker-compose up --build
```
    
Isso fará com que a API e o banco de dados SQL Server seja iniciados.

## Uso da API

Acesse http://localhost:8080/swagger para visualizar a documentação da API e testar as diferentes rotas e métodos disponíveis.

## Estrutura do Projeto

- TaskManager.API: Contém os controladores e a configuração da API.
- TaskManager.Application: Camada de serviço que contém a lógica de negócios.
- TaskManager.Domain: Define os modelos e interfaces usados na aplicação.
- TaskManager.Infrastructure: Implementa a persistência de dados.
- TaskManager.Persistence: Configurações de migração e contexto de banco de dados.
