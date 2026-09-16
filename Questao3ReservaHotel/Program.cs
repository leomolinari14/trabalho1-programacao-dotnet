namespace Questao3ReservaHotel;

using System.Globalization;

class Program
{
    public static RelatorioReservaDto Mapear(Reserva reserva)
    {
        return new RelatorioReservaDto(
            reserva.NomeHospede,
            reserva.NumeroQuarto,
            reserva.QuantidadeDiarias,
            reserva.QuantidadeDiarias * reserva.ValorDiaria,
            "Reserva confirmada");
    }

    public static void ExibirRelatorio(RelatorioReservaDto relatorio)
    {
        Console.WriteLine($"Hóspede: {relatorio.NomeHospede}");
        Console.WriteLine($"Quarto: {relatorio.NumeroQuarto}");
        Console.WriteLine($"Quantidade de diárias: {relatorio.QuantidadeDiarias}");
        Console.WriteLine($"Valor total: {relatorio.ValorTotal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"))}");
        Console.WriteLine($"Situação: {relatorio.Situacao}");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Questão 3 - Relatório de reserva de hotel");

        Reserva reserva = new Reserva
        {
            Id = 1,
            NomeHospede = "Ana Souza",
            NumeroQuarto = 203,
            QuantidadeDiarias = 3,
            ValorDiaria = 250.50m,
            StatusInterno = "CONFIRMADA",
            ObservacaoInterna = "Preparar o quarto antes da chegada."
        };

        RelatorioReservaDto relatorio = Mapear(reserva);

        Console.WriteLine();
        ExibirRelatorio(relatorio);
    }
}
