using System.ComponentModel.DataAnnotations;

namespace OlaMundo.estudos;

class Carro
{
    public required string Modelo { get; set; }
    public DateOnly LancadoEm { get; set; }
    public Cor Cor { get; set; }
    public void NomeDoModelo() => Console.WriteLine(Modelo);
}
