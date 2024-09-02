using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios_Guia4._1.Models
{
    public class Aduana:IProcesadorEnvios,ICosto
    {
        public double Valor { get; set; }
        public string Concepto { get; set; }
        public Aduana(double valFijo)
        {
            Valor = valFijo;
           
        }
        public void ProcesarEnvios(IProcesable[] proce)
        {
            Envio envi = null;
            for(int i = 0; i < proce.Length; i++)
            {
                envi = proce[i] as Envio;
                envi.CostoTotal = Valor;
                
            }
            
        }
    }
}
