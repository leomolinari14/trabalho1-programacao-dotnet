namespace Questao2Reflection;

using System.Reflection;

class Program
{
    public static void ExibirDadosAberto(object objeto)
    {
        Type tipo = objeto.GetType();

        foreach (var propriedade in tipo.GetProperties())
        {
            Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(objeto)}");
        }
    }

    public static void ExibirDadosControlado(object objeto)
    {
        Type tipo = objeto.GetType();

        foreach (var propriedade in tipo.GetProperties())
        {
            if (propriedade.GetCustomAttribute<ExibirAttribute>() != null)
            {
                Console.WriteLine($"{propriedade.Name}: {propriedade.GetValue(objeto)}");
            }
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Questão 2 - Reflection aberta e controlada");

        Equipamento equipamento = new Equipamento
        {
            Id = 1,
            Nome = "Notebook",
            Fabricante = "Fabricante Exemplo",
            NumeroSerie = "SERIE-EXEMPLO-001",
            Valor = 3500.50m,
            Localizacao = "Laboratório de Informática"
        };

        Console.WriteLine();
        Console.WriteLine("Reflection aberta:");
        ExibirDadosAberto(equipamento);

        Console.WriteLine();
        Console.WriteLine("Reflection controlada:");
        ExibirDadosControlado(equipamento);
    }
}
