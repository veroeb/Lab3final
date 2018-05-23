using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Aereos
{
    public class Antiaereo : EdificioDefensivoAereo
    {
        protected int ConsumoOro { get; set; }
        public Antiaereo()
        {
            Nombre = "Antiaéreo";
            Vida = 470;
            Nivel = 1;
            ConsumoOro = 22500;
            CantidadEdificios = 1;
        }
    }
}
