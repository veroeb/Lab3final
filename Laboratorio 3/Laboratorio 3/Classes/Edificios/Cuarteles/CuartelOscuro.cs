using Laboratorio_3.Classes.Tropas;
using Laboratorio_3.Classes.Tropas.Oscuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Cuarteles
{
    public class CuartelOscuro : Cuarteles
    {
        public override Tropa GenerarTropa(String nombreTropa)
        {
            switch (nombreTropa)
            {
                case "valkiria": return new Valkiria();
                case "Lava": return new Lava();
                case "Lanzaroca": return new LanzaRocas();
                case "Golem": return new Golem();
                case "Montapuerco": return new Montapuerco();
                case "Esbirro": return new Esbirro();
                case "Bruja": return new Bruja();

                default: return null;
            }
        }
    }
}
