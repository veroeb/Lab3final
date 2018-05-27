using Laboratorio_3.Classes.Edificios.Recolectores;
using Laboratorio_3.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_3.Classes
{
    public static class ManagerRecursos
    {
        //public Aldea Aldea { get; set; }
        //public Home Home { get; set; }

        //public void NombreAldeaR(string nombreAldea)
        //{
        //    Aldea a = new Aldea();

        //    //Home h = new Home();
        //    //h.NombreAldea(nombreAldea);
        //}

        public static string NombreAldea;

        public static int CantidadOro;
        public static int CantidadElixirRojo;
        public static int CantidadElixirNegro;

        public static void GetRecolectorOro()
        {
            Aldea aldea = Aldea.GetInstancia();

            Home home = new Home();

            foreach (RecolectorOro recolectorOro in aldea.GetProdOro())
            {
                home.AddRecolectorOro(recolectorOro);
            }
        }

    }
}
