using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPTIENDA.Models
{
    public class Calcular
    {
        public string? Operacion { get; set; }
        public double  Operador1 { get; set; } 
        public double  Operador2 { get; set; }     

    public double Calculo()
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

    }
}