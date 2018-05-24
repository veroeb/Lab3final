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
        public Home(string nombreAldea)
        {
            InitializeComponent();
            lblAldea.Text = nombreAldea;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            //Hide();
            //using (Shop shop = new Shop())
            //{
            //    shop.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnShop_Click_1(object sender, EventArgs e)
        {
            Hide();
            using (Shop shop = new Shop())
            {
                shop.ShowDialog();
                Application.Exit();
            }
        }
    }
}
