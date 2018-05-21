using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios
{
    public abstract class Edificio : Aldea
    {
        protected int Vida { get; set; }
        protected int CantidadEdificios { get; set; }
    }
}
