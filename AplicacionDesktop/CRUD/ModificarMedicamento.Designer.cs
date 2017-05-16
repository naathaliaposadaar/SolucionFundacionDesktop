namespace AplicacionDesktop.MENU
{
    partial class ModificarMedicamento
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
            this.txtDes = new System.Windows.Forms.TextBox();
            this.lbld = new System.Windows.Forms.Label();
            this.dtpfv = new System.Windows.Forms.DateTimePicker();
            this.lblFve = new System.Windows.Forms.Label();
            this.dtpff = new System.Windows.Forms.DateTimePicker();
            this.lblfff = new System.Windows.Forms.Label();
            this.cbxum = new System.Windows.Forms.ComboBox();
            this.btnVolverr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnModificarM = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.txtNombreG = new System.Windows.Forms.TextBox();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.lblUM = new System.Windows.Forms.Label();
            this.lblContenido = new System.Windows.Forms.Label();
            this.lblNG = new System.Windows.Forms.Label();
            this.lblNC = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxNombre_C = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(435, 137);
            this.txtDes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(244, 163);
            this.txtDes.TabIndex = 120;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.Location = new System.Drawing.Point(431, 111);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(103, 20);
            this.lbld.TabIndex = 118;
            this.lbld.Text = "Descripción";
            // 
            // dtpfv
            // 
            this.dtpfv.Location = new System.Drawing.Point(184, 270);
            this.dtpfv.Name = "dtpfv";
            this.dtpfv.Size = new System.Drawing.Size(200, 20);
            this.dtpfv.TabIndex = 117;
            // 
            // lblFve
            // 
            this.lblFve.AutoSize = true;
            this.lblFve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFve.Location = new System.Drawing.Point(13, 270);
            this.lblFve.Name = "lblFve";
            this.lblFve.Size = new System.Drawing.Size(163, 20);
            this.lblFve.TabIndex = 116;
            this.lblFve.Text = "Fecha Vencimiento";
            // 
            // dtpff
            // 
            this.dtpff.Location = new System.Drawing.Point(184, 230);
            this.dtpff.Name = "dtpff";
            this.dtpff.Size = new System.Drawing.Size(200, 20);
            this.dtpff.TabIndex = 115;
            // 
            // lblfff
            // 
            this.lblfff.AutoSize = true;
            this.lblfff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfff.Location = new System.Drawing.Point(13, 231);
            this.lblfff.Name = "lblfff";
            this.lblfff.Size = new System.Drawing.Size(157, 20);
            this.lblfff.TabIndex = 114;
            this.lblfff.Text = "Fecha Fabricación";
            // 
            // cbxum
            // 
            this.cbxum.FormattingEnabled = true;
            this.cbxum.Location = new System.Drawing.Point(184, 190);
            this.cbxum.Name = "cbxum";
            this.cbxum.Size = new System.Drawing.Size(199, 21);
            this.cbxum.TabIndex = 113;
            // 
            // btnVolverr
            // 
            this.btnVolverr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverr.Location = new System.Drawing.Point(694, 584);
            this.btnVolverr.Name = "btnVolverr";
            this.btnVolverr.Size = new System.Drawing.Size(65, 31);
            this.btnVolverr.TabIndex = 112;
            this.btnVolverr.Text = "Volver";
            this.btnVolverr.UseVisualStyleBackColor = true;
            this.btnVolverr.Click += new System.EventHandler(this.btnVolverr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 198);
            this.dataGridView1.TabIndex = 111;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(275, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 24);
            this.label8.TabIndex = 110;
            this.label8.Text = "Modificar Medicamentos";
            // 
            // btnModificarM
            // 
            this.btnModificarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarM.Location = new System.Drawing.Point(571, 324);
            this.btnModificarM.Name = "btnModificarM";
            this.btnModificarM.Size = new System.Drawing.Size(108, 34);
            this.btnModificarM.TabIndex = 109;
            this.btnModificarM.Text = "Modificar";
            this.btnModificarM.UseVisualStyleBackColor = true;
            this.btnModificarM.Click += new System.EventHandler(this.btnModificarM_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(431, 68);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(81, 20);
            this.lblC.TabIndex = 108;
            this.lblC.Text = "Cantidad";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(184, 150);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(199, 20);
            this.txtContenido.TabIndex = 106;
            // 
            // txtNombreG
            // 
            this.txtNombreG.Location = new System.Drawing.Point(184, 110);
            this.txtNombreG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreG.Name = "txtNombreG";
            this.txtNombreG.Size = new System.Drawing.Size(200, 20);
            this.txtNombreG.TabIndex = 105;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoUsuario.Location = new System.Drawing.Point(431, 68);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(0, 20);
            this.TipoUsuario.TabIndex = 102;
            // 
            // lblUM
            // 
            this.lblUM.AutoSize = true;
            this.lblUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUM.Location = new System.Drawing.Point(13, 190);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(129, 20);
            this.lblUM.TabIndex = 100;
            this.lblUM.Text = "Unidad/Medida";
            // 
            // lblContenido
            // 
            this.lblContenido.AutoSize = true;
            this.lblContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContenido.Location = new System.Drawing.Point(13, 150);
            this.lblContenido.Name = "lblContenido";
            this.lblContenido.Size = new System.Drawing.Size(91, 20);
            this.lblContenido.TabIndex = 99;
            this.lblContenido.Text = "Contenido";
            // 
            // lblNG
            // 
            this.lblNG.AutoSize = true;
            this.lblNG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNG.Location = new System.Drawing.Point(9, 111);
            this.lblNG.Name = "lblNG";
            this.lblNG.Size = new System.Drawing.Size(149, 20);
            this.lblNG.TabIndex = 98;
            this.lblNG.Text = "Nombre Genérico";
            // 
            // lblNC
            // 
            this.lblNC.AutoSize = true;
            this.lblNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNC.Location = new System.Drawing.Point(8, 68);
            this.lblNC.Name = "lblNC";
            this.lblNC.Size = new System.Drawing.Size(155, 20);
            this.lblNC.TabIndex = 97;
            this.lblNC.Text = "Nombre Comercial";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(518, 68);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(161, 20);
            this.txtCantidad.TabIndex = 122;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // cbxNombre_C
            // 
            this.cbxNombre_C.FormattingEnabled = true;
            this.cbxNombre_C.Location = new System.Drawing.Point(183, 70);
            this.cbxNombre_C.Name = "cbxNombre_C";
            this.cbxNombre_C.Size = new System.Drawing.Size(199, 21);
            this.cbxNombre_C.TabIndex = 123;
            this.cbxNombre_C.SelectionChangeCommitted += new System.EventHandler(this.cbxNombre_C_SelectionChangeCommitted);
            // 
            // ModificarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 630);
            this.Controls.Add(this.cbxNombre_C);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.lbld);
            this.Controls.Add(this.dtpfv);
            this.Controls.Add(this.lblFve);
            this.Controls.Add(this.dtpff);
            this.Controls.Add(this.lblfff);
            this.Controls.Add(this.cbxum);
            this.Controls.Add(this.btnVolverr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnModificarM);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.txtNombreG);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.lblContenido);
            this.Controls.Add(this.lblNG);
            this.Controls.Add(this.lblNC);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "ModificarMedicamento";
            this.Text = "ModificarMedicamento";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.DateTimePicker dtpfv;
        private System.Windows.Forms.Label lblFve;
        private System.Windows.Forms.DateTimePicker dtpff;
        private System.Windows.Forms.Label lblfff;
        private System.Windows.Forms.ComboBox cbxum;
        private System.Windows.Forms.Button btnVolverr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificarM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.TextBox txtNombreG;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.Label lblUM;
        private System.Windows.Forms.Label lblContenido;
        private System.Windows.Forms.Label lblNG;
        private System.Windows.Forms.Label lblNC;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxNombre_C;
    }
}