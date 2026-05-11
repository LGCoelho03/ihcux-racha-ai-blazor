# ihcux-racha-ai-blazor

Projeto desenvolvido em Blazor para a disciplina de Interação Humano Computador e UX.

---

## Implementação Blazor

A interface foi estruturada com base na hierarquia visual criada no Miro.

A página Dashboard.razor foi dividida em três partes principais:

- Cards de resumo financeiro
- Lista de grupos
- Botão de ação rápida (FAB)

Para melhorar a reutilização e organização do código, cada grupo foi transformado em um componente reutilizável chamado GrupoCard.razor.

O sistema de Grid do Bootstrap foi utilizado para garantir responsividade e melhor organização visual.

---

## Dificuldade Técnica

O maior desafio foi componentizar o GrupoCard.

Foi necessário entender como enviar dados entre componentes usando parâmetros ([Parameter]) e também aplicar renderização dinâmica de cores utilizando condições no Razor.

Além disso, houve cuidado especial na aplicação de UX visual utilizando Bootstrap, hover effects e feedback visual com cores de status.

---

## Funcionalidades

- Dashboard financeiro
- Cards de resumo
- Lista dinâmica de grupos
- Campo de busca em tempo real
- Botão flutuante de ação
- Responsividade com Bootstrap

---

## Tecnologias Utilizadas

- Blazor
- C#
- Bootstrap
- Razor Components
