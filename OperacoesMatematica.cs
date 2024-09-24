namespace OlaMundo;

internal class OperacoesMatematica
{
    public (double soma, double subtração, double multiplicacao, double divisao, double media) Adicionar(double valor1, double valor2)
    {

       return (
            soma: valor1 + valor2, 
            subtração: valor1 - valor2,
            multiplicacao: valor1 * valor2, 
            divisao: valor1 / valor2,
            media: ((valor1 + valor2) / 2)
       );
    }
}
