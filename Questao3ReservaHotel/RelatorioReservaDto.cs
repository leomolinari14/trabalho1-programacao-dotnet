namespace Questao3ReservaHotel;

public record RelatorioReservaDto(
    string NomeHospede,
    int NumeroQuarto,
    int QuantidadeDiarias,
    decimal ValorTotal,
    string Situacao);
