# Roadmap de Progresso — C# e .NET

**Última atualização:** 30/07/2026
**Ponto atual:** Seção 6, após a aula sobre tipos referência e tipos valor.

## Legenda

- ✅ Concluída no curso
- 🟡 Em andamento
- ⬜ Ainda não iniciada
- 🧠 Compreensão validada com explicação própria
- 🛠️ Prática validada com exercício ou projeto

> As marcações do curso mostram aulas assistidas. A compreensão e a prática serão verificadas separadamente neste repositório.

## Visão geral

| Etapa | Conteúdo | Situação |
|---|---|---|
| Preparação | Ubuntu, .NET, Git e GitHub CLI | ✅ Concluída |
| Seção 2 | Introdução a C# e .NET | ✅ 9/9 |
| Seção 3 | Lógica de programação com C# | ✅ 23/23 |
| Seção 4 | Classes, atributos, métodos e membros estáticos | ✅ 13/13 |
| Seção 5 | Construtores, `this`, sobrecarga e encapsulamento | ✅ 14/14 |
| Seção 6 | Comportamento de memória, arrays e listas | 🟡 4/20 |
| Seções 7–15 | Recursos intermediários e avançados de C# | ⬜ Não iniciadas |
| Seção 16 | Git e GitHub | ⬜ Aulas não iniciadas; prática antecipada |
| Seção 17 | Projeto sistema de jogo de xadrez | ⬜ Não iniciada |
| Seção 18 | Projeto web legado com ASP.NET Core MVC e Entity Framework | ⬜ Não iniciada |
| Seção 19 | Seção bônus mostrada no curso | ⬜ Detalhes a confirmar |

# Fase 1 — Fundamentos

## ✅ Seção 2 — Introdução a C# e .NET

Conteúdos vistos:

- C# e plataforma .NET;
- compilação e interpretação;
- estrutura de uma aplicação C#;
- primeiro programa;
- estrutura básica do código;
- ferramentas de desenvolvimento apresentadas pelo curso.

## ✅ Seção 3 — Lógica de programação com C#

Conteúdos vistos:

- tipos básicos;
- variáveis e convenções de nomes;
- saída e entrada de dados;
- operadores de atribuição;
- conversão implícita e casting;
- operadores aritméticos, comparativos e lógicos;
- estrutura condicional `if/else`;
- escopo e inicialização;
- funções;
- debugging;
- estruturas de repetição `while` e `for`.

# Fase 2 — Orientação a objetos

## ✅ Seção 4 — Classes, atributos, métodos e membros estáticos

Conteúdos vistos:

- resolução de problemas sem orientação a objetos;
- criação de classes;
- objetos e atributos;
- métodos;
- reaproveitamento e delegação;
- `Object` e `ToString`;
- membros estáticos.

## ✅ Seção 5 — Construtores, `this`, sobrecarga e encapsulamento

Conteúdos vistos:

- construtores;
- sobrecarga;
- inicialização alternativa de valores;
- palavra `this`;
- encapsulamento;
- properties e auto properties;
- ordem sugerida dos membros de classe;
- modificadores de acesso.

# Fase 3 — Memória e coleções básicas

## 🟡 Seção 6 — Comportamento de memória, arrays e listas

### Já assistido

- visão geral da seção;
- material de apoio;
- aviso sobre conteúdo antigo;
- tipos referência e tipos valor.

### Próximos conteúdos

- desalocação de memória, garbage collector e escopo local;
- nullable;
- vetores;
- modificadores `params`, `ref` e `out`;
- boxing e unboxing;
- `foreach`;
- `List<T>`;
- matrizes;
- conjuntos.

### Próxima aula oficial

**Desalocação de memória: garbage collector e escopo local.**

# Fase 4 — Recursos especiais da linguagem

## ⬜ Seção 7 — Tópicos especiais em C# — Parte 1

- inferência de tipos com `var`;
- `switch-case`;
- expressão condicional ternária;
- funções para strings;
- `DateTime`;
- `TimeSpan`;
- propriedades e operações com datas e durações;
- padrão ISO 8601.

## ⬜ Seção 8 — Enumerações e composição

- conversão entre string e enumeração;
- enumerações;
- composição de objetos;
- noções de design;
- exercícios de modelagem;
- `StringBuilder`.

## ⬜ Seção 9 — Herança e polimorfismo

- herança;
- upcasting e downcasting;
- sobreposição, `virtual`, `override` e `base`;
- classes e métodos selados;
- polimorfismo;
- classes abstratas;
- métodos abstratos.

# Fase 5 — Robustez, arquivos e contratos

## ⬜ Seção 10 — Tratamento de exceções

- discussão sobre exceções;
- `try-catch`;
- `finally`;
- exceções personalizadas;
- exercícios de tratamento de erros.

## ⬜ Seção 11 — Trabalhando com arquivos

- `File`, `FileInfo` e `IOException`;
- `FileStream` e `StreamReader`;
- bloco `using`;
- `StreamWriter`;
- `Directory` e `DirectoryInfo`;
- `Path`.

## ⬜ Seção 12 — Interfaces

- interfaces e contratos;
- soluções com e sem interface;
- inversão de controle;
- injeção de dependência;
- herança múltipla e problema do diamante;
- `IComparable`.

# Fase 6 — Generics, coleções e programação funcional

## ⬜ Seção 13 — Generics, Set e Dictionary

- generics;
- restrições de generics;
- `GetHashCode` e `Equals`;
- `HashSet` e `SortedSet`;
- igualdade entre coleções e objetos;
- `Dictionary` e `SortedDictionary`.

## ⬜ Seção 14 — Tópicos especiais em C# — Parte 2

- extension methods.

## ⬜ Seção 15 — Expressões lambda, delegates e LINQ

- `Comparison`;
- programação funcional e cálculo lambda;
- delegates e multicast delegates;
- `Predicate`, `Action` e `Func`;
- introdução ao LINQ;
- operações LINQ;
- consultas com sintaxe semelhante a SQL.

# Fase 7 — Versionamento

## ⬜ Seção 16 — Bônus: nivelamento Git e GitHub

O curso apresenta:

- repositório local e remoto;
- instalação e configuração;
- arquivos ocultos e extensões;
- primeiro projeto e primeiro commit;
- `git status`, staging e histórico;
- desfazer modificações;
- `.gitignore`;
- checkout;
- branches e merge;
- conflitos;
- repositórios remotos;
- clone, pull e push;
- colaboração e resolução de conflitos.

### Prática já iniciada fora da ordem do curso

- Git instalado e configurado;
- conta GitHub `dutraeduardo89` autenticada;
- branch `main` criada;
- repositório local `jornada-csharp` iniciado;
- estrutura inicial do portfólio criada.

# Fase 8 — Projeto de portfólio: xadrez

## ⬜ Seção 17 — Projeto sistema de jogo de xadrez

Aplicações previstas:

- classes, objetos, composição e enumerações;
- tabuleiro, posições e peças;
- movimentos possíveis;
- turnos e peças capturadas;
- herança e polimorfismo;
- exceções;
- xeque e xeque-mate;
- roque;
- en passant;
- promoção de peão.

Pasta futura:

```text
projetos/sistema-xadrez/
```

# Fase 9 — Desenvolvimento web com .NET

## ⬜ Seção 18 — Projeto web legado com ASP.NET Core MVC e Entity Framework

Conteúdos visíveis nos prints:

- ASP.NET Core MVC;
- Entity Framework;
- estrutura de projeto MVC;
- controllers e views;
- MySQL;
- migrations;
- seeding;
- operações CRUD;
- formulários;
- relacionamentos entre entidades;
- validação;
- tratamento de exceções;
- buscas simples e agrupadas.

> Esta seção está marcada como legada no curso. Os conceitos serão aproveitados, mas versões e práticas antigas serão comparadas com a abordagem atual antes de entrarem no portfólio.

## ⬜ Seção 19 — Seção bônus

O título aparece nos prints, mas os detalhes internos ainda não estão visíveis. O conteúdo será acrescentado quando novos prints forem enviados.

# Estratégia de portfólio

Para cada assunto relevante serão registrados:

1. resumo com minhas próprias palavras;
2. exemplo criado durante o estudo;
3. exercício de fixação;
4. desafio feito sem copiar a solução;
5. dificuldades e correções;
6. commit específico e descritivo.

## Estrutura planejada

```text
aulas/
exercicios/
projetos/
docs/
```

## Exemplos de commits

```text
docs: registra aprendizado sobre tipos valor e referência
feat: adiciona exercícios de vetores
feat: implementa desafio com listas
fix: corrige validação de entrada do exercício
```

# Próxima ação prática

Assistir à aula sobre **garbage collector e escopo local**, explicar o conceito com palavras próprias e criar um pequeno exemplo antes de avançar para `Nullable`.
