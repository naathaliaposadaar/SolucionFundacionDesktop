namespace AplicacionDesktop.MENU
{
    partial class MenuAdministrarInventario
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
            this.btnVolverI = new System.Windows.Forms.Button();
            this.btnEliminarI = new System.Windows.Forms.Button();
            this.btnModificarI = new System.Windows.Forms.Button();
            this.btnListarI = new System.Windows.Forms.Button();
            this.btnIngresarI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolverI
            // 
            this.btnVolverI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverI.Location = new System.Drawing.Point(499, 377);
            this.btnVolverI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVolverI.Name = "btnVolverI";
            this.btnVolverI.Size = new System.Drawing.Size(74, 24);
            this.btnVolverI.TabIndex = 17;
            this.btnVolverI.Text = "Volver";
            this.btnVolverI.UseVisualStyleBackColor = true;
            // 
            // btnEliminarI
            // 
            this.btnEliminarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarI.Location = new System.Drawing.Point(435, 111);
            this.btnEliminarI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarI.Name = "btnEliminarI";
            this.btnEliminarI.Size = new System.Drawing.Size(112, 37);
            this.btnEliminarI.TabIndex = 16;
            this.btnEliminarI.Text = "Eliminar";
            this.btnEliminarI.UseVisualStyleBackColor = true;
            this.btnEliminarI.Click += new System.EventHandler(this.btnEliminarI_Click);
            // 
            // btnModificarI
            // 
            this.btnModificarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarI.Location = new System.Drawing.Point(296, 111);
            this.btnModificarI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificarI.Name = "btnModificarI";
            this.btnModificarI.Size = new System.Drawing.Size(112, 37);
            this.btnModificarI.TabIndex = 15;
            this.btnModificarI.Text = "Modificar";
            this.btnModificarI.UseVisualStyleBackColor = true;
            this.btnModificarI.Click += new System.EventHandler(this.btnModificarI_Click);
            // 
            // btnListarI
            // 
            this.btnListarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarI.Location = new System.Drawing.Point(157, 111);
            this.btnListarI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarI.Name = "btnListarI";
            this.btnListarI.Size = new System.Drawing.Size(112, 37);
            this.btnListarI.TabIndex = 14;
            this.btnListarI.Text = "Listar";
            this.btnListarI.UseVisualStyleBackColor = true;
            this.btnListarI.Click += new System.EventHandler(this.btnListarI_Click);
            // 
            // btnIngresarI
            // 
            this.btnIngresarI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarI.Location = new System.Drawing.Point(24, 111);
            this.btnIngresarI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngresarI.Name = "btnIngresarI";
            this.btnIngresarI.Size = new System.Drawing.Size(112, 37);
            this.btnIngresarI.TabIndex = 13;
            this.btnIngresarI.Text = "Ingresar";
            this.btnIngresarI.UseVisualStyleBackColor = true;
            this.btnIngresarI.Click += new System.EventHandler(this.btnIngresarI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administrar Inventario Medicamentos";
            // 
            // MenuAdministrarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.btnVolverI);
            this.Controls.Add(this.btnEliminarI);
            this.Controls.Add(this.btnModificarI);
            this.Controls.Add(this.btnListarI);
            this.Controls.Add(this.btnIngresarI);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Name = "MenuAdministrarInventario";
            this.Text = "MenuAdministrarInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverI;
        private System.Windows.Forms.Button btnEliminarI;
        private System.Windows.Forms.Button btnModificarI;
        private System.Windows.Forms.Button btnListarI;
        private System.Windows.Forms.Button btnIngresarI;
        private System.Windows.Forms.Label label1;
    }
}