using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envios_Guia4._1.Models
{
    public class Envio:IProcesable,IComparable
    {
        ArrayList icostos = new ArrayList();
        public int NumeroAduanero { get; private set; }
        public int CantidadCostos { get; set; }
        public double CostoTotal { get; set; }

        public Envio(int numAduanero)
        {
            NumeroAduanero = numAduanero;
        }
        public ICosto VerCosto(int idx)
        {
            ICosto ret = null;
            for(int m = 0; m<icostos.Count;m++)
            {
                if (m == idx)
                {
                    ret = icostos[m] as ICosto;
                }                 
            }
            return ret;
        }
        public ICosto CrearCosto(string concepto, double valor)
        {
            Costo costo = new Costo(concepto,valor);
            icostos.Add(costo);
            return costo;
        }
        public int CompareTo(object obj)
        {
            Envio envio = obj as Envio;//veo que el objeto sea un envio.
            if (envio != null)
                return NumeroAduanero.CompareTo(envio.NumeroAduanero);
            return 1;
        }
        public override string ToString()
        {
            string date = $"Envio:{NumeroAduanero}";
            return date;
        }
    }
}
