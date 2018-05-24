using Laboratorio_3.Classes.Edificios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes
{
    public class Aldea : Componente
    {
        protected Int32 AlmacenOro;
        protected Int32 AlmacenER;
        protected Int32 AlmacenEN;

        private static Aldea Instancia = null;
        public static Aldea GetInstancia(string nombre)
        {
            if (Instancia == null)
            {
                Instancia = new Aldea(nombre);
            }
            return Instancia;
        }

        private Aldea(string nombre)
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
