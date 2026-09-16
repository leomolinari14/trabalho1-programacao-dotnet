namespace Questao3ReservaHotel;

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

    static void Main(string[] args)
    {
        Console.WriteLine("Questão 3 - Relatório de reserva de hotel");
    }
}
