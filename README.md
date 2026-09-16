# Trabalho 1 - Programação Aplicada em .NET

Trabalho individual com três aplicações Console em C#.

- Aluno: Leonardo Molinari
- Professor: Prof. Me. Lucas Teodoro dos Santos
- Entrega: 30/09/2026

## Organização

| Projeto | Tema |
| --- | --- |
| `Questao1Biblioteca` | Pattern Matching para verificar empréstimos |
| `Questao2Reflection` | Reflection aberta e controlada por atributo |
| `Questao3ReservaHotel` | Mapeamento de reserva para um DTO de relatório |

O arquivo `Trabalho1.sln` reúne os três projetos. Cada aplicação tem seu próprio `Program.cs`, com uma classe `Program` e um método `Main()` explícitos.

## Requisito

Instalar o SDK do .NET 10. Verifique a instalação com:

```sh
dotnet --version
```

## Compilar

Clone o repositório e entre na pasta:

```sh
git clone https://github.com/leomolinari14/trabalho1-programacao-dotnet.git
cd trabalho1-programacao-dotnet
```

No diretório que contém `Trabalho1.sln`, execute. O comando também restaura as dependências:

```sh
dotnet build Trabalho1.sln
```

## Executar cada questão

```sh
dotnet run --project Questao1Biblioteca
dotnet run --project Questao2Reflection
dotnet run --project Questao3ReservaHotel
```

## Exemplos apresentados

Os dados dos exemplos são fictícios. Cada programa executa a demonstração e encerra automaticamente.

- **Questão 1:** alunos com 2 e 3 empréstimos, professores com 4 e 5, visitante, usuário da classe base e objeto nulo. Por exemplo, o aluno com 2 empréstimos recebe "Empréstimo autorizado para aluno" e o aluno com 3 recebe "Limite de empréstimos atingido para aluno".
- **Questão 2:** a saída aberta mostra as seis propriedades de `Equipamento`; a controlada mostra somente `Nome`, `Fabricante`, `Valor` e `Localizacao`, marcadas com `[Exibir]`. `Id` e `NumeroSerie` aparecem apenas na saída aberta. A apresentação numérica segue a configuração regional do computador.
- **Questão 3:** a reserva de Ana Souza, quarto 203, tem 3 diárias de R$ 250,50. O DTO gera o relatório abaixo, sem expor `Id`, `ValorDiaria`, `StatusInterno` ou `ObservacaoInterna`:

```text
Hóspede: Ana Souza
Quarto: 203
Quantidade de diárias: 3
Valor total: R$ 751,50
Situação: Reserva confirmada
```
