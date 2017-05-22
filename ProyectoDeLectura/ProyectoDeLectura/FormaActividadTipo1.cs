using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace ProyectoDeLectura
{
    public partial class FormaActividadTipo1 : MaterialForm
    {
        List<Actividad> miListaDeActividades1 = new List<Actividad>();
        List<Actividad> miListaDeActividades1Hechas = new List<Actividad>();
        Random miRandom = new Random();
        Actividad miActividad = new Actividad();
        Actividad miActividad2 = new Actividad();
        private bool boolExiste=false;
        private bool bolListaLlena = false;
        private bool bolModificado = false;

        public FormaActividadTipo1()
        {
            InitializeComponent();
            miActividad.Opcion1 = "Perrito";
            miActividad.Opcion2 = "Gatito";
            miActividad.Opcion3 = "Tortuguita";
            miActividad.Opcion4 = "Pesesito";
            miActividad.Pregunta = "¿Cual es el nombre del animal que se muestra en la imagen?";
            picboxImagen.ImageLocation = @"C:\Proyecto-Lectura\ProyectoDeLectura\Images\Alimentos\Manzana.jpg";
            miActividad.Respuesta = 1;
            miActividad.NumeroDeActividad = 1;
            miListaDeActividades1.Add(miActividad);
            btnOpcion1.Text = miActividad.Opcion1;
            btnOpcion2.Text = miActividad.Opcion2;
            btnOpcion3.Text = miActividad.Opcion3;
            btnOpcion4.Text = miActividad.Opcion4;
//          lblPregunta.Text = miActividad.Pregunta;
            this.Text = miActividad.Pregunta;
            miActividad2.Opcion1 = "P";
            miActividad2.Opcion2 = "G";
            miActividad2.Opcion3 = "T";
            miActividad2.Opcion4 = "P";
            miActividad2.Pregunta = "";
            miActividad2.Respuesta = 1;
            miActividad2.NumeroDeActividad = 2;
            miListaDeActividades1.Add(miActividad2);
            miListaDeActividades1Hechas.Add(miActividad);
            
        }

        private void btnOpcion4_Click(object sender, EventArgs e)
        {
            int intValorDelBoton = 4;
            if (intValorDelBoton == miActividad.Respuesta)
            {
                MessageBox.Show("Respuesta Correcta");
                ComenzarOtraActividad();
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 miMenu = new Form1();
            miMenu.Show();
            this.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormaActividadTipo1 miForma1 = new FormaActividadTipo1();
            miForma1.Show();
        }

        private void btnOpcion1_Click_1(object sender, EventArgs e)
        {
            int intValorDelBoton = 1;
            if (intValorDelBoton == miActividad.Respuesta)
            {
                MessageBox.Show("Respuesta Correcta");
                ComenzarOtraActividad();
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
            }
        }

        private void btnOpcion2_Click_1(object sender, EventArgs e)
        {
            int intValorDelBoton = 2;
            if (intValorDelBoton == miActividad.Respuesta)
            {
                MessageBox.Show("Respuesta Correcta");
                ComenzarOtraActividad();
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
            }
        }

        private void btnOpcion3_Click_1(object sender, EventArgs e)
        {
            int intValorDelBoton = 3;
            if (intValorDelBoton == miActividad.Respuesta)
            {
                MessageBox.Show("Respuesta Correcta");
                ComenzarOtraActividad();
            }
            else
            {
                MessageBox.Show("Respuesta Incorrecta");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        public void ComenzarOtraActividad()
        {
            do
            {
                int intActividad = miRandom.Next(0, 3), intCantidadDeActividades = 0, intCantidadDeActividadesHechas = 0;

                foreach (Actividad miActividad in miListaDeActividades1Hechas)
                {
                    if (miActividad.NumeroDeActividad == intActividad)
                    {
                        boolExiste = true;
                    }
                }
                if (boolExiste != true)
                {
                    foreach (Actividad miActividad in miListaDeActividades1)
                    {
                        if (miActividad.NumeroDeActividad == intActividad)
                        {
                            btnOpcion1.Text = miActividad.Opcion1;
                            btnOpcion2.Text = miActividad.Opcion2;
                            btnOpcion3.Text = miActividad.Opcion3;
                            btnOpcion4.Text = miActividad.Opcion4;
                          //lblPregunta.Text = miActividad.Pregunta;
                            this.Text = miActividad.Pregunta;
                            bolModificado = true; 
                        }
                    }
                }
                boolExiste = false;
                foreach (Actividad miActividad in miListaDeActividades1)
                {
                    intCantidadDeActividades++;
                }
                foreach (Actividad miActividad in miListaDeActividades1Hechas)
                {
                    intCantidadDeActividadesHechas++;
                }
                if (intCantidadDeActividades==intCantidadDeActividadesHechas)
                {
                    bolListaLlena = true;
                    MessageBox.Show("Todas Las Actividades Han Sido Terminadas");
                }
                if (bolModificado==true)
                {
                    bolModificado = false;
                    return;
                }
            } while (bolListaLlena!=true);
            MessageBox.Show("Todas Las Actividades Han Sido Terminadas");
            bolListaLlena = false;


        }

        private void FormaActividadTipo1_Load(object sender, EventArgs e)
        {

        }
    }
}
