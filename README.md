# SchoolOfNet_Iniciando_ASPNet_CORE_Entity_Framework
ASP.NET Core e Entity Framework - Schoolofnet

Docker do MYSQL:
docker-compose.yml
Comand:
 docker-compose up db

Criar projeto:
 dotnet new mvc

Executar projeto:
 dotnet watch run

Para usar Mysql deve:
  Acessar https://www.nuget.org/
  Pesquisar pelo pacote:
    MySQL Entity Framework
    Selecionar o pacote: Pomelo.EntityFrameworkCore.MySql 
    copiar a linha de comando .NET CLI:
     exemplo: dotnet add package Pomelo.EntityFrameworkCore.MySql --version 2.2.0
    E executar no cmd
    Após o CLI baixar e instalar as bibliotecas é recomendado executar "dotnet restore"
    Garante que todas as bibliotecas definidas no arq estarão instaladas.

Para se conectar a qualquer banco é necessário ter um arquivo de configuração, isso para qualquer banco.
Neste arquivos estarão todas as conficurações do banco.
  no nosso caso criamos ele em Database\ApplicationDBContext.cs

CREATE DATABASE `efprojeto` /*!40100 COLLATE 'latin1_general_cs' */;

Para migrações usa o "dotnet ef"
  dotnet ef --help

criar uma migração:
 dotnet ef migrations add migracao_000_Funcionario
 OBS: Lembranco que os atribod devem começar com letra maiuscula e ser publico.
      La no ApplicationDBContext a definição do mapeamento da classe deve serm publica e ter os get e set

Executando as migrações pendentes:
  dotnet ef database update
Para editar a tabela, criar o atributo na classe e gera uma nova migração
  dotnet ef migrations add migracao_001_Funcionario

Depois sobe a migração para o banco;
  dotnet ef database update

=================
OBS: ATENÇÃO, SEMPRE QUE MODIFICAR A TABELA OS DADOS DA TABELA SERÃO PERDIDOS.
=================