namespace Caja
{
    partial class IniciarSesion
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
            this.txtUusuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.bttIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUusuario
            // 
            this.txtUusuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtUusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUusuario.Location = new System.Drawing.Point(256, 251);
            this.txtUusuario.Name = "txtUusuario";
            this.txtUusuario.Size = new System.Drawing.Size(209, 13);
            this.txtUusuario.TabIndex = 0;
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(256, 319);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(209, 13);
            this.txtClave.TabIndex = 1;
            // 
            // bttIniciar
            // 
            this.bttIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttIniciar.BackColor = System.Drawing.Color.Transparent;
            this.bttIniciar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bttIniciar.FlatAppearance.BorderSize = 0;
            this.bttIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bttIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttIniciar.ForeColor = System.Drawing.Color.White;
            this.bttIniciar.Location = new System.Drawing.Point(256, 427);
            this.bttIniciar.Name = "bttIniciar";
            this.bttIniciar.Size = new System.Drawing.Size(209, 32);
            this.bttIniciar.TabIndex = 2;
            this.bttIniciar.Text = "Iniciar Sesión";
            this.bttIniciar.UseVisualStyleBackColor = false;
            this.bttIniciar.Click += new System.EventHandler(this.bttIniciar_Click);
            // 
            // IniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Caja.ResourceFondo.Log_In__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.bttIniciar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUusuario);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUusuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button bttIniciar;
    }
}

