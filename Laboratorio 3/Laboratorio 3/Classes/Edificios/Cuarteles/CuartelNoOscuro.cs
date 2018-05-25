using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Tropas;
using Laboratorio_3.Classes.Tropas.Normales;
using Laboratorio_3.Classes.Tropas.Oscuras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes.Edificios.Cuarteles
{
    public class CuartelNoOscuro : Cuarteles
    {
        public override Tropa GenerarTropa(String nombreTropa)
        {
            switch (nombreTropa) {
                case "arquera": return new Arquera();
                case "barbaro": return new Barbaro();
                case "bebe dragon":return new BebeDragon();
                case "curandera": return new Curandera();
                case "ragon": return new Dragon();
                case "Esbirro": return new Esbirro();
                case "Bruja": return new Bruja();

                default: return null;
            }
           
        }
        
    }
}
