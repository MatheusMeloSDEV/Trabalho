using System.Globalization;

public class DataHelper
{
    public static string CalcularVencimento(string dataString, int dias)
    {
        try
        {
            // Converter a string para DateTime
            DateTime data = DateTime.ParseExact(dataString, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            // Adicionar os dias
            DateTime vencimento = data.AddDays(dias);

            // Retornar a nova data no mesmo formato
            return vencimento.ToString("dd/MM/yyyy");
        }
        catch (FormatException)
        {
            throw new ArgumentException("O formato da data fornecida é inválido. Use o formato dd/MM/yyyy.");
        }
    }
}