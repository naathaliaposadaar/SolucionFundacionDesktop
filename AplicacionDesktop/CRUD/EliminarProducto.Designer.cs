namespace AplicacionDesktop.CRUD
{
    partial class EliminarProducto
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
            this.cbxProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxProd
            // 
            this.cbxProd.FormattingEnabled = true;
            this.cbxProd.Location = new System.Drawing.Point(184, 86);
            this.cbxProd.Name = "cbxProd";
            this.cbxProd.Size = new System.Drawing.Size(194, 21);
            this.cbxProd.TabIndex = 147;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(28, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 146;
            this.label1.Text = "Productos";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(277, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 40);
            this.button1.TabIndex = 145;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnVolver.Location = new System.Drawing.Point(277, 155);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(101, 43);
            this.btnVolver.TabIndex = 144;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(88, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 24);
            this.label8.TabIndex = 143;
            this.label8.Text = "Eliminar Producto";
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEliminarM.Location = new System.Drawing.Point(16, 155);
            this.btnEliminarM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(119, 43);
            this.btnEliminarM.TabIndex = 142;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 322);
            this.Controls.Add(this.cbxProd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnEliminarM);
            this.Name = "EliminarProducto";
            this.Text = "EliminarProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminarM;

    }
}