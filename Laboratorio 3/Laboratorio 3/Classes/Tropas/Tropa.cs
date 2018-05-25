using Laboratorio_3.Classes.Edificios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas
{
    public abstract class Tropa:Componente
    {
        protected String Nombre { get; set; }
        protected int Espacio { get; set; }
        protected int Velocidad { get; set; }
        protected int Daño { get; set; }
        protected Int32 Nivel;
    }
}
