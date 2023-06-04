# Plano de Testes de Software (API)
Os testes em APIs REST baseadas em Swagger são fundamentais para garantir a funcionalidade e segurança do sistema. Eles validam a correta execução dos endpoints, identificam vulnerabilidades de segurança, avaliam o desempenho e corrigem bugs antes da implantação em produção. Com testes rigorosos, é possível evitar falhas que afetem os usuários finais e proteger os dados sensíveis. Além disso, os testes proporcionam informações valiosas a equipe de desenvolvimento, economizando tempo e recursos. Ao adotar uma abordagem sistemática de testes, as organizações podem fornecer APIs confiáveis, seguras e eficientes, promovendo a satisfação dos usuários e a integridade do sistema.

### Caso de Teste	= 001 - Cadastro de Usuarios
### Requisitos Associados: RF-001 Cadastro de fornecedores de serviços
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de criação de Usuarios método Post
## Passos:
<ul>
    <
</ul>
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2. Swagger URL localhost:7221/swagger/index.html.
3. Acessar Usuarios Cadastrar método Post. Request URL https://localhost:7221/api/Usuarios/cadastrar.
4. Clicar em Try it out, observar o Request Body deve esta em application/json.
5. Inserir os dados:{"nome": "string","email": "string","senha": "string","tipo": "string""cpf": "string","cep": "string", "telefone": "string","logradouro": "string","numero": "string","bairro": "string","cidade": "string","uf": "string"}.
6. Clicar em execute.
7. Critérios de Êxito: Será os atributos preenchidos e o código 200 Success.

### Caso de Teste	= 002 - Fazer login
### Requisitos Associados: RF-002 Os Usuarios devem fazer login para acessar o sistema.
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de login de Usuarios método Post
## Passos:
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2.Swagger URL localhost:7221/swagger/index.html.
3. Acessar Usuarios Login método Post. Request URL https://localhost:7221/api/Usuarios/login.
4. Clicar em Try it out, observar o Request Body deve esta em application/json.
5. Inserir os dados:{"email": "string", "senha": "string"}.
6. Clicar em execute.
7. Critérios de Êxito :	Será os atributos preenchidos e o código 200 Success.

# Plano de Testes de Software (Banco De Dados Criptografia Senha Usuarios)

A importância dos testes de criptografia de senhas de usuários em bancos de dados:
no mundo digital atual, a segurança das informações pessoais é uma preocupação crescente. Em um contexto em que os bancos de dados armazenam dados sensíveis, como senhas de usuários, é essencial garantir que essas informações estejam protegidas por meio de criptografia adequada. Nesse sentido, os testes de criptografia de senhas em bancos de dados desempenham um papel crucial na verificação e garantia da segurança das informações pessoais dos usuários.Proteção da confidencialidade dos usuários:
Os testes de criptografia de senhas têm como objetivo principal proteger a confidencialidade das informações pessoais dos usuários. Ao garantir que as senhas estejam armazenadas de forma criptografada, evita-se que terceiros não autorizados tenham acesso a esses dados sensíveis.

### Caso de Teste	= 003 - (Banco De Dados Criptografia Senha Usuarios)

### Objetivo do Teste	Avaliar:
Avaliar Segurança no armazenamento de senhas
## Passos:
O passo a passo para se conectar ao banco de dados da aplicação e verificar a criptografia das senhas dos usuários utilizando o SQL Server Management Studio:

"ConnectionStrings": {
    "DefaultConnection": "Data Source=SQL8003.site4now.net;Initial Catalog=db_a98226_servicos;User Id=db_a98226_servicos_admin;Password=M3l0@123"},

1. Abra o SQL Server Management Studio.

Na janela "Connect to Server" (Conectar ao Servidor), 

2. preencha as seguintes informações:
3. Server type (Tipo de servidor): Selecione "Database Engine" (Mecanismo de Banco de Dados).
4. Nome do servidor: SQL8003.site4now.net (informação fornecida na ConnectionString).
5. Authentication (Autenticação): Escolha "SQL Server Authentication" (Autenticação do SQL Server).
6. Login (Nome de usuário): db_a98226_servicos_admin (informação fornecida na ConnectionString).
7. Password (Senha): M3l0@123 (informação fornecida na ConnectionString).
8. Selecione "Remember password" (Lembrar senha) se desejar que o SSMS lembre a senha para futuras conexões.

9.Clique no botão "Connect" (Conectar) para estabelecer a conexão com o servidor.

10.Após a conexão ser estabelecida, navegue até a base de dados "db_a98226_servicos" (informação fornecida na ConnectionString) que contém as informações de usuários e senhas.

11.Selecione Nova Consulta execute SELECT * FROM usuarios;.

12.Verifique as configurações de criptografia aplicadas às colunas de senha.

13. Critérios de Êxito : senhas estejam devidamente criptografadas.





<!-- ### Caso de Teste	= 003 - Atualizar Cadastro
### Requisitos Associados: RF-001 Cadastro de fornecedores de serviços
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de Atualizar Cadastro de fornecedores
método PUT {ID}
## Passos:
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2. swagger informar a URL https://localhost/ .
3. Acessar o método PUT {ID}.
4. clicar em Try it out, observar o Request Body deve esta em application/json.
5. inserir os dados a serem atualizados  nome, cpf, telefone, e-mail, senha, repetir senha, Cep, logradouro, numero, complemento, bairro cidade, uf.
6. clicar em execute.
7.Critérios de Êxito :  -->



