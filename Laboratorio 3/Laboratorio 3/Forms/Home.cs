using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Edificios.Recolectores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_3.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            Aldea aldea = Aldea.GetInstancia();
            aldea.Ayu = new Ayuntamiento();

            almacenRojo.Hide();
            almacenNegro.Hide();
            almacenOro.Hide();
            recolectorRojo.Hide();
            recolectorNegro.Hide();
            recolectorOro.Hide();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
        }

        private void btnShop_Click_1(object sender, EventArgs e)
        {
            using (Shop shop = new Shop())
            {
                shop.ShowDialog();

                Aldea a = Aldea.GetInstancia();

                if (a.GetAlmacenOro().Count > 0)
                {
                    almacenOro.Show();
                }
                else
                {
                    almacenOro.Hide();
                }
                if (a.GetProdOro().Count > 0)
                {
                    recolectorOro.Show();
                }
                else
                {
                    recolectorOro.Hide();
                }

                Aldea.GetInstancia().MostrarOro();
                lblOro.Text = Convert.ToString(ManagerRecursos.CantidadOro);

                if (a.GetAlmacenRojo().Count > 0)
                {
                    almacenRojo.Show();
                }
                else
                {
                    almacenRojo.Hide();
                }
                if (a.GetElixirRojo().Count > 0)
                {
                    recolectorRojo.Show();
                }
                else
                {
                    recolectorRojo.Hide();
                }

                Aldea.GetInstancia().MostrarRojo();
                lblElixirRojo.Text = Convert.ToString(ManagerRecursos.CantidadElixirRojo);

                if (a.GetAlmacenNegro().Count > 0)
                {
                    almacenNegro.Show();
                }
                else
                {
                    almacenNegro.Hide();
                }
                if (a.GetElixirNegro().Count > 0)
                {
                    recolectorNegro.Show();
                }
                else
                {
                    recolectorNegro.Hide();
                }

                Aldea.GetInstancia().MostrarNegro();
                lblElixirNegro.Text = Convert.ToString(ManagerRecursos.CantidadElixirNegro);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Aldea aldea = Aldea.GetInstancia();
            Ayuntamiento ayuntamiento = new Ayuntamiento();
            Castillo castillo = new Castillo();
            lblAldea.Text = ManagerRecursos.NombreAldea;
            lblOro.Text = ManagerRecursos.CantidadOro.ToString();
            lblElixirRojo.Text = ManagerRecursos.CantidadElixirRojo.ToString();
            lblElixirNegro.Text = ManagerRecursos.CantidadElixirNegro.ToString();
        }

        private void lbRecolectores_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        public void AddRecolectorOro(RecolectorOro recolectorOro)
        {
            lbRecolectores.Items.Add(recolectorOro.Nombre);
        }
    }
}
