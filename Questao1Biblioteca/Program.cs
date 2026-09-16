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

        Aluno alunoAutorizado = new Aluno
        {
            Nome = "Ana Souza",
            Matricula = "A001",
            QuantidadeEmprestimosAtivos = 2
        };

        Aluno alunoNoLimite = new Aluno
        {
            Nome = "Bruno Lima",
            Matricula = "A002",
            QuantidadeEmprestimosAtivos = 3
        };

        Professor professorAutorizado = new Professor
        {
            Nome = "Carlos Silva",
            Departamento = "Tecnologia da Informação",
            QuantidadeEmprestimosAtivos = 4
        };

        Professor professorNoLimite = new Professor
        {
            Nome = "Daniela Costa",
            Departamento = "Matemática",
            QuantidadeEmprestimosAtivos = 5
        };

        Visitante visitante = new Visitante
        {
            Nome = "Eduardo Santos",
            Documento = "DOC-EXEMPLO-001",
            QuantidadeEmprestimosAtivos = 0
        };

        UsuarioBiblioteca usuarioNaoClassificado = new UsuarioBiblioteca
        {
            Nome = "Fernanda Oliveira",
            QuantidadeEmprestimosAtivos = 0
        };

        Console.WriteLine();
        Console.WriteLine($"{alunoAutorizado.Nome} (aluno, 2 empréstimos): {VerificarEmprestimo(alunoAutorizado)}");
        Console.WriteLine($"{alunoNoLimite.Nome} (aluno, 3 empréstimos): {VerificarEmprestimo(alunoNoLimite)}");
        Console.WriteLine($"{professorAutorizado.Nome} (professor, 4 empréstimos): {VerificarEmprestimo(professorAutorizado)}");
        Console.WriteLine($"{professorNoLimite.Nome} (professor, 5 empréstimos): {VerificarEmprestimo(professorNoLimite)}");
        Console.WriteLine($"{visitante.Nome} (visitante): {VerificarEmprestimo(visitante)}");
        Console.WriteLine($"{usuarioNaoClassificado.Nome} (usuário da classe base): {VerificarEmprestimo(usuarioNaoClassificado)}");
        Console.WriteLine($"Objeto nulo: {VerificarEmprestimo(null)}");
    }
}
