using System;
using System.Collections.Generic;
using System.Text;

namespace Imc.Maui.Models
{
    public class CalculadoraImc
    {
        public static decimal IndiceDeMasaCorporal(decimal peso, decimal altura)
        {
            return peso / (altura * altura);
        }
        public static string EstadoNutricional(decimal imc)
        {
            if (imc < 18.5m)
            {
                return "Peso bajo";

            }
            if (imc < 25m)
            {
                return "Peso normal";

            }
            if (imc < 30m)
            {
                return "sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obecidad";
            }
            return "Obesidad extrema";
        }

    }
}
    