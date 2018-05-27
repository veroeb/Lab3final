using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Recolectores
{
    public class RecolectorOro : EdificioRecolector
    {
        public string NombreRecolectorOro { get; set; }
        public RecolectorOro()
        {
            Nombre = "Recolector Oro";
            ProduccionPorSegundo = 50;
        }
    }
}
