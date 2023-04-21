namespace Caja.Pantalla
{
    partial class CuadreTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CuadreTransaccion));
            this.bttCancelarC = new System.Windows.Forms.Button();
            this.bttConfirmarC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttCancelarC
            // 
            this.bttCancelarC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttCancelarC.BackColor = System.Drawing.Color.Transparent;
            this.bttCancelarC.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttCancelarC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttCancelarC.FlatAppearance.BorderSize = 0;
            this.bttCancelarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(47)))));
            this.bttCancelarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(137)))), ((int)(((byte)(115)))));
            this.bttCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCancelarC.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCancelarC.ForeColor = System.Drawing.Color.White;
            this.bttCancelarC.Location = new System.Drawing.Point(173, 208);
            this.bttCancelarC.Name = "bttCancelarC";
            this.bttCancelarC.Size = new System.Drawing.Size(75, 25);
            this.bttCancelarC.TabIndex = 18;
            this.bttCancelarC.Text = "CANCELAR";
            this.bttCancelarC.UseVisualStyleBackColor = false;
            // 
            // bttConfirmarC
            // 
            this.bttConfirmarC.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttConfirmarC.BackColor = System.Drawing.Color.Transparent;
            this.bttConfirmarC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttConfirmarC.FlatAppearance.BorderSize = 0;
            this.bttConfirmarC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(171)))), ((int)(((byte)(51)))));
            this.bttConfirmarC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(222)))), ((int)(((byte)(81)))));
            this.bttConfirmarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttConfirmarC.Font = new System.Drawing.Font("Nunito Sans ExtraBold", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttConfirmarC.ForeColor = System.Drawing.Color.White;
            this.bttConfirmarC.Location = new System.Drawing.Point(256, 209);
            this.bttConfirmarC.Name = "bttConfirmarC";
            this.bttConfirmarC.Size = new System.Drawing.Size(75, 25);
            this.bttConfirmarC.TabIndex = 17;
            this.bttConfirmarC.Text = "CONFIRMAR";
            this.bttConfirmarC.UseVisualStyleBackColor = false;
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
            this.button1.Location = new System.Drawing.Point(326, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CuadreTransaccion
            // 
            this.AcceptButton = this.bttConfirmarC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caja.ResourceFondo.Group_25;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.bttCancelarC;
            this.ClientSize = new System.Drawing.Size(370, 267);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bttCancelarC);
            this.Controls.Add(this.bttConfirmarC);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CuadreTransaccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuadreTransaccion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttCancelarC;
        private System.Windows.Forms.Button bttConfirmarC;
        private System.Windows.Forms.Button button1;
    }
}