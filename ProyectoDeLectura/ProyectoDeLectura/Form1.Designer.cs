namespace ProyectoDeLectura
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.lnklblForma1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(433, 37);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(93, 13);
            this.lblPregunta.TabIndex = 0;
            this.lblPregunta.Text = "Lectura Para ni;os";
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.Location = new System.Drawing.Point(885, 32);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion4.TabIndex = 4;
            this.btnOpcion4.Text = "Salir";
            this.btnOpcion4.UseVisualStyleBackColor = true;
            this.btnOpcion4.Click += new System.EventHandler(this.btnOpcion4_Click);
            // 
            // lnklblForma1
            // 
            this.lnklblForma1.AutoSize = true;
            this.lnklblForma1.Location = new System.Drawing.Point(203, 109);
            this.lnklblForma1.Name = "lnklblForma1";
            this.lnklblForma1.Size = new System.Drawing.Size(55, 13);
            this.lnklblForma1.TabIndex = 5;
            this.lnklblForma1.TabStop = true;
            this.lnklblForma1.Text = "Preguntas";
            this.lnklblForma1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblForma1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 515);
            this.Controls.Add(this.lnklblForma1);
            this.Controls.Add(this.btnOpcion4);
            this.Controls.Add(this.lblPregunta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.LinkLabel lnklblForma1;
    }
}

