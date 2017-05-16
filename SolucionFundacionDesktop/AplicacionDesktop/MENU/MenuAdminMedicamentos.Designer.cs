namespace AplicacionDesktop.MENU
{
    partial class MenuAdminMedicamentos
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
            this.btnVolverU = new System.Windows.Forms.Button();
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnModificarU = new System.Windows.Forms.Button();
            this.btnIngresarU = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolverU
            // 
            this.btnVolverU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverU.Location = new System.Drawing.Point(559, 390);
            this.btnVolverU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnVolverU.Name = "btnVolverU";
            this.btnVolverU.Size = new System.Drawing.Size(90, 30);
            this.btnVolverU.TabIndex = 11;
            this.btnVolverU.Text = "Volver";
            this.btnVolverU.UseVisualStyleBackColor = true;
            this.btnVolverU.Click += new System.EventHandler(this.btnVolverU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Location = new System.Drawing.Point(523, 98);
            this.btnEliminarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(126, 37);
            this.btnEliminarU.TabIndex = 10;
            this.btnEliminarU.Text = "Eliminar";
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnModificarU
            // 
            this.btnModificarU.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnModificarU.Location = new System.Drawing.Point(372, 98);
            this.btnModificarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnModificarU.Name = "btnModificarU";
            this.btnModificarU.Size = new System.Drawing.Size(126, 37);
            this.btnModificarU.TabIndex = 9;
            this.btnModificarU.Text = "Modificar";
            this.btnModificarU.UseVisualStyleBackColor = true;
            this.btnModificarU.Click += new System.EventHandler(this.btnModificarU_Click);
            // 
            // btnIngresarU
            // 
            this.btnIngresarU.Location = new System.Drawing.Point(39, 98);
            this.btnIngresarU.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnIngresarU.Name = "btnIngresarU";
            this.btnIngresarU.Size = new System.Drawing.Size(126, 37);
            this.btnIngresarU.TabIndex = 7;
            this.btnIngresarU.Text = "Ingresar";
            this.btnIngresarU.UseVisualStyleBackColor = true;
            this.btnIngresarU.Click += new System.EventHandler(this.btnIngresarU_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(254, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Administrar Medicamentos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 98);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuAdminMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(658, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolverU);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnModificarU);
            this.Controls.Add(this.btnIngresarU);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuAdminMedicamentos";
            this.Text = "MenuAdminMedicamentos";
            this.Load += new System.EventHandler(this.MenuAdminMedicamentos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolverU;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnModificarU;
        private System.Windows.Forms.Button btnIngresarU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

    }
}