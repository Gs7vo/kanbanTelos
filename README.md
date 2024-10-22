# Kanban Telos - Sistema de Gerenciamento de Tarefas

Este repositório contém o código C# para a criação e manipulação de um sistema de gerenciamento de tarefas, **TaskMaster**. O sistema permite organizar tarefas em três estados: **A Fazer**, **Em Progresso** e **Concluído**, além de possibilitar mover tarefas entre essas categorias.

Este projeto foi proposto e desenvolvido com a colaboração do mentor **[Vinícius Penha](https://www.linkedin.com/in/vinicius12)** como parte do **programa Afro Digital da [Télos Conecta](https://www.telosconecta.com)**.

## Funcionalidades do Sistema

- **Adicionar Tarefas**: Permite adicionar novas tarefas à lista \"A Fazer\".
- **Exibir Tarefas**: Exibe as tarefas organizadas em três listas distintas: \"A Fazer\", \"Em Progresso\" e \"Concluído\".
- **Mover Tarefas**: Possibilita mover uma tarefa de uma lista para outra, facilitando o acompanhamento do progresso.
- **Remover Tarefas**: Automaticamente remove tarefas ao serem movidas de uma lista para outra, conforme seu estado evolui.

## Estrutura do Código

O código é dividido em várias funções principais que executam as operações descritas acima:

- **AdicionarTarefa()**: Função responsável por adicionar uma nova tarefa à lista \"A Fazer\".
- **ExibirTarefas()**: Exibe o conteúdo das listas \"A Fazer\", \"Em Progresso\" e \"Concluído\" de maneira organizada.
- **MoverTarefa()**: Realiza a movimentação de tarefas entre as listas, facilitando o controle de progresso.
- **EscolherLista()**: Função auxiliar que seleciona a lista apropriada com base na entrada do usuário.

## Tecnologias Utilizadas

- **C#**: Linguagem principal utilizada para desenvolver o sistema.
- **.NET Core**: Framework para construção da aplicação.

## Como Executar

1. Clone o repositório para sua máquina local.
2. Abra o projeto em uma IDE compatível com C# (Visual Studio recomendado).
3. Compile e execute o programa.
4. Siga as opções do menu para gerenciar suas tarefas.

## Exemplo de Uso

Após executar o programa, o usuário terá as seguintes opções no menu principal:

1. **Adicionar nova tarefa**: Adiciona uma nova tarefa à lista \"A Fazer\".
2. **Exibir tarefas**: Mostra as listas \"A Fazer\", \"Em Progresso\" e \"Concluído\".
3. **Mover tarefa**: Move uma tarefa de uma lista para outra.
4. **Sair**: Encerra o programa.

Exemplo de exibição de tarefas:

\`\`\`
Tarefas 'A Fazer':
1. Estudar C#
2. Finalizar projeto

Tarefas 'Em Progresso':
Nenhuma tarefa nesta lista.

Tarefas 'Concluído':
Nenhuma tarefa nesta lista.
\`\`\`

## Autor

**Gustavo Martins**. Você pode entrar em contato comigo através do [LinkedIn](https://www.linkedin.com/in/gustavo-henrique-martins-1b031929b/)." > README.md

