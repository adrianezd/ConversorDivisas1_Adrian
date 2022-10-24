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
            this.tbDolares = new System.Windows.Forms.TextBox();
            this.lbDolares = new System.Windows.Forms.Label();
            this.tbPesos = new System.Windows.Forms.TextBox();
            this.lbPesos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPesetas
            // 
            this.lbPesetas.AutoSize = true;
            this.lbPesetas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPesetas.Location = new System.Drawing.Point(556, 79);
            this.lbPesetas.Name = "lbPesetas";
            this.lbPesetas.Size = new System.Drawing.Size(57, 16);
            this.lbPesetas.TabIndex = 0;
            this.lbPesetas.Text = "Pesetas";
            // 
            // lbEuros
            // 
            this.lbEuros.AutoSize = true;
            this.lbEuros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEuros.Location = new System.Drawing.Point(719, 79);
            this.lbEuros.Name = "lbEuros";
            this.lbEuros.Size = new System.Drawing.Size(42, 16);
            this.lbEuros.TabIndex = 1;
            this.lbEuros.Text = "Euros";
            // 
            // tbPesetas
            // 
            this.tbPesetas.Location = new System.Drawing.Point(534, 129);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(100, 22);
            this.tbPesetas.TabIndex = 2;
            this.tbPesetas.Click += new System.EventHandler(this.tbPesetas_Click);
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbPesetas_TextChanged);
            this.tbPesetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesetas_KeyPress);
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(691, 129);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(100, 22);
            this.tbEuros.TabIndex = 3;
            this.tbEuros.Click += new System.EventHandler(this.tbEuros_Click);
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged_1);
            this.tbEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // tbDolares
            // 
            this.tbDolares.Location = new System.Drawing.Point(534, 329);
            this.tbDolares.Name = "tbDolares";
            this.tbDolares.Size = new System.Drawing.Size(100, 22);
            this.tbDolares.TabIndex = 7;
            this.tbDolares.Click += new System.EventHandler(this.tbDolares_Click);
            this.tbDolares.TextChanged += new System.EventHandler(this.tbDolares_TextChanged_1);
            this.tbDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDolares_KeyPress);
            // 
            // lbDolares
            // 
            this.lbDolares.AutoSize = true;
            this.lbDolares.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbDolares.Location = new System.Drawing.Point(558, 279);
            this.lbDolares.Name = "lbDolares";
            this.lbDolares.Size = new System.Drawing.Size(55, 16);
            this.lbDolares.TabIndex = 6;
            this.lbDolares.Text = "Dolares";
            // 
            // tbPesos
            // 
            this.tbPesos.Location = new System.Drawing.Point(694, 329);
            this.tbPesos.Name = "tbPesos";
            this.tbPesos.Size = new System.Drawing.Size(100, 22);
            this.tbPesos.TabIndex = 10;
            this.tbPesos.Click += new System.EventHandler(this.tbPesos_Click);
            this.tbPesos.TextChanged += new System.EventHandler(this.tbPesos_TextChanged_1);
            this.tbPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesos_KeyPress);
            // 
            // lbPesos
            // 
            this.lbPesos.AutoSize = true;
            this.lbPesos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPesos.Location = new System.Drawing.Point(691, 279);
            this.lbPesos.Name = "lbPesos";
            this.lbPesos.Size = new System.Drawing.Size(114, 16);
            this.lbPesos.TabIndex = 9;
            this.lbPesos.Text = "Pesos Mexicanos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConversorDivisas1_Adrian.Properties.Resources.free_dollar_coin_icon_2149_thumb1;
            this.pictureBox1.Location = new System.Drawing.Point(-21, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 491);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 549);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbPesos);
            this.Controls.Add(this.lbPesos);
            this.Controls.Add(this.tbDolares);
            this.Controls.Add(this.lbDolares);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.tbPesetas);
            this.Controls.Add(this.lbEuros);
            this.Controls.Add(this.lbPesetas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPesetas;
        private System.Windows.Forms.Label lbEuros;
        private System.Windows.Forms.TextBox tbPesetas;
        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.TextBox tbDolares;
        private System.Windows.Forms.Label lbDolares;
        private System.Windows.Forms.TextBox tbPesos;
        private System.Windows.Forms.Label lbPesos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

