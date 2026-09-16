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

No diretório que contém `Trabalho1.sln`, execute:

```sh
dotnet build Trabalho1.sln
```

## Executar cada questão

```sh
dotnet run --project Questao1Biblioteca
dotnet run --project Questao2Reflection
dotnet run --project Questao3ReservaHotel
```

## Etapa atual

A questão 1 está concluída. Ao executá-la, o console apresenta exemplos dos sete resultados possíveis: aluno autorizado e no limite, professor autorizado e no limite, visitante, usuário não classificado e objeto nulo. Os dados usados são fictícios.

A questão 2 está concluída. Um equipamento com dados fictícios é exibido de duas formas: a Reflection aberta mostra as seis propriedades públicas; a controlada mostra somente `Nome`, `Fabricante`, `Valor` e `Localizacao`, marcadas com `[Exibir]`. `Id` e `NumeroSerie` aparecem apenas na saída aberta.

A questão 3 possui a estrutura inicial e será implementada nos próximos commits.

- [x] Criar a solução e os três projetos Console.
- [x] Implementar e verificar a questão 1.
- [x] Implementar e verificar a questão 2.
- [ ] Implementar e verificar a questão 3.
- [ ] Completar a documentação com exemplos dos resultados.
