# Plano de Testes de Software (API)
Os testes em APIs REST baseadas em Swagger são fundamentais para garantir a funcionalidade e segurança do sistema. Eles validam a correta execução dos endpoints, identificam vulnerabilidades de segurança, avaliam o desempenho e corrigem bugs antes da implantação em produção. Com testes rigorosos, é possível evitar falhas que afetem os usuários finais e proteger os dados sensíveis. Além disso, os testes proporcionam informações valiosas a equipe de desenvolvimento, economizando tempo e recursos. Ao adotar uma abordagem sistemática de testes, as organizações podem fornecer APIs confiáveis, seguras e eficientes, promovendo a satisfação dos usuários e a integridade do sistema.

### Caso de Teste	= 001 - Cadastro de Usuarios
### Requisitos Associados: RF-001 Cadastro de fornecedores de serviços
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de criação de Usuarios método Post
## Passos:
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2.Swagger URL localhost:7221/swagger/index.html.
3. Acessar Usuarios Cadastrar método Post. Request URL https://localhost:7221/api/Usuarios/cadastrar.
4. clicar em Try it out, observar o Request Body deve esta em application/json.
5. inserir os dados:{"nome": "string","email": "string","senha": "string","tipo": "string""cpf": "string","cep": "string", "telefone": "string","logradouro": "string","numero": "string","bairro": "string","cidade": "string","uf": "string"}.
6. clicar em execute.
7. Critérios de Êxito: Será os atributos preenchidos e o código 200 Success.

### Caso de Teste	= 002 - Fazer login
### Requisitos Associados: RF-002 Fazer login
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de login de fornecedores
método GET{ID}
## Passos:
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2. swagger informar a URL https://localhost/ .
3. Acessar o método GET{ID}.
4. clicar em Try it out, observar o Request Body deve esta em application/json.
5. inserir os dados email*	string($email) senha*	string($password) .
6. clicar em execute.
7. Critérios de Êxito :	
Será os atributos preenchidos e o código 201.


### Caso de Teste	= 003 - Atualizar Cadastro
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
7.Critérios de Êxito :	
Será os atributos preenchidos e o código 201.




