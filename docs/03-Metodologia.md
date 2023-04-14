
# Metodologia

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Documentação de Especificação</a></span>

A metodologia de desenvolvimento utilizada é o Scrum, uma metodologia ágil utilizada no desenvolvimento de Software baseada em processos interativos e incrementais. A equipe adaptou o Scrum levando em consideração as necessidades do projeto e a disponibilidade dos membros. A equipe se comunicou por meio de mensagens no WhatsApp, grupo do projeto e reuniões no Teams para tomadas de decisões.

## Relação de Ambientes de Trabalho

Os artefatos do projeto são desenvolvidos a partir de diversas plataformas e a relação dos ambientes com seu respectivo propósito deverá ser apresentada em uma tabela que especifica e detalha Ambiente, Plataforma e Link de Acesso. 
Nota: Vide documento modelo do estudo de caso "Portal de Notícias" e defina também os ambientes e frameworks que serão utilizados no desenvolvimento de aplicações móveis.

|Ambiente| Plataforma  |Link de Acesso |
|--------------------|------------------------------------|----------------------------------------|
|Repositório de código fonte |GitHub|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-pmv-ads-2023-1-e4-proj-apdist-t4-serv|
|Documentos do projeto |GitHubDocs|https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e4-proj-apdist-t4-pmv-ads-2023-1-e4-proj-apdist-t4-serv|
|Projeto de Interface e Wireframes |figma|https://www.figma.com/file/DjwRKORYkt48l6M7zlk4Jc/Contrata%C3%A7%C3%A3o-Servi%C3%A7os?node-id=0-1&t=6wZljybC6DF3Rdhj-0|
|Gerenciamento do Projeto |Trello|https://trello.com/invite/b/fMFbID35/ATTI5a8774f22ea481ac336a1c445efa5472B88E6BE0/bh-contratacao-de-servicos-4-periodo|

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

Discuta como a configuração do projeto foi feita na ferramenta de versionamento escolhida. Exponha como a gerência de tags, merges, commits e branchs é realizada. Discuta como a gerência de issues foi realizada.

> **Links Úteis**:
> - [Microfundamento: Gerência de Configuração](https://pucminas.instructure.com/courses/87878/)
> - [Tutorial GitHub](https://guides.github.com/activities/hello-world/)
> - [Git e Github](https://www.youtube.com/playlist?list=PLHz_AreHm4dm7ZULPAmadvNhH6vk9oNZA)
>  - [Comparando fluxos de trabalho](https://www.atlassian.com/br/git/tutorials/comparing-workflows)
> - [Understanding the GitHub flow](https://guides.github.com/introduction/flow/)
> - [The gitflow workflow - in less than 5 mins](https://www.youtube.com/watch?v=1SXpE08hvGs)

## Gerenciamento de Projeto

### Divisão de Papéis

Apresente a divisão de papéis entre os membros do grupo.

Exemplificação: A equipe utiliza metodologias ágeis, tendo escolhido o Scrum como base para definição do processo de desenvolvimento. A equipe está organizada da seguinte maneira:
- Scrum Master: Ruver Caldeira;
- Product Owner: Mário Fernandes;
- Equipe de Desenvolvimento: Marcelo Farias, Moisés Silva e Mario Fernandes;
- Equipe de Design: Márcia Ferreira e Ruver Caldeira.

> **Links Úteis**:
> - [11 Passos Essenciais para Implantar Scrum no seu Projeto](https://mindmaster.com.br/scrum-11-passos/)
> - [Scrum em 9 minutos](https://www.youtube.com/watch?v=XfvQWnRgxG0)
> - [Os papéis do Scrum e a verdade sobre cargos nessa técnica](https://www.atlassian.com/br/agile/scrum/roles)

### Processo

<p align="justify">Para organização e distribuição das tarefas do projeto, a equipe está utilizando o Trello estruturado com as seguintes listas:</p>

<p align="justify">
● <b>Backlog</b>: Essa lista é onde as tarefas de projetos são alocadas em cartões individuais. 

● <b>A Fazer</b>: Uma vez que a tarefa foi completamente aprofundada, ela é movida a essa lista para mostrar à equipe que a tarefa já está pronta para ser executada. A essa altura, um membro da equipe é designado para ser o dono da tarefa e as datas de entrega são estabelecidas.

● <b>Em andamento</b>: à medida que o time começa a trabalhar nas tarefas, os cartões são movidos para essa lista. Rapidamente, todo o time pode ver as tarefas atuais de cada membro. Os cartões do Trello também permitem que os times conversem e façam perguntas uns aos outros sobre uma certa tarefa com a funcionalidade de comentários. 

● <b>Revisão</b>:  Quando a tarefa está quase concluída, é o momento de movê-la para esta lista para que seja revisada ou que alguém dê uma segunda olhada. 

● <b>Teste</b>:  Apos a revisão, a tarefa é movida para a fila de teste, onde será realizados os devidos testes para saber se a tarefa atende os requisitos.

● <b>Concluído</b>: Quando a tarefa tiver sido revisada, testada e aprovada, ela é movida para fila de concluído.</p>


<p align="justify">O quadro kanban utilizado pelo grupo está disponível no Trello e pode ser acessado através da URL https://trello.com/invite/b/fMFbID35/ATTI5a8774f22ea481ac336a1c445efa5472B88E6BE0/bh-contratacao-de-servicos-4-periodo </p>

### Ferramentas

As ferramentas empregadas no projeto são:

- Editor de código.
- Ferramentas de comunicação
- Ferramentas de desenho de tela (_wireframing_)

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão. As ferramentas de comunicação utilizadas possuem integração semelhante e por isso foram selecionadas. Por fim, para criar diagramas utilizamos essa ferramenta por melhor captar as necessidades da nossa solução.

Liste quais ferramentas foram empregadas no desenvolvimento do projeto, justificando a escolha delas, sempre que possível.
 
> **Possíveis Ferramentas que auxiliarão no gerenciamento**: 
> - [Slack](https://slack.com/)
> - [Github](https://github.com/)
