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
    public partial class LaunchScreen : Form
    {
        public LaunchScreen()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            btnIngresar.ForeColor = Color.Black;
            Hide();
            using (Aldea aldea = new Aldea())
            {
                aldea.ShowDialog();
                Application.Exit();
            }
        }
    }
}
