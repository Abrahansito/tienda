using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPTIENDA.Models
{
    public class Calcular
    {
        string? Operacion { get; set; }
        double  Operador1 { get; set; } 
        double  Operador2 { get; set; }     

    public double Calculo (string Operacion, double Operador1, double Operador2)
    {
        double Resultado = 0;
        switch (Operacion)
        {
            case "Suma":
                Resultado = Operador1 + Operador2;
                break;
            case "Resta":
                Resultado = Operador1 - Operador2;
                break;
            case "Multiplicacion":
                Resultado = Operador1 * Operador2;
                break;
            case "Division":
                if (Operador2==0){
                    throw new DivideByZeroException();
                }
                Resultado = Operador1 / Operador2;
                break;
        }
        return Resultado;
     }

        internal object? Calculo()
        {
            throw new NotImplementedException();
        }
    }
}