namespace Presentacion
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
            this.btnFamiliar = new System.Windows.Forms.Button();
            this.btnEmpresarial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFamiliar
            // 
            this.btnFamiliar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnFamiliar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFamiliar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamiliar.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamiliar.ForeColor = System.Drawing.Color.White;
            this.btnFamiliar.Location = new System.Drawing.Point(136, 40);
            this.btnFamiliar.Name = "btnFamiliar";
            this.btnFamiliar.Size = new System.Drawing.Size(115, 54);
            this.btnFamiliar.TabIndex = 0;
            this.btnFamiliar.Text = "Proceso Familiar";
            this.btnFamiliar.UseVisualStyleBackColor = false;
            this.btnFamiliar.Click += new System.EventHandler(this.btnFamiliar_Click);
            // 
            // btnEmpresarial
            // 
            this.btnEmpresarial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEmpresarial.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmpresarial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpresarial.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpresarial.ForeColor = System.Drawing.Color.White;
            this.btnEmpresarial.Location = new System.Drawing.Point(136, 100);
            this.btnEmpresarial.Name = "btnEmpresarial";
            this.btnEmpresarial.Size = new System.Drawing.Size(115, 54);
            this.btnEmpresarial.TabIndex = 1;
            this.btnEmpresarial.Text = "Proceso Empresarial";
            this.btnEmpresarial.UseVisualStyleBackColor = false;
            this.btnEmpresarial.Click += new System.EventHandler(this.btnEmpresarial_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(136, 160);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(115, 54);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(386, 239);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEmpresarial);
            this.Controls.Add(this.btnFamiliar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFamiliar;
        private System.Windows.Forms.Button btnEmpresarial;
        private System.Windows.Forms.Button btnSalir;
    }
}

