<h1>WebApi</h1>

<h2>Descrição do Projeto</h2>

<p>A API de Produtos é uma aplicação backend que oferece funcionalidades completas de CRUD (Create, Read, Update,
    Delete) para gerenciar dados de produtos. Desenvolvida para ser flexível e altamente personalizável, a API permite
    que os usuários manipulem os dados da tabela "Produtos" de acordo com suas necessidades específicas.</p>

<h2>Índice</h2>

<ol>
    <li><a href="#sobre">Sobre</a></li>
    <li><a href="#tecnologias-utilizadas">Tecnologias utilizadas</a></li>
    <li><a href="#instalacao-e-uso">Instalação e uso</a></li>
</ol>

<h2 id="sobre">Sobre</h2>

<ul>
    <li><strong>Criação de Produtos:</strong> Adicione novos produtos à base de dados especificando seus atributos, como
        nome, estoque e valor.</li>
    <li><strong>Recuperação de Produtos:</strong> Consulte e visualize os produtos existentes na base de dados de forma
        rápida e eficiente.</li>
    <li><strong>Atualização de Produtos:</strong> Edite as informações dos produtos, como nome, estoque e valor, para
        manter os dados atualizados.</li>
    <li><strong>Exclusão de Produtos:</strong> Remova produtos da base de dados quando não forem mais necessários.</li>
    <li><strong>Personalização:</strong> A API é altamente personalizável e pode ser adaptada para atender às necessidades
        específicas do usuário ou do projeto.</li>
</ul>

<h2 id="tecnologias-utilizadas">Tecnologias Utilizadas</h2>

<ul>
    <li><strong>.NET 8:</strong> Plataforma de desenvolvimento de software da Microsoft para criar aplicativos web,
        desktop e móveis.</li>
    <li><strong>Entity Framework Core:</strong> ORM (Object-Relational Mapper) para .NET que simplifica o acesso e a
        manipulação de dados em banco de dados relacionais.</li>
    <li><strong>PostgreSQL:</strong> Sistema de gerenciamento de banco de dados relacional de código aberto e altamente
        escalável.</li>
    <li><strong>Swagger:</strong> Ferramenta para documentação e teste de APIs RESTful.</li>
</ul>

<h2 id="instalacao-e-uso">Instalação e Uso</h2>

<ol>
    <li><strong>Clonar o Repositório:</strong> Clone o repositório do projeto para o seu ambiente local usando o seguinte
        comando:<br><code>git clone https://github.com/YanSouzaa/WebApi</code></li>
    <li><strong>Instalar Dependências:</strong> Navegue até o diretório raiz do projeto e instale as dependências necessárias
        usando o comando:<br><code>cd WebApi<br></code>
         <br><code>dotnet restore</code></li>
    <li><strong>Configurar a Conexão com o Banco de Dados:</strong> Abra o arquivo <code>appsettings.json</code> localizado
        no diretório raiz do projeto <code>WebApi</code> e na raiz do projeto <code>Products_Data</code> atualize a string
        de conexão com o banco de dados PostgreSQL conforme necessário.</li>
    <li><strong>Executar as Migrações do Banco de Dados:</strong> Execute as migrações do Entity Framework Core para aplicar
        as alterações de modelo ao banco de dados PostgreSQL usando o seguinte comando:<br><code>dotnet ef database update</code></li>
    <li><strong>Executar o Projeto:</strong> Após configurar o banco de dados, inicie a aplicação executando o seguinte
        comando:<br><code>dotnet run</code></li>
    <li><strong>Testar a API:</strong> Use uma ferramenta Swagger UI para testar os endpoints da API e verificar se tudo
        está funcionando corretamente.</li>
</ol>
