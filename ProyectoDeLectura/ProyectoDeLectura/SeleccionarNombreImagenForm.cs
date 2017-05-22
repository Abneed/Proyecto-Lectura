using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace ProyectoDeLectura
{
    public partial class SeleccionarNombreImagenForm : MaterialForm
    {
        ControlActividades Controlador;
        Actividad miActividad;

        public SeleccionarNombreImagenForm()
        {
            InitializeComponent();

            // Tema de la ventana.
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);

            // Titulo de la ventana.
            this.Text = "¿Cual es el nombre del alimento que se muestra en la imagen?";

            Controlador = new ControlActividades(MetodosBaseDatos.ObtenerTodasEntidadesPorCategoria("Alimentos"));

            // Inicializa el interface una nueva ronda de juego.
            InicializarNuevaRonda();
        }

        private void btnOpcionUno_Click(object sender, EventArgs e)
        {
            if (miActividad.IdRespuesta == miActividad.IDs[0])
            {
                MessageBox.Show("Respuesta Correcta.");
                InicializarNuevaRonda();
            }
            else
                MessageBox.Show("Respuesta Incorrecta.");
        }

        private void btnOpcionDos_Click(object sender, EventArgs e)
        {
            if (miActividad.IdRespuesta == miActividad.IDs[1])
            {
                MessageBox.Show("Respuesta Correcta.");
                InicializarNuevaRonda();
            }
            else
                MessageBox.Show("Respuesta Incorrecta.");
        }

        private void btnOpcionTres_Click(object sender, EventArgs e)
        {
            if (miActividad.IdRespuesta == miActividad.IDs[2])
            {
                MessageBox.Show("Respuesta Correcta.");
                InicializarNuevaRonda();
            }
            else
                MessageBox.Show("Respuesta Incorrecta.");
        }

        private void btnOpcionCuatro_Click(object sender, EventArgs e)
        {
            if (miActividad.IdRespuesta == miActividad.IDs[3])
            {
                MessageBox.Show("Respuesta Correcta.");
                InicializarNuevaRonda();
            }
            else
                MessageBox.Show("Respuesta Incorrecta.");
        }

        public void InicializarNuevaRonda()
        {

            miActividad = Controlador.ObtenerSiguienteActividad();

            // Direccion de la imagen.
            picboxImagen.ImageLocation = miActividad.DireccionImagen;

            // Agregar texto a las opciones.
            btnOpcionUno.Text = miActividad.Nombres[0];
            btnOpcionDos.Text = miActividad.Nombres[1];
            btnOpcionTres.Text = miActividad.Nombres[2];
            btnOpcionCuatro.Text = miActividad.Nombres[3];
        }
    }
}
