# Worknow

## Alterações já feitas
- Configurado conexão com o banco
- Criado metodo update e delete na classe AutonomoModesls
- Criado metodo update e delete na classe EmpreendedorModels
- Configurado controllers do AutonomoModels
- Configurrado controllers do EmpreendedorModels<br>
**Resumo: O cadastro do AutonomoModels e EmpreendedorModels já está funcionando, porém foi criado uma iteração via console para testes das funcionalidades já implementadas**<br>

## O que falta fazer?
- Instegrar a interface e adaptar os métodos
- Arrumar o método **Atualizar** que ainda não está funcionando
- Revisão de todos os métodos

## Comando banco de dados
1. dotnet tool install dotnet-ef -g --version 3.1.1
2. dotnet add package Pomelo.EntityFrameworkCore.MySql
3. dotnet add package Pomelo.EntityFrameworkCore.MySql.Desing
4. dotnet add package Microsoft.EntityFrameworkCore
5. dotnet add package Microsoft.EntityFrameworkCore.Desing
6. dotnet ef migrations add InitialDB
7. dotnet ef database update
    - Para instalar o banco é só ligar o mysql no xampp e executar o comando no passo 7