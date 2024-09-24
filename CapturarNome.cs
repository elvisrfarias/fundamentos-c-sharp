namespace OlaMundo;

internal class CapturarNome
{
    public void getNome()
    {
        var nome = Console.ReadLine();

        Console.WriteLine("\nAtividade 01");
        Console.WriteLine($"Olá {nome}! Seja muito bem-vindo!");
    }
}
