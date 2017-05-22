namespace AplicacionDesktop.CRUD
{
    partial class MenuPersonalMedico
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
            this.btnFicP = new System.Windows.Forms.Button();
            this.btnGestionarParame = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bienvenido ";
            // 
            // btnFicP
            // 
            this.btnFicP.Location = new System.Drawing.Point(99, 110);
            this.btnFicP.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnFicP.Name = "btnFicP";
            this.btnFicP.Size = new System.Drawing.Size(178, 61);
            this.btnFicP.TabIndex = 17;
            this.btnFicP.Text = "Gestionar Fichas de Residentes";
            this.btnFicP.UseVisualStyleBackColor = true;
            // 
            // btnGestionarParame
            // 
            this.btnGestionarParame.Location = new System.Drawing.Point(401, 110);
            this.btnGestionarParame.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGestionarParame.Name = "btnGestionarParame";
            this.btnGestionarParame.Size = new System.Drawing.Size(191, 61);
            this.btnGestionarParame.TabIndex = 18;
            this.btnGestionarParame.Text = "Gestionar Solicitud de Medicamentos";
            this.btnGestionarParame.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(597, 326);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 26);
            this.btnCerrar.TabIndex = 19;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // MenuPersonalMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(719, 353);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGestionarParame);
            this.Controls.Add(this.btnFicP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuPersonalMedico";
            this.Text = "MenuParamedico";
            this.Load += new System.EventHandler(this.MenuParamedico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFicP;
        private System.Windows.Forms.Button btnGestionarParame;
        private System.Windows.Forms.Button btnCerrar;



    }
}