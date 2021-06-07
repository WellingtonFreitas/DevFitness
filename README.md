# DevFitness
 #### Tela aplicação console
![Tela aplicação console](https://github.com/WellingtonFreitas/DevFitness/blob/main/Images/telaConsoleAPP.png?raw=true)
 
 #### Tela Swagger com rotas da API    
![Tela Swagger com rotas da API](https://github.com/WellingtonFreitas/DevFitness/blob/main/Images/telaSwagger.png?raw=true)


## Descrição do Projeto
<p>
DevFitness é um projeto criado durante o o evento Jornada .NET; ele contém uma aplicação console e uma API. 
O oprojeto tem como objetivo gerenciar dados de saúde, alimentação, consumo calórico diário do usuário.
 </p>
 
## Tecnologias e práticas utilizadas


-   Visual Studio 2019
-   SQL Server Express
-   ASP.NET Core com .NET 5
-   Entity Framework Core
-   Dapper
-   Swagger
-   AutoMapper
-   Injeção de Dependência
-   Programação Orientada a Objetos
-   Publicação na nuvem

## Principais Funcionalidades

-   Cadastro, Listagem, Detalhes, Atualização e Remoção de Refeição.
-   Cadastro e atualização de Usuário
-   Geração de dados para relatório de balanço energético
  
## Executando o projeto em sua maquina local

  
Essas instruções fornecerão uma cópia do projeto completo instalado e funcionando em sua máquina local para fins de desenvolvimento e teste.

* Para fazer o download do projeto siga as seguintes instruções:

```
1. git clone https://github.com/WellingtonFreitas/DevFitness.git
```
```
2. Caso não tenha uma instancia local do SQL Server Express, siga o seguinte passo
 	Abra o arquivo Startup.cs e mude a linha  
	   services.AddDbContext<DevCarsDbContext>(options => options.UseSqlServer(connectionString)); 
     	para
	   services.AddDbContext<DevCarsDbContext>(options => options.UseInMemoryDatabase("DevFitness"));
```
```
3. Antes de execultar selecione qual projeto deseja, como mostrar a imagem a seguir:	
```
<img style="border-radius: 100%;" src="https://github.com/WellingtonFreitas/DevFitness/blob/main/Images/selecionando%20projeto%20visulaStudio.png?raw=true" alt=""/>

```
5. Para execultar a API com banco de dados sem uma instancia local do SQL Server Express, siga o seguinte passo
 	Abra o arquivo Startup.cs e mude a linha  
	   services.AddDbContext<DevCarsDbContext>(options => options.UseSqlServer(connectionString)); 
     	para
	   services.AddDbContext<DevCarsDbContext>(options => options.UseInMemoryDatabase("DevFitness"));
```

### Autor
---

<a href="https://github.com/WellingtonFreitas">
 <img style="border-radius: 100%;" src=https://avatars.githubusercontent.com/u/72938207?s=400&u=9c4637de193798aec28c20978e83b0ff7f8b4f28&v=4" width="100px;" alt=""/>
 <br />
 <sub><b>Wellington Freitas</b></sub></a> <a> 


Entre em contato!
</br>
[![Linkedin Badge](https://img.shields.io/badge/-WellingtonFreitas-blue?style=flat-square&logo=Linkedin&logoColor=white&link=https://www.linkedin.com/in/wellington-freitas-43624283/)](https://www.linkedin.com/in/wellington-freitas-43624283/) [![Gmail badge](https://img.shields.io/badge/-wellington.m.de.freitas-red?style=flat-square&logo=Gmail&logoColor=white&link=mailto:wellington.m.de.freitas@gmail.com)](mailto:wellington.m.de.freitas@gmail.com)
