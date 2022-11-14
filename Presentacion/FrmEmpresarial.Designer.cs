namespace Presentacion
{
    partial class FrmEmpresarial
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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDatos = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBoxComer = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listaComercial = new System.Windows.Forms.ListBox();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textRazon = new System.Windows.Forms.TextBox();
            this.textNit = new System.Windows.Forms.TextBox();
            this.textTel = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.textBuscar = new System.Windows.Forms.TextBox();
            this.GrillaEmpresarial = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EliminarStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.VerStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageDatos.SuspendLayout();
            this.groupBoxComer.SuspendLayout();
            this.tabPageList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpresarial)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDatos);
            this.tabControl.Controls.Add(this.tabPageList);
            this.tabControl.Location = new System.Drawing.Point(12, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(699, 390);
            this.tabControl.TabIndex = 17;
            this.tabControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl_MouseClick);
            // 
            // tabPageDatos
            // 
            this.tabPageDatos.Controls.Add(this.BtnActualizar);
            this.tabPageDatos.Controls.Add(this.btnClose);
            this.tabPageDatos.Controls.Add(this.btnNew);
            this.tabPageDatos.Controls.Add(this.btnSave);
            this.tabPageDatos.Controls.Add(this.groupBoxComer);
            this.tabPageDatos.Location = new System.Drawing.Point(4, 22);
            this.tabPageDatos.Name = "tabPageDatos";
            this.tabPageDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDatos.Size = new System.Drawing.Size(691, 364);
            this.tabPageDatos.TabIndex = 0;
            this.tabPageDatos.Text = "INSERTAR";
            this.tabPageDatos.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(459, 316);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Gray;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNew.Location = new System.Drawing.Point(257, 316);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 37);
            this.btnNew.TabIndex = 20;
            this.btnNew.Text = "Guardar";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(156, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Nuevo";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBoxComer
            // 
            this.groupBoxComer.BackColor = System.Drawing.Color.Gray;
            this.groupBoxComer.Controls.Add(this.label7);
            this.groupBoxComer.Controls.Add(this.listaComercial);
            this.groupBoxComer.Controls.Add(this.textCorreo);
            this.groupBoxComer.Controls.Add(this.textRazon);
            this.groupBoxComer.Controls.Add(this.textNit);
            this.groupBoxComer.Controls.Add(this.textTel);
            this.groupBoxComer.Controls.Add(this.textName);
            this.groupBoxComer.Controls.Add(this.txtNombre);
            this.groupBoxComer.Controls.Add(this.label6);
            this.groupBoxComer.Controls.Add(this.label5);
            this.groupBoxComer.Controls.Add(this.label4);
            this.groupBoxComer.Controls.Add(this.label3);
            this.groupBoxComer.Controls.Add(this.label2);
            this.groupBoxComer.Controls.Add(this.label1);
            this.groupBoxComer.Location = new System.Drawing.Point(6, 16);
            this.groupBoxComer.Name = "groupBoxComer";
            this.groupBoxComer.Size = new System.Drawing.Size(677, 281);
            this.groupBoxComer.TabIndex = 18;
            this.groupBoxComer.TabStop = false;
            this.groupBoxComer.Text = "Insert";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(456, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 23);
            this.label7.TabIndex = 27;
            this.label7.Text = "Contactos Comerciales";
            // 
            // listaComercial
            // 
            this.listaComercial.BackColor = System.Drawing.Color.White;
            this.listaComercial.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaComercial.ForeColor = System.Drawing.Color.Black;
            this.listaComercial.FormattingEnabled = true;
            this.listaComercial.ItemHeight = 17;
            this.listaComercial.Location = new System.Drawing.Point(460, 42);
            this.listaComercial.Name = "listaComercial";
            this.listaComercial.Size = new System.Drawing.Size(191, 208);
            this.listaComercial.TabIndex = 26;
            this.listaComercial.SelectedIndexChanged += new System.EventHandler(this.listaComercial_SelectedIndexChanged);
            // 
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(150, 238);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(200, 20);
            this.textCorreo.TabIndex = 25;
            // 
            // textRazon
            // 
            this.textRazon.Location = new System.Drawing.Point(150, 204);
            this.textRazon.Name = "textRazon";
            this.textRazon.Size = new System.Drawing.Size(200, 20);
            this.textRazon.TabIndex = 24;
            // 
            // textNit
            // 
            this.textNit.Location = new System.Drawing.Point(150, 161);
            this.textNit.Name = "textNit";
            this.textNit.Size = new System.Drawing.Size(200, 20);
            this.textNit.TabIndex = 23;
            // 
            // textTel
            // 
            this.textTel.Location = new System.Drawing.Point(150, 115);
            this.textTel.Name = "textTel";
            this.textTel.Size = new System.Drawing.Size(200, 20);
            this.textTel.TabIndex = 22;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(150, 73);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(200, 20);
            this.textName.TabIndex = 21;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 23);
            this.label6.TabIndex = 19;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(6, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Razon Social";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Identificacion";
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.BtnBuscar);
            this.tabPageList.Controls.Add(this.textBuscar);
            this.tabPageList.Controls.Add(this.GrillaEmpresarial);
            this.tabPageList.Location = new System.Drawing.Point(4, 22);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageList.Size = new System.Drawing.Size(691, 377);
            this.tabPageList.TabIndex = 1;
            this.tabPageList.Text = "LISTA EMPRESARIAL";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(462, 55);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 20);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // textBuscar
            // 
            this.textBuscar.Location = new System.Drawing.Point(154, 55);
            this.textBuscar.Name = "textBuscar";
            this.textBuscar.Size = new System.Drawing.Size(286, 20);
            this.textBuscar.TabIndex = 1;
            this.textBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // GrillaEmpresarial
            // 
            this.GrillaEmpresarial.AllowUserToAddRows = false;
            this.GrillaEmpresarial.AllowUserToDeleteRows = false;
            this.GrillaEmpresarial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEmpresarial.ContextMenuStrip = this.contextMenuStrip1;
            this.GrillaEmpresarial.Location = new System.Drawing.Point(51, 81);
            this.GrillaEmpresarial.Name = "GrillaEmpresarial";
            this.GrillaEmpresarial.ReadOnly = true;
            this.GrillaEmpresarial.Size = new System.Drawing.Size(588, 245);
            this.GrillaEmpresarial.TabIndex = 0;
            this.GrillaEmpresarial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpresarial_CellContentClick);
            this.GrillaEmpresarial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEmpresarial_CellDoubleClick);
            this.GrillaEmpresarial.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GrillaEmpresarial_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EliminarStrip,
            this.VerStrip});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // EliminarStrip
            // 
            this.EliminarStrip.Name = "EliminarStrip";
            this.EliminarStrip.Size = new System.Drawing.Size(127, 22);
            this.EliminarStrip.Text = "ELIMINAR";
            this.EliminarStrip.Click += new System.EventHandler(this.EliminarStrip_Click);
            // 
            // VerStrip
            // 
            this.VerStrip.Name = "VerStrip";
            this.VerStrip.Size = new System.Drawing.Size(180, 22);
            this.VerStrip.Text = "VER";
            this.VerStrip.Click += new System.EventHandler(this.VerStrip_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.BackColor = System.Drawing.Color.Gray;
            this.BtnActualizar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActualizar.FlatAppearance.BorderSize = 0;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnActualizar.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnActualizar.Location = new System.Drawing.Point(358, 316);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(75, 37);
            this.BtnActualizar.TabIndex = 22;
            this.BtnActualizar.Text = "ACTUALIZAR";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmEmpresarial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(718, 415);
            this.Controls.Add(this.tabControl);
            this.Name = "FrmEmpresarial";
            this.Text = "FrmEmpresarial";
            this.Load += new System.EventHandler(this.FrmEmpresarial_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageDatos.ResumeLayout(false);
            this.groupBoxComer.ResumeLayout(false);
            this.groupBoxComer.PerformLayout();
            this.tabPageList.ResumeLayout(false);
            this.tabPageList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEmpresarial)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageDatos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBoxComer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listaComercial;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textRazon;
        private System.Windows.Forms.TextBox textNit;
        private System.Windows.Forms.TextBox textTel;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox textBuscar;
        private System.Windows.Forms.DataGridView GrillaEmpresarial;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem EliminarStrip;
        private System.Windows.Forms.ToolStripMenuItem VerStrip;
        private System.Windows.Forms.Button BtnActualizar;
    }
}