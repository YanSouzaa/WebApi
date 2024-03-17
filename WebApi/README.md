WebApi
Descrição do Projeto
A API de Produtos é uma aplicação backend que oferece funcionalidades completas de CRUD (Create, Read, Update, Delete) para gerenciar dados de produtos. 
Desenvolvida para ser flexível e altamente personalizável, a API permite que os usuários manipulem os dados da tabela "Produtos" de acordo com suas necessidades específicas.

Índice
1. Sobre
2. Tecnologias utilizadas
3. Instalação e uso

Sobre
Criação de Produtos: Adicione novos produtos à base de dados especificando seus atributos, como nome, estoque e valor.
Recuperação de Produtos: Consulte e visualize os produtos existentes na base de dados de forma rápida e eficiente.
Atualização de Produtos: Edite as informações dos produtos, como nome, estoque e valor, para manter os dados atualizados.
Exclusão de Produtos: Remova produtos da base de dados quando não forem mais necessários.
Personalização: A API é altamente personalizável e pode ser adaptada para atender às necessidades específicas do usuário ou do projeto.

Tecnologias Utilizadas
.NET 8: Plataforma de desenvolvimento de software da Microsoft para criar aplicativos web, desktop e móveis.
Entity Framework Core: ORM (Object-Relational Mapper) para .NET que simplifica o acesso e a manipulação de dados em banco de dados relacionais.
PostgreSQL: Sistema de gerenciamento de banco de dados relacional de código aberto e altamente escalável.
Swagger: Ferramenta para documentação e teste de APIs RESTful.

Instalação
Para começar a usar a API de Produtos em seu ambiente de desenvolvimento, siga estas etapas:

1. Clonar o Repositório: Clone o repositório do projeto para o seu ambiente local usando o seguinte comando:
git clone https://github.com/YanSouzaa/WebApi
2. Instalar Dependências: Navegue até o diretório raiz do projeto e instale as dependências necessárias usando o comando:
cd WebApi
dotnet restore
3. Configurar a Conexão com o Banco de Dados: Abra o arquivo appsettings.json localizado no diretório raiz do projeto WebApi e na raiz do projeto Products_Data atualize a string de conexão com o banco de dados PostgreSQL conforme necessário:
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=seu-host;Port=sua-porta;Database=seu-banco-de-dados;Username=seu-usuario;Password=sua-senha;"
  }
}
4. Executar as Migrações do Banco de Dados: Execute as migrações do Entity Framework Core para aplicar as alterações de modelo ao banco de dados PostgreSQL usando o seguinte comando:
dotnet ef database update
5. Executar o Projeto: Após configurar o banco de dados, inicie a aplicação executando o seguinte comando:
dotnet run
6. Testar a API: Use uma ferramenta Swagger UI para testar os endpoints da API e verificar se tudo está funcionando corretamente.

