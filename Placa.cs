using System.Text.RegularExpressions;

namespace OlaMundo;

internal class Placa
{
    public bool ValidarPlaca(string placa)
    {
        // Define o padrão de placa brasileiro válido até 2018
        string padrao = @"^[a-zA-Z]{3}[0-9]{4}$";

        // Verifica se a placa corresponde ao padrão
        return Regex.IsMatch(placa, padrao);
    }
}
