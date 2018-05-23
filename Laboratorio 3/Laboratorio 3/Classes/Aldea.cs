using Laboratorio_3.Classes.Edificios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes
{
    class Aldea : Componente
    {
        protected string Nombre { get; set; }
        protected int Nivel;
        protected int Vida;
        protected Int32 AlmacenOro;
        protected Int32 AlmacenER;
        protected Int32 AlmacenEN;

        public Aldea(String nombre)
        {
            Nombre = nombre;
            Nivel = 1;
            Vida = 500;
            AlmacenOro = 1000;
            AlmacenER = 2000;
            AlmacenEN = 500;
        }
    }
}
