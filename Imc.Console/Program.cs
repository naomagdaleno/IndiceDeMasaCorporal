using Imc.Maui.Models;

Console.WriteLine("Aplicacion que calcula el indice de masa corporal de una persona ");
Console.WriteLine();

decimal peso = ReadDecimal("proporcione el peso en kilogramoas de la persona");
decimal estatura = ReadDecimal("proporcione la estatura de la persona en metros");

string entrada;
bool entradaEsValida;

decimal imc = CalculadoraImc.IndiceDeMasaCorporal(peso, estatura);
var estadoNutricional = CalculadoraImc.EstadoNutricional(imc);

Console.WriteLine($"el indice de masa corporal de la persona es {imc:F4}");
Console.WriteLine($"El estado nutricional de la persona es {estadoNutricional}");

static decimal ReadDecimal(string indicacion)
{
    decimal valor;
    string entrada;
    bool entradaEsValida;
    do
    {
        Console.Write(indicacion);
        entrada = Console.ReadLine();
        entradaEsValida = decimal.TryParse(entrada, out valor);
        if (entradaEsValida)
        {
            Console.WriteLine("Eroro: la entrada debe ser numerica");

        }
    } while (entradaEsValida);
     return valor;

}

