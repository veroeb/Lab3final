using Laboratorio_3.Classes.Edificios.Defensivos.Aereos;
using Laboratorio_3.Classes.Edificios.Defensivos.Hibridos;
using Laboratorio_3.Classes.Edificios.Defensivos.Terrestres;
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
    public partial class Defensas : Form
    {
        public Defensas()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            //using (Home home = new Home(nombreAldea))
            //{
            //    Home.ShowDialog();
            //    Application.Exit();
            //}
        }

        private void btnAguila_Click(object sender, EventArgs e)
        {
            Aguila aguila = new Aguila();
        }

        private void btnBallesta_Click(object sender, EventArgs e)
        {
            Ballesta ballesta = new Ballesta();
        }

        private void btnArqueras_Click(object sender, EventArgs e)
        {
            TorreArqueras torreArqueras = new TorreArqueras();
        }

        private void btnInfierno_Click(object sender, EventArgs e)
        {
            TorreInfierno torreInfierno = new TorreInfierno();
        }

        private void btnMagos_Click(object sender, EventArgs e)
        {
            TorreMagos torreMagos = new TorreMagos();
        }

        private void btnTesla_Click(object sender, EventArgs e)
        {
            TorreTesla torreTesla = new TorreTesla();
        }

        private void btnAntiaereo_Click(object sender, EventArgs e)
        {
            Antiaereo antiaereo = new Antiaereo();
        }

        private void btnCañon_Click(object sender, EventArgs e)
        {
            Cañon cañon = new Cañon();
        }

        private void btnMortero_Click(object sender, EventArgs e)
        {
            Mortero mortero = new Mortero();
        }

        private void btnMuro_Click(object sender, EventArgs e)
        {
            Muro muro = new Muro();
        }
    }
}
