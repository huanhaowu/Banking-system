namespace Caja
{
    partial class TransacInd1
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuentaID = new System.Windows.Forms.TextBox();
            this.bttReciboD = new System.Windows.Forms.Button();
            this.dsCajaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsCaja = new Caja.DsCaja();
            this.dsCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            reportDataSource1.Name = "Transaccion1";
            reportDataSource1.Value = this.dsCajaBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Caja.Registro.TranIndi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 439);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa el ID de la cuenta del cliente";
            // 
            // txtCuentaID
            // 
            this.txtCuentaID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.txtCuentaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuentaID.Font = new System.Drawing.Font("Nunito Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuentaID.Location = new System.Drawing.Point(12, 39);
            this.txtCuentaID.Name = "txtCuentaID";
            this.txtCuentaID.Size = new System.Drawing.Size(209, 24);
            this.txtCuentaID.TabIndex = 2;
            // 
            // bttReciboD
            // 
            this.bttReciboD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttReciboD.AutoSize = true;
            this.bttReciboD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(172)))), ((int)(((byte)(18)))));
            this.bttReciboD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bttReciboD.FlatAppearance.BorderSize = 0;
            this.bttReciboD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(172)))), ((int)(((byte)(18)))));
            this.bttReciboD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.bttReciboD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Bold);
            this.bttReciboD.ForeColor = System.Drawing.Color.White;
            this.bttReciboD.Location = new System.Drawing.Point(242, 23);
            this.bttReciboD.Name = "bttReciboD";
            this.bttReciboD.Size = new System.Drawing.Size(160, 40);
            this.bttReciboD.TabIndex = 9;
            this.bttReciboD.Text = "Imprimir";
            this.bttReciboD.UseVisualStyleBackColor = false;
            this.bttReciboD.Click += new System.EventHandler(this.bttReciboD_Click);
            // 
            // dsCajaBindingSource1
            // 
            this.dsCajaBindingSource1.DataSource = this.dsCaja;
            this.dsCajaBindingSource1.Position = 0;
            // 
            // dsCaja
            // 
            this.dsCaja.DataSetName = "DsCaja";
            this.dsCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsCajaBindingSource
            // 
            this.dsCajaBindingSource.DataSource = this.dsCaja;
            this.dsCajaBindingSource.Position = 0;
            // 
            // TransacInd1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 520);
            this.Controls.Add(this.bttReciboD);
            this.Controls.Add(this.txtCuentaID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TransacInd1";
            this.Text = "TransacInd1";
            this.Load += new System.EventHandler(this.TransacInd1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuentaID;
        private System.Windows.Forms.Button bttReciboD;
        private System.Windows.Forms.BindingSource dsCajaBindingSource1;
        private DsCaja dsCaja;
        private System.Windows.Forms.BindingSource dsCajaBindingSource;
    }
}