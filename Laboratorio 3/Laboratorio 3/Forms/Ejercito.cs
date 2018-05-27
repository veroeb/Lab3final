using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
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
    public partial class Ejercito : Form
    {
        public Ejercito()
        {
            InitializeComponent();

            Aldea aldea = Aldea.GetInstancia();

            aldea.Ayu = new Ayuntamiento();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //Hide();
            using (Home home = new Home())
            {
                home.ShowDialog();
                //Application.Exit();
            }
        }
    }
}
