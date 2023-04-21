namespace CoreAPP.Prestamos
{
    partial class actualizarPrestamos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrestamo_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbBanco = new System.Windows.Forms.ComboBox();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.txtMontoPrestamo = new System.Windows.Forms.TextBox();
            this.dtFFinal = new System.Windows.Forms.DateTimePicker();
            this.Btnactualizar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.txtCliente_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actualizar Prestamos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de Prestamo:";
            // 
            // txtPrestamo_ID
            // 
            this.txtPrestamo_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrestamo_ID.Location = new System.Drawing.Point(595, 19);
            this.txtPrestamo_ID.Name = "txtPrestamo_ID";
            this.txtPrestamo_ID.Size = new System.Drawing.Size(100, 20);
            this.txtPrestamo_ID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID de Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tasa de interes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label6.Location = new System.Drawing.Point(21, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto de prestamo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Banco:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label9.Location = new System.Drawing.Point(21, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Estado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 12F);
            this.label10.Location = new System.Drawing.Point(24, 339);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Moneda:";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(193, 292);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(214, 21);
            this.cbEstado.TabIndex = 12;
            // 
            // cbBanco
            // 
            this.cbBanco.FormattingEnabled = true;
            this.cbBanco.Location = new System.Drawing.Point(193, 246);
            this.cbBanco.Name = "cbBanco";
            this.cbBanco.Size = new System.Drawing.Size(214, 21);
            this.cbBanco.TabIndex = 13;
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(193, 339);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(214, 21);
            this.cbMoneda.TabIndex = 14;
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTasaInteres.Location = new System.Drawing.Point(193, 101);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(214, 20);
            this.txtTasaInteres.TabIndex = 15;
            // 
            // txtMontoPrestamo
            // 
            this.txtMontoPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoPrestamo.Location = new System.Drawing.Point(193, 196);
            this.txtMontoPrestamo.Name = "txtMontoPrestamo";
            this.txtMontoPrestamo.Size = new System.Drawing.Size(214, 20);
            this.txtMontoPrestamo.TabIndex = 17;
            // 
            // dtFFinal
            // 
            this.dtFFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFFinal.Location = new System.Drawing.Point(193, 147);
            this.dtFFinal.Name = "dtFFinal";
            this.dtFFinal.Size = new System.Drawing.Size(214, 20);
            this.dtFFinal.TabIndex = 18;
            // 
            // Btnactualizar
            // 
            this.Btnactualizar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnactualizar.Location = new System.Drawing.Point(552, 126);
            this.Btnactualizar.Name = "Btnactualizar";
            this.Btnactualizar.Size = new System.Drawing.Size(182, 66);
            this.Btnactualizar.TabIndex = 19;
            this.Btnactualizar.Text = "Actualizar";
            this.Btnactualizar.UseVisualStyleBackColor = true;
            this.Btnactualizar.Click += new System.EventHandler(this.Btnactualizar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(552, 246);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(182, 61);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // txtCliente_ID
            // 
            this.txtCliente_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCliente_ID.Location = new System.Drawing.Point(193, 61);
            this.txtCliente_ID.Name = "txtCliente_ID";
            this.txtCliente_ID.Size = new System.Drawing.Size(214, 20);
            this.txtCliente_ID.TabIndex = 21;
            // 
            // actualizarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCliente_ID);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.Btnactualizar);
            this.Controls.Add(this.dtFFinal);
            this.Controls.Add(this.txtMontoPrestamo);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.cbBanco);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrestamo_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "actualizarPrestamos";
            this.Text = "actualizarPrestamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrestamo_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbBanco;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.TextBox txtMontoPrestamo;
        private System.Windows.Forms.DateTimePicker dtFFinal;
        private System.Windows.Forms.Button Btnactualizar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox txtCliente_ID;
    }
}