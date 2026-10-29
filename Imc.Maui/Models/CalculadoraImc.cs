using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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
                return "Bajo peso";
            }
            if (imc < 25m)
            {
                return "Peso Normal";
            }
            if (imc < 30m)
            {
                return "Sobrepeso";
            }
            if (imc < 40.0m)
            {
                return "Obesidad";
            }
            return "Obesidad extrema";
        }
    }
}