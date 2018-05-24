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
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void pictureBoxRecursos_Click(object sender, EventArgs e)
        {
            //Hide();
            //using (Recursos recursos = new Recursos())
            //{
            //    recursos.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnRecursos_Click(object sender, EventArgs e)
        {
            Hide();
            using (Recursos recursos = new Recursos())
            {
                recursos.ShowDialog();
                Application.Exit();
            }
        }

        private void btnDefensas_Click(object sender, EventArgs e)
        {
            Hide();
            using (Defensas defensas = new Defensas())
            {
                defensas.ShowDialog();
                Application.Exit();
            }
        }

        private void btnEjercito_Click(object sender, EventArgs e)
        {
            Hide();
            using (Ejercito ejercito = new Ejercito())
            {
                ejercito.ShowDialog();
                Application.Exit();
            }
        }
    }
}
