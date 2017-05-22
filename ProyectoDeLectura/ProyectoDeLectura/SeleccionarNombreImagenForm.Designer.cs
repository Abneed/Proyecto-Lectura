namespace ProyectoDeLectura
{
    partial class SeleccionarNombreImagenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picboxImagen = new System.Windows.Forms.PictureBox();
            this.btnOpcionUno = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpcionDos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpcionTres = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpcionCuatro = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxImagen
            // 
            this.picboxImagen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picboxImagen.Location = new System.Drawing.Point(150, 100);
            this.picboxImagen.Name = "picboxImagen";
            this.picboxImagen.Size = new System.Drawing.Size(500, 350);
            this.picboxImagen.TabIndex = 0;
            this.picboxImagen.TabStop = false;
            // 
            // btnOpcionUno
            // 
            this.btnOpcionUno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpcionUno.Depth = 0;
            this.btnOpcionUno.Location = new System.Drawing.Point(200, 475);
            this.btnOpcionUno.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpcionUno.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcionUno.Name = "btnOpcionUno";
            this.btnOpcionUno.Primary = false;
            this.btnOpcionUno.Size = new System.Drawing.Size(172, 36);
            this.btnOpcionUno.TabIndex = 1;
            this.btnOpcionUno.Text = "materialFlatButton1";
            this.btnOpcionUno.UseVisualStyleBackColor = true;
            this.btnOpcionUno.Click += new System.EventHandler(this.btnOpcionUno_Click);
            // 
            // btnOpcionDos
            // 
            this.btnOpcionDos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpcionDos.Depth = 0;
            this.btnOpcionDos.Location = new System.Drawing.Point(200, 525);
            this.btnOpcionDos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpcionDos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcionDos.Name = "btnOpcionDos";
            this.btnOpcionDos.Primary = false;
            this.btnOpcionDos.Size = new System.Drawing.Size(172, 36);
            this.btnOpcionDos.TabIndex = 2;
            this.btnOpcionDos.Text = "materialFlatButton2";
            this.btnOpcionDos.UseVisualStyleBackColor = true;
            this.btnOpcionDos.Click += new System.EventHandler(this.btnOpcionDos_Click);
            // 
            // btnOpcionTres
            // 
            this.btnOpcionTres.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpcionTres.Depth = 0;
            this.btnOpcionTres.Location = new System.Drawing.Point(425, 475);
            this.btnOpcionTres.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpcionTres.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcionTres.Name = "btnOpcionTres";
            this.btnOpcionTres.Primary = false;
            this.btnOpcionTres.Size = new System.Drawing.Size(172, 36);
            this.btnOpcionTres.TabIndex = 3;
            this.btnOpcionTres.Text = "materialFlatButton3";
            this.btnOpcionTres.UseVisualStyleBackColor = true;
            this.btnOpcionTres.Click += new System.EventHandler(this.btnOpcionTres_Click);
            // 
            // btnOpcionCuatro
            // 
            this.btnOpcionCuatro.Depth = 0;
            this.btnOpcionCuatro.Location = new System.Drawing.Point(425, 525);
            this.btnOpcionCuatro.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOpcionCuatro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpcionCuatro.Name = "btnOpcionCuatro";
            this.btnOpcionCuatro.Primary = false;
            this.btnOpcionCuatro.Size = new System.Drawing.Size(172, 36);
            this.btnOpcionCuatro.TabIndex = 4;
            this.btnOpcionCuatro.Text = "materialFlatButton4";
            this.btnOpcionCuatro.UseVisualStyleBackColor = true;
            this.btnOpcionCuatro.Click += new System.EventHandler(this.btnOpcionCuatro_Click);
            // 
            // SeleccionarNombreImagenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnOpcionCuatro);
            this.Controls.Add(this.btnOpcionTres);
            this.Controls.Add(this.btnOpcionDos);
            this.Controls.Add(this.btnOpcionUno);
            this.Controls.Add(this.picboxImagen);
            this.Name = "SeleccionarNombreImagenForm";
            this.Text = "SeleccionarNombreImagenForm";
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxImagen;
        private MaterialSkin.Controls.MaterialFlatButton btnOpcionUno;
        private MaterialSkin.Controls.MaterialFlatButton btnOpcionDos;
        private MaterialSkin.Controls.MaterialFlatButton btnOpcionTres;
        private MaterialSkin.Controls.MaterialFlatButton btnOpcionCuatro;
    }
}