using Laboratorio_3.Classes.Edificios.Almacenamiento;
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
    public partial class Recursos : Form
    {
        public Recursos()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Home home = new Home(nombreAldea);
            //home.Show();
            //if(ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new Home(Aldea.lbl));
            //    Hide();
            //}
            //using (Home home = new Home(nombreAldea))
            //{
            //    Home.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnRecolectorOro_Click(object sender, EventArgs e)
        {
            RecolectorOro recolectorOro = new RecolectorOro();
        }

        private void btnAlmOro_Click(object sender, EventArgs e)
        {
            AlmacenOro almacenOro = new AlmacenOro();
        }

        private void btnRecElixirRojo_Click(object sender, EventArgs e)
        {
            RecolectorElixirRojo recolectorElixirRojo = new RecolectorElixirRojo();
        }

        private void btnAlmElixirRojo_Click(object sender, EventArgs e)
        {
            AlmacenElixirRojo almacenElixirRojo = new AlmacenElixirRojo();
        }

        private void btnRecElixirNegro_Click(object sender, EventArgs e)
        {
            RecolectorElixirNegro recolectorElixirNegro = new RecolectorElixirNegro();
        }

        private void btnAlmElixirNegro_Click(object sender, EventArgs e)
        {
            AlmacenElixirNegro almacenElixirNegro = new AlmacenElixirNegro();
        }

        private void btnCampamento_Click(object sender, EventArgs e)
        {
            Campamento campamento = new Campamento();
        }
    }
}
