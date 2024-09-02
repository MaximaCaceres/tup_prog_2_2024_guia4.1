using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios_Guia4._1.Models
{
    public class Costo:ICosto
    {
        public string Concepto { get; set; }
        public double Valor { get; set; }
        public Costo(string concepto,double valor)
        {
            Concepto = concepto;
            Valor = valor;
        }
        public override string ToString()
        {
            string detalle = $"{Concepto}| |{Valor:f2}";
            return detalle;
        }
    }
}
