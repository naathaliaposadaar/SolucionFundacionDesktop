namespace AplicacionDesktop.CRUD
{
    partial class MenuSupervisor
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnFicPS = new System.Windows.Forms.Button();
            this.btnAdProveedor = new System.Windows.Forms.Button();
            this.btnGRG = new System.Windows.Forms.Button();
            this.btnAdProducto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAdMedicina = new System.Windows.Forms.Button();
            this.btnAdInventario = new System.Windows.Forms.Button();
            this.btnAdCompra = new System.Windows.Forms.Button();
            this.btnAdSolicitudMed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bienvenido Supervisor";
            // 
            // btnFicPS
            // 
            this.btnFicPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFicPS.Location = new System.Drawing.Point(52, 347);
            this.btnFicPS.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFicPS.Name = "btnFicPS";
            this.btnFicPS.Size = new System.Drawing.Size(178, 61);
            this.btnFicPS.TabIndex = 18;
            this.btnFicPS.Text = "Gestionar Fichas de Residentes";
            this.btnFicPS.UseVisualStyleBackColor = true;
            // 
            // btnAdProveedor
            // 
            this.btnAdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdProveedor.Location = new System.Drawing.Point(52, 198);
            this.btnAdProveedor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdProveedor.Name = "btnAdProveedor";
            this.btnAdProveedor.Size = new System.Drawing.Size(178, 61);
            this.btnAdProveedor.TabIndex = 19;
            this.btnAdProveedor.Text = "Administrar Proveedor";
            this.btnAdProveedor.UseVisualStyleBackColor = true;
            this.btnAdProveedor.Click += new System.EventHandler(this.btnAdProveedor_Click);
            // 
            // btnGRG
            // 
            this.btnGRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGRG.Location = new System.Drawing.Point(511, 333);
            this.btnGRG.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGRG.Name = "btnGRG";
            this.btnGRG.Size = new System.Drawing.Size(204, 75);
            this.btnGRG.TabIndex = 24;
            this.btnGRG.Text = "Generar Reportes de Gestión";
            this.btnGRG.UseVisualStyleBackColor = true;
            // 
            // btnAdProducto
            // 
            this.btnAdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdProducto.Location = new System.Drawing.Point(278, 102);
            this.btnAdProducto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdProducto.Name = "btnAdProducto";
            this.btnAdProducto.Size = new System.Drawing.Size(178, 61);
            this.btnAdProducto.TabIndex = 27;
            this.btnAdProducto.Text = "Administrar Producto";
            this.btnAdProducto.UseVisualStyleBackColor = true;
            this.btnAdProducto.Click += new System.EventHandler(this.btnAdProducto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(669, 443);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 26);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAdMedicina
            // 
            this.btnAdMedicina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdMedicina.Location = new System.Drawing.Point(52, 102);
            this.btnAdMedicina.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdMedicina.Name = "btnAdMedicina";
            this.btnAdMedicina.Size = new System.Drawing.Size(178, 61);
            this.btnAdMedicina.TabIndex = 30;
            this.btnAdMedicina.Text = "Administrar Medicina";
            this.btnAdMedicina.UseVisualStyleBackColor = true;
            this.btnAdMedicina.Click += new System.EventHandler(this.btnAdMedicina_Click);
            // 
            // btnAdInventario
            // 
            this.btnAdInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdInventario.Location = new System.Drawing.Point(494, 102);
            this.btnAdInventario.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdInventario.Name = "btnAdInventario";
            this.btnAdInventario.Size = new System.Drawing.Size(178, 61);
            this.btnAdInventario.TabIndex = 31;
            this.btnAdInventario.Text = "Administrar Inventario";
            this.btnAdInventario.UseVisualStyleBackColor = true;
            this.btnAdInventario.Click += new System.EventHandler(this.btnAdInventario_Click);
            // 
            // btnAdCompra
            // 
            this.btnAdCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdCompra.Location = new System.Drawing.Point(278, 198);
            this.btnAdCompra.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdCompra.Name = "btnAdCompra";
            this.btnAdCompra.Size = new System.Drawing.Size(178, 61);
            this.btnAdCompra.TabIndex = 32;
            this.btnAdCompra.Text = "Administrar Compra";
            this.btnAdCompra.UseVisualStyleBackColor = true;
            this.btnAdCompra.Click += new System.EventHandler(this.btnAdCompra_Click);
            // 
            // btnAdSolicitudMed
            // 
            this.btnAdSolicitudMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdSolicitudMed.Location = new System.Drawing.Point(494, 198);
            this.btnAdSolicitudMed.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnAdSolicitudMed.Name = "btnAdSolicitudMed";
            this.btnAdSolicitudMed.Size = new System.Drawing.Size(178, 61);
            this.btnAdSolicitudMed.TabIndex = 33;
            this.btnAdSolicitudMed.Text = "Administrar Solicitud Medica";
            this.btnAdSolicitudMed.UseVisualStyleBackColor = true;
            this.btnAdSolicitudMed.Click += new System.EventHandler(this.btnAdSolicitudMed_Click);
            // 
            // MenuSupervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(778, 468);
            this.Controls.Add(this.btnAdSolicitudMed);
            this.Controls.Add(this.btnAdCompra);
            this.Controls.Add(this.btnAdInventario);
            this.Controls.Add(this.btnAdMedicina);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAdProducto);
            this.Controls.Add(this.btnGRG);
            this.Controls.Add(this.btnAdProveedor);
            this.Controls.Add(this.btnFicPS);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "MenuSupervisor";
            this.Text = "Supervisor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFicPS;
        private System.Windows.Forms.Button btnAdProveedor;
        private System.Windows.Forms.Button btnGRG;
        private System.Windows.Forms.Button btnAdProducto;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAdMedicina;
        private System.Windows.Forms.Button btnAdInventario;
        private System.Windows.Forms.Button btnAdCompra;
        private System.Windows.Forms.Button btnAdSolicitudMed;
    }
}