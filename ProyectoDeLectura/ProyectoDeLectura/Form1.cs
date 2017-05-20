using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDeLectura
{
    public partial class Form1 : Form
    {
        List<Actividad> miListaDeActividades = new List<Actividad>();
        Random miRandom = new Random();
        Actividad miActividad = new Actividad();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnOpcion4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void lnklblForma1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormaActividadTipo1 miForma1 = new FormaActividadTipo1();
            this.Visible = false;
            miForma1.Show();
        }

        private void lnkAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
