# Worknow

## Alterações já feitas
- Configurado conexão com o banco
- Criado metodo update e delete na classe AutonomoModesls
- Criado metodo update e delete na classe EmpreendedorModels
- Configurado controllers do AutonomoModels
- Configurado controllers do EmpreendedorModels<br>

## O está funcionando?
1. Cadastro de autônomo
2. Cadastro empreendedor mei 

## Comando banco de dados
1. dotnet tool install dotnet-ef -g --version 3.1.1
2. dotnet add package Pomelo.EntityFrameworkCore.MySql
3. dotnet add package Pomelo.EntityFrameworkCore.MySql.Desing
4. dotnet add package Microsoft.EntityFrameworkCore
5. dotnet add package Microsoft.EntityFrameworkCore.Desing
6. dotnet ef migrations add InitialDB
7. dotnet ef database update
    - Para instalar o banco é só ligar o mysql no xampp e executar o comando no passo 7

## Screenshots
![Alt text](/Screenshot/Menu.PNG?raw=true "Menu") <br>
![Alt text](/Screenshot/Cadastro_Autonomo.PNG?raw=true "Cadastro Autônomo") <br>
![Alt text](/Screenshot/Cadastro_EmpMei.PNG?raw=true "Cadastro Emp. MEI")
