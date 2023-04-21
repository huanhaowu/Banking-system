namespace Caja.Pantalla
{
    partial class MontoInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MontoInicial));
            this.button1 = new System.Windows.Forms.Button();
            this.bttConfirmarM = new System.Windows.Forms.Button();
            this.bttCancelarM = new System.Windows.Forms.Button();
            this.txtMontoEspecifico = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Caja.ResourceFondo.circle_xmark_solid__1__1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(276, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttConfirmarM
            // 
            this.bttConfirmarM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttConfirmarM.BackColor = System.Drawing.Color.Transparent;
            this.bttConfirmarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttConfirmarM.FlatAppearance.BorderSize = 0;
            this.bttConfirmarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(171)))), ((int)(((byte)(51)))));
            this.bttConfirmarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(222)))), ((int)(((byte)(81)))));
            this.bttConfirmarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttConfirmarM.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConfirmarM.ForeColor = System.Drawing.Color.White;
            this.bttConfirmarM.Location = new System.Drawing.Point(217, 159);
            this.bttConfirmarM.Name = "bttConfirmarM";
            this.bttConfirmarM.Size = new System.Drawing.Size(75, 26);
            this.bttConfirmarM.TabIndex = 14;
            this.bttConfirmarM.Text = "CONFIRMAR";
            this.bttConfirmarM.UseVisualStyleBackColor = false;
            // 
            // bttCancelarM
            // 
            this.bttCancelarM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCancelarM.BackColor = System.Drawing.Color.Transparent;
            this.bttCancelarM.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttCancelarM.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttCancelarM.FlatAppearance.BorderSize = 0;
            this.bttCancelarM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.bttCancelarM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(137)))), ((int)(((byte)(115)))));
            this.bttCancelarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelarM.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelarM.ForeColor = System.Drawing.Color.White;
            this.bttCancelarM.Location = new System.Drawing.Point(134, 159);
            this.bttCancelarM.Name = "bttCancelarM";
            this.bttCancelarM.Size = new System.Drawing.Size(75, 26);
            this.bttCancelarM.TabIndex = 16;
            this.bttCancelarM.Text = "CANCELAR";
            this.bttCancelarM.UseVisualStyleBackColor = false;
            // 
            // txtMontoEspecifico
            // 
            this.txtMontoEspecifico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(251)))), ((int)(((byte)(254)))));
            this.txtMontoEspecifico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoEspecifico.Font = new System.Drawing.Font("Nunito Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoEspecifico.Location = new System.Drawing.Point(35, 102);
            this.txtMontoEspecifico.Name = "txtMontoEspecifico";
            this.txtMontoEspecifico.Size = new System.Drawing.Size(243, 22);
            this.txtMontoEspecifico.TabIndex = 21;
            // 
            // MontoInicial
            // 
            this.AcceptButton = this.bttConfirmarM;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caja.ResourceFondo.Group_15;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.bttCancelarM;
            this.ClientSize = new System.Drawing.Size(319, 208);
            this.Controls.Add(this.txtMontoEspecifico);
            this.Controls.Add(this.bttCancelarM);
            this.Controls.Add(this.bttConfirmarM);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MontoInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MontoInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bttConfirmarM;
        private System.Windows.Forms.Button bttCancelarM;
        private System.Windows.Forms.TextBox txtMontoEspecifico;
    }
}