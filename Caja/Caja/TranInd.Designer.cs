namespace Caja
{
    partial class TranInd
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cajaSETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajaSET = new Caja.CajaSET();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bttImprimir = new System.Windows.Forms.Button();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cajaSETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaSET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cajaSETBindingSource
            // 
            this.cajaSETBindingSource.DataSource = this.cajaSET;
            this.cajaSETBindingSource.Position = 0;
            // 
            // cajaSET
            // 
            this.cajaSET.DataSetName = "CajaSET";
            this.cajaSET.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "Intento122";
            reportDataSource3.Value = this.cajaSETBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Caja.TransaccIndividual.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 92);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(720, 428);
            this.reportViewer1.TabIndex = 0;
            // 
            // TransaccionBindingSource
            // 
            this.TransaccionBindingSource.DataMember = "Transaccion";
            this.TransaccionBindingSource.DataSource = this.cajaSET;
            // 
            // bttImprimir
            // 
            this.bttImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttImprimir.BackColor = System.Drawing.Color.DarkOrange;
            this.bttImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttImprimir.FlatAppearance.BorderSize = 0;
            this.bttImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(172)))), ((int)(((byte)(18)))));
            this.bttImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttImprimir.Font = new System.Drawing.Font("Nunito Sans Black", 9.7F, System.Drawing.FontStyle.Bold);
            this.bttImprimir.ForeColor = System.Drawing.Color.White;
            this.bttImprimir.Location = new System.Drawing.Point(365, 20);
            this.bttImprimir.Name = "bttImprimir";
            this.bttImprimir.Size = new System.Drawing.Size(103, 52);
            this.bttImprimir.TabIndex = 9;
            this.bttImprimir.Text = "Imprimir";
            this.bttImprimir.UseVisualStyleBackColor = false;
            this.bttImprimir.Click += new System.EventHandler(this.bttImprimir_Click);
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(223, 37);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID de Cuenta";
            // 
            // TranInd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.bttImprimir);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TranInd";
            this.Text = "TranInd";
            this.Load += new System.EventHandler(this.TranInd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cajaSETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaSET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TransaccionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource cajaSETBindingSource;
        private CajaSET cajaSET;
        private System.Windows.Forms.BindingSource TransaccionBindingSource;
        private System.Windows.Forms.Button bttImprimir;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label1;
    }
}