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
    Ap�s o CLI baixar e instalar as bibliotecas � recomendado executar "dotnet restore"
    Garante que todas as bibliotecas definidas no arq estar�o instaladas.

Para se conectar a qualquer banco � necess�rio ter um arquivo de configura��o, isso para qualquer banco.
Neste arquivos estar�o todas as conficura��es do banco.
  no nosso caso criamos ele em Database\ApplicationDBContext.cs

CREATE DATABASE `efprojeto` /*!40100 COLLATE 'latin1_general_cs' */;

