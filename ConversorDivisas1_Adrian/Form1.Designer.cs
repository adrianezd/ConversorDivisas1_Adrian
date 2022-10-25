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
            this.cbHistorial = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPesetas
            // 
            this.lbPesetas.AutoSize = true;
            this.lbPesetas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbPesetas.Location = new System.Drawing.Point(557, 52);
            this.lbPesetas.Name = "lbPesetas";
            this.lbPesetas.Size = new System.Drawing.Size(57, 16);
            this.lbPesetas.TabIndex = 0;
            this.lbPesetas.Text = "Pesetas";
            // 
            // lbEuros
            // 
            this.lbEuros.AutoSize = true;
            this.lbEuros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbEuros.Location = new System.Drawing.Point(750, 52);
            this.lbEuros.Name = "lbEuros";
            this.lbEuros.Size = new System.Drawing.Size(42, 16);
            this.lbEuros.TabIndex = 1;
            this.lbEuros.Text = "Euros";
            // 
            // tbPesetas
            // 
            this.tbPesetas.Location = new System.Drawing.Point(534, 81);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(100, 22);
            this.tbPesetas.TabIndex = 2;
            this.tbPesetas.Click += new System.EventHandler(this.tbPesetas_Click);
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbPesetas_TextChanged);
            this.tbPesetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPesetas_KeyPress);
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(723, 81);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(100, 22);
            this.tbEuros.TabIndex = 3;
            this.tbEuros.Click += new System.EventHandler(this.tbEuros_Click);
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged_1);
            this.tbEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // tbDolares
            // 
            this.tbDolares.Location = new System.Drawing.Point(535, 195);
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
            this.lbDolares.Location = new System.Drawing.Point(557, 164);
            this.lbDolares.Name = "lbDolares";
            this.lbDolares.Size = new System.Drawing.Size(55, 16);
            this.lbDolares.TabIndex = 6;
            this.lbDolares.Text = "Dolares";
            // 
            // tbPesos
            // 
            this.tbPesos.Location = new System.Drawing.Point(723, 195);
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
            this.lbPesos.Location = new System.Drawing.Point(720, 164);
            this.lbPesos.Name = "lbPesos";
            this.lbPesos.Size = new System.Drawing.Size(114, 16);
            this.lbPesos.TabIndex = 9;
            this.lbPesos.Text = "Pesos Mexicanos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConversorDivisas1_Adrian.Properties.Resources.free_dollar_coin_icon_2149_thumb1;
            this.pictureBox1.Location = new System.Drawing.Point(-129, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(567, 363);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cbHistorial
            // 
            this.cbHistorial.BackColor = System.Drawing.Color.Lavender;
            this.cbHistorial.FormattingEnabled = true;
            this.cbHistorial.Location = new System.Drawing.Point(492, 330);
            this.cbHistorial.Name = "cbHistorial";
            this.cbHistorial.Size = new System.Drawing.Size(229, 24);
            this.cbHistorial.TabIndex = 13;
            this.cbHistorial.SelectedIndexChanged += new System.EventHandler(this.cbHistorial_SelectedIndexChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(606, 267);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(157, 31);
            this.btGuardar.TabIndex = 14;
            this.btGuardar.Text = "Guardar operación";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(753, 330);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(114, 24);
            this.btBorrar.TabIndex = 15;
            this.btBorrar.Text = "Borrar objeto";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 424);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.cbHistorial);
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
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ComboBox cbHistorial;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btBorrar;
    }
}

