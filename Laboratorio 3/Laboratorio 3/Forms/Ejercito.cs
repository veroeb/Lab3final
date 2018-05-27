using Laboratorio_3.Classes;
using Laboratorio_3.Classes.Edificios.Almacenamiento.Almacenes;
using Laboratorio_3.Classes.Edificios.Cuarteles;
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
            //using (Home home = new Home())
            //{
            //    home.ShowDialog();
            //    //Application.Exit();
            //}
            Close();
        }

        private void btnCuartelNormal_Click(object sender, EventArgs e)
        {
            Aldea aldea = Aldea.GetInstancia();
            CuartelNoOscuro cuartelNoOscuro = new CuartelNoOscuro();
            aldea.AgregarCuartel(cuartelNoOscuro);
            MessageBox.Show("Ha creado un Cuartel normal");
        }

        private void btnCuartelOscuro_Click(object sender, EventArgs e)
        {
            Aldea aldea = Aldea.GetInstancia();
            CuartelOscuro cuartelOscuro = new CuartelOscuro();
            aldea.AgregarCuartelO(cuartelOscuro);
            MessageBox.Show("Ha creado un Cuartel oscuro");
        }

        private void btnCampamento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha creado un Campamento");

            Aldea aldea = Aldea.GetInstancia();

            Campamento campamento = new Campamento();

            if (aldea.CapacidadCampamento())
            {

                Campamento c = new Campamento();
                aldea.AgregarCampamento(c);
            }
            else
            {
                MessageBox.Show("Capacidad Maxima alcanzada");
                //Mensaje lleno , error.

            }
        }
    }
}
