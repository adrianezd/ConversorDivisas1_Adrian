namespace ConversorDivisas1_Adrian
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
            this.lbPesetas = new System.Windows.Forms.Label();
            this.lbEuros = new System.Windows.Forms.Label();
            this.tbPesetas = new System.Windows.Forms.TextBox();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.lbResultadoPeseta = new System.Windows.Forms.Label();
            this.lbResultadoEuro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPesetas
            // 
            this.lbPesetas.AutoSize = true;
            this.lbPesetas.Location = new System.Drawing.Point(179, 97);
            this.lbPesetas.Name = "lbPesetas";
            this.lbPesetas.Size = new System.Drawing.Size(57, 16);
            this.lbPesetas.TabIndex = 0;
            this.lbPesetas.Text = "Pesetas";
            // 
            // lbEuros
            // 
            this.lbEuros.AutoSize = true;
            this.lbEuros.Location = new System.Drawing.Point(479, 97);
            this.lbEuros.Name = "lbEuros";
            this.lbEuros.Size = new System.Drawing.Size(42, 16);
            this.lbEuros.TabIndex = 1;
            this.lbEuros.Text = "Euros";
            // 
            // tbPesetas
            // 
            this.tbPesetas.Location = new System.Drawing.Point(155, 147);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(100, 22);
            this.tbPesetas.TabIndex = 2;
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbPesetas_TextChanged);
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(452, 147);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(100, 22);
            this.tbEuros.TabIndex = 3;
            // 
            // lbResultadoPeseta
            // 
            this.lbResultadoPeseta.AutoSize = true;
            this.lbResultadoPeseta.Location = new System.Drawing.Point(201, 211);
            this.lbResultadoPeseta.Name = "lbResultadoPeseta";
            this.lbResultadoPeseta.Size = new System.Drawing.Size(14, 16);
            this.lbResultadoPeseta.TabIndex = 4;
            this.lbResultadoPeseta.Text = "0";
            // 
            // lbResultadoEuro
            // 
            this.lbResultadoEuro.AutoSize = true;
            this.lbResultadoEuro.Location = new System.Drawing.Point(495, 211);
            this.lbResultadoEuro.Name = "lbResultadoEuro";
            this.lbResultadoEuro.Size = new System.Drawing.Size(14, 16);
            this.lbResultadoEuro.TabIndex = 5;
            this.lbResultadoEuro.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultadoEuro);
            this.Controls.Add(this.lbResultadoPeseta);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.tbPesetas);
            this.Controls.Add(this.lbEuros);
            this.Controls.Add(this.lbPesetas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPesetas;
        private System.Windows.Forms.Label lbEuros;
        private System.Windows.Forms.TextBox tbPesetas;
        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.Label lbResultadoPeseta;
        private System.Windows.Forms.Label lbResultadoEuro;
    }
}

