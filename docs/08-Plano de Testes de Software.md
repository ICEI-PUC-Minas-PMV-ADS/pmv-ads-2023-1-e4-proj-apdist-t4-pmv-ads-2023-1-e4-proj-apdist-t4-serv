# Plano de Testes de Software (API)
### Caso de Teste	= CT -001 - Cadastro de fornecedores de serviços
### Requisitos Associados: RF-001 Cadastro de fornecedores de serviços
### Objetivo do Teste	Avaliar:
Avaliar funcionalidade de criação de fornecedores
método Post
## Passos:
1. Abrir o projeto no  Visual estúdio e Iniciar Depuração.
2.swagger informar a URL https://localhost/ .
3. Acessar o método Post.
4. clicar em Try it out, observar o Request Body deve esta em application/json.
5. inserir os dados escolhendo primeiro se e usuário cliente ou fornecedor nome, cpf, telefone, e-mail, senha, repetir senha, Cep, logradouro, numero, complemento, bairro cidade, uf.
6. clicar em execute.
### Critérios de Êxito :	
Será os atributos preenchidos e o código 201.

### Caso de Teste	= CT -002 - Fazer login
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
### Critérios de Êxito :	
Será os atributos preenchidos e o código 201.


### Caso de Teste	= CT -003 - Atualizar Cadastro
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
### Critérios de Êxito :	
Será os atributos preenchidos e o código 201.




