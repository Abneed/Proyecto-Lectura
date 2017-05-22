namespace ProyectoDeLectura
{
    partial class FormaActividadTipo1
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
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.picboxImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.Location = new System.Drawing.Point(499, 520);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion4.TabIndex = 4;
            this.btnOpcion4.Text = "button4";
            this.btnOpcion4.UseVisualStyleBackColor = true;
            this.btnOpcion4.Click += new System.EventHandler(this.btnOpcion4_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(809, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir al menu principal";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(212, 520);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion1.TabIndex = 6;
            this.btnOpcion1.Text = "button1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click_1);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(309, 520);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion2.TabIndex = 7;
            this.btnOpcion2.Text = "button2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click_1);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.Location = new System.Drawing.Point(405, 520);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion3.TabIndex = 8;
            this.btnOpcion3.Text = "button3";
            this.btnOpcion3.UseVisualStyleBackColor = true;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click_1);
            // 
            // picboxImagen
            // 
            this.picboxImagen.Location = new System.Drawing.Point(150, 100);
            this.picboxImagen.Name = "picboxImagen";
            this.picboxImagen.Size = new System.Drawing.Size(500, 350);
            this.picboxImagen.TabIndex = 9;
            this.picboxImagen.TabStop = false;
            // 
            // FormaActividadTipo1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.picboxImagen);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOpcion4);
            this.Name = "FormaActividadTipo1";
            this.Text = "Preguntas";
            this.Load += new System.EventHandler(this.FormaActividadTipo1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picboxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.PictureBox picboxImagen;
    }
}