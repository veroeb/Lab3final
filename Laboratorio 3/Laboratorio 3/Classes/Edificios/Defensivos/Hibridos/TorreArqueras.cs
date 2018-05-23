using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Defensivos.Hibridos
{
    public class TorreArqueras : EdificioDefensivoHibrido
    {
        public TorreArqueras()
        {
            Nombre = "Torre de arqueras";
            Nivel = 1;
            Vida = 280;
            ConsumoOro = 1000;
            CantidadEdificios = 2;
        }
    }
}
