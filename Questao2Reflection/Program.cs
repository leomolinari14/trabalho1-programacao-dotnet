namespace Questao2Reflection;

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

    static void Main(string[] args)
    {
        Console.WriteLine("Questão 2 - Reflection aberta e controlada");
    }
}
