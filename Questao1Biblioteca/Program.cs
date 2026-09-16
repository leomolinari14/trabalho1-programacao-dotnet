namespace Questao1Biblioteca;

class Program
{
    public static string VerificarEmprestimo(object? obj)
    {
        return obj switch
        {
            null => "Usuário inválido",
            Aluno { QuantidadeEmprestimosAtivos: < 3 } => "Empréstimo autorizado para aluno",
            Aluno { QuantidadeEmprestimosAtivos: >= 3 } => "Limite de empréstimos atingido para aluno",
            Professor { QuantidadeEmprestimosAtivos: < 5 } => "Empréstimo autorizado para professor",
            Professor { QuantidadeEmprestimosAtivos: >= 5 } => "Limite de empréstimos atingido para professor",
            Visitante => "Visitantes não podem realizar empréstimos",
            _ => "Usuário não classificado"
        };
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Questão 1 - Empréstimos em uma biblioteca");
    }
}
