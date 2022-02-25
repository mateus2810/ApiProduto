# ApiProduto

### Clonar projeto
```
gitclone https://github.com/mateus2810/ApiProduto.git
```

### Fazer download aplicação .netframework versao 5
https://dotnet.microsoft.com/en-us/download/dotnet/5.0

### Download sqlserver
Banco utilizado sqlserver
https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

### Execuções dentro do SQL Server

Criação de base de dados:
```
create database Banco_desenvolvimento
```
Utilização da base de dados criada:
```
use Banco_desenvolvimento
```

Criação de tabela que será utilizada pelo sistema
```
Create table produto(
idProduto int identify(1,1),
nome varchar(30),
preco numeric(10,2),
precoPromocional(10,2),
quantidade int);
```
### Connection string banco de dados dentro da aplicação

No arquivo "appsettings.json" alterar a connection string
![image](https://user-images.githubusercontent.com/20459665/155740357-2e39fa7c-834b-4b24-9612-860b8ae3be02.png)
