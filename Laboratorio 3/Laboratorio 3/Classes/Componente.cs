using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios
{
    public abstract class Componente
    {
        public String Nombre { get; set; }
        public Int32 Vida { get; set; }
        public Int32 Nivel { get; set; }
    }
}
