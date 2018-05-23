using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Tropas.Normales
{
    public class Arquera : TropaNormal
    {
        public Arquera()
        {
            Nombre = "Arquera";
            Nivel = 1;
            Vida = 20;
            Daño = 7;
            Velocidad = 50;
            Espacio = 1;
            ConsumoRojo = 50;
        }
    }
}
