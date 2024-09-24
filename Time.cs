using System.Globalization;

namespace OlaMundo;

internal class Time
{
    public void Tempos()
    {
        DateTime dataHoraAtual = DateTime.Now;

        DateTime ontem = dataHoraAtual.AddDays(-1);
        string tempoFormatado = dataHoraAtual.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("pt-BR"));

        Console.WriteLine(tempoFormatado);
        Console.WriteLine(ontem);
    }
}
