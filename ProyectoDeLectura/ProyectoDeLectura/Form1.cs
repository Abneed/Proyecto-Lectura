﻿using System;
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

namespace ProyectoDeLectura
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green800, Primary.Green900, Primary.Green500, Accent.LightGreen200, TextShade.WHITE);
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
            SeleccionarNombreImagenForm miForma = new SeleccionarNombreImagenForm();
            this.Visible = false;
            miForma.Show();
        }

        private void lnkAdministrador_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
