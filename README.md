# Desafio-CAPEF
Desafio realizado para o processo seletivo da CAPEF.

</br>

### Especificação
Criar um CRUD para gerenciamento de empregados em C#.

</br>

### Como rodar o projeto
<hr/>

Faça um clone do projeto na sua máquina:
 - É possível realizar o clone por meio de HTTPS: ``` git clone https://github.com/Fabio-Vicente/Desafio-CAPEF.git ```
 - É possível realizar o clone por meio de SSH: ``` git clone git@github.com:Fabio-Vicente/Desafio-CAPEF.git ```
 - É possível baixar um zip do projeto. Para isso é necessário clicar no botão verde ```Code``` e depois em ```Download ZIP```
 
 <br/>

Uma vez com o projeto na máquina local, é necessário os seguintes passos para executá-lo:
 - Garantir a execução de um banco de dados SQL Server na porta rodando na porta 1433.
   - Para ajudar esse requisito, foi fornecido um orquestrador que faz o gerenciamento desse banco. Caso deseje utilizá-lo, o seguinte comando deverá ser executado na raiz do projeto:
```
docker-compose up -d
```
Obs: é necessário ter o [Docker Compose](https://docs.docker.com/compose/install/) instalado na máquina
 - Rodar a aplicação. Isso pode ser feito executando-se esse comando na raiz do projeto:
 ```
 dotnet run --project src/desafio-capef.csproj
 ```
 Obs: é preciso ter instalado o .Net na máquina.
 
 <br />
 
 ### Já rodei o projeto. Como faço para visualizar a aplicação?
 <hr />
 
 Uma vez que a aplicação já está rodando, é possível acessá-la por meio do próprio endereço informado pelo .Net. É provável que o endereço de acesso seja esse:
 > https://localhost:7216/Swagger/index.html
 
 Copie e cole esse endereço em um navegador de internet.

##### O endereço não funcionou? Procure pelas portas informadas pelo .Net no próprio terminal. Apenas substitua o número "7216" no endereço acima por um outro disponibilizado pelo .NET.

<br />

### Como funciona a aplicação?
<hr />

A aplicação consiste em 5 rotas para o tratamento da informação:
 - A primeira delas faz a impressão de um relatório indicando quantos empregados existem no banco de dados e trazendo uma lista com todos eles;
 > GET /Staff
 - A outras rotas representão o acrônimo da realização CRUD para um único empregado:
 ```
 C - Create (Inserção):
 ```
 > POST /Staff
 ```
 R - Read (Busca):
 ```
 > GET /Staff/{id}
 ```
 U - Update (Alteração):
 ```
 > PUT /Staff/{id}
 ```
 D - Delete (Remoção):
 ```
> DELETE /Staff/{id}

<br />
 
###### Obs: Algumas validações foram feitas para se garantir a conformidade dos dados registrados, como a quantidade de dígitos de um CPF ou o formato padrão para um endereço de email. As informações conforme os campos indicados. As alterações realizadas ficam persistidas em banco de dados.

<br />

#### Divirta-se fazendo fazendo várias operações no staff de empregados. 😃

<br />

### Como o código foi desenvolvido?

<hr />

 - Programação Orientada a Objeto;
 - Implementação de camadas de Model e Controllers;
 - Implementação do Repository Pattern;
 - Utilização do ORM (Object-Relational Mapping) Entity Framework;
 - Atendimento aos princípios SOLID;
 - Implantação da aplicação utilizando Docker e Docker-Compose;

<br />

### Ficou com alguma dúvida? Entre em contato comigo:

[![WhatsApp](https://img.shields.io/badge/whatsapp-25D366?style=for-the-badge&logo=whatsapp&logoColor=white)](https://wa.me/5571991366088)
[![Gmail](https://img.shields.io/badge/gmail-EA4335?style=for-the-badge&logo=gmail&logoColor=white)](mailto:fabiolvsantos93@gmail.com)
[![Linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/fabio-vicente/)
