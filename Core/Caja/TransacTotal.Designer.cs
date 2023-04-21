namespace Caja
{
    partial class TransacTotal
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
            this.dsCajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsCaja = new Caja.DsCaja();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.transaccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transaccionTableAdapter = new Caja.DsCajaTableAdapters.TransaccionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dsCajaBindingSource
            // 
            this.dsCajaBindingSource.DataSource = this.dsCaja;
            this.dsCajaBindingSource.Position = 0;
            // 
            // dsCaja
            // 
            this.dsCaja.DataSetName = "DsCaja";
            this.dsCaja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.transaccionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Caja.Registro.TranTotal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(867, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // transaccionBindingSource
            // 
            this.transaccionBindingSource.DataMember = "Transaccion";
            this.transaccionBindingSource.DataSource = this.dsCajaBindingSource;
            // 
            // transaccionTableAdapter
            // 
            this.transaccionTableAdapter.ClearBeforeFill = true;
            // 
            // TransacTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TransacTotal";
            this.Text = "TransacTotal";
            this.Load += new System.EventHandler(this.TransacTotal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsCajaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transaccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsCajaBindingSource;
        private DsCaja dsCaja;
        private System.Windows.Forms.BindingSource transaccionBindingSource;
        private DsCajaTableAdapters.TransaccionTableAdapter transaccionTableAdapter;
    }
}