using OlaMundo.estudos;

namespace OlaMundo;

class Program
{
    static void Main()
    {
        var nome = new CapturarNome();
        nome.getNome();

        var fullName = new NomeSobrenome();
        fullName.getSobrenome();

        var operacao = new OperacoesMatematica();
        var result = operacao.Adicionar(2.3, 4.4);
        Console.WriteLine("Operacao: ", result);

        var getPalavra = Console.ReadLine();
        if(getPalavra.Length > 0)
        {
            Console.WriteLine($"Retornando a palavra {getPalavra}.");
        }

        Console.WriteLine("Digite a placa do veículo:");
        string placa = Console.ReadLine();

        var valida = new Placa();

        if (valida.ValidarPlaca(placa))
        {
            Console.WriteLine("Verdadeiro");
        }
        else
        {
            Console.WriteLine("Falso");
        }
    }
}
