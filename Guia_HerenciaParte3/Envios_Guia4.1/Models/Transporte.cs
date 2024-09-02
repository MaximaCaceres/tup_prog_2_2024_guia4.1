using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios_Guia4._1.Models
{
    public class Transporte:IProcesadorEnvios,ICosto
    {
        public string Concepto { get; set; }
        public double DistanciaKM { get; private set; }
        public double PrecioXKM { get; private set; }
        public double Valor
        {
            get
            {
                double total = DistanciaKM * PrecioXKM;
                return total;
            }
            set
            {

            }
        }
      public Transporte(double distanciaKM, double precioXkm)
        {
            DistanciaKM = distanciaKM;
            PrecioXKM = precioXkm;
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
