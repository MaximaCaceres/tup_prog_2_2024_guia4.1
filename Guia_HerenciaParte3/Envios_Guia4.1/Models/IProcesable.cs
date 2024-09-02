using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios_Guia4._1.Models
{
    public interface IProcesable
    {
        int CantidadCostos { get; set; }
        double CostoTotal { get; set; }

        ICosto CrearCosto(string concepto, double valor);
        ICosto VerCosto(int idx);
       
    }
}
