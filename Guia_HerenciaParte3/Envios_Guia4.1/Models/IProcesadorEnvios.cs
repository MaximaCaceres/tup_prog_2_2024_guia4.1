using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envios_Guia4._1.Models
{
    public interface IProcesadorEnvios
    {
        void ProcesarEnvios(IProcesable[] envios);
        
    }
}
