using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class TransacInd1 : Form
    {
        public TransacInd1()
        {
            InitializeComponent();
        }

        private void TransacInd1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Dell\\Documents\\Visual Studio 2022\\Visual Studio 2017\\ProyectoFinal\\Caja\\Caja\\DbCaja.mdf\";Integrated Security=True");
        private void bttReciboD_Click(object sender, EventArgs e)
        {
            int CuentaID = int.Parse(txtCuentaID.Text);
            SqlCommand sqlCommand = new SqlCommand("Select * from Transaccion where Cuenta_ID = @valor", connection);
            sqlCommand.Parameters.AddWithValue("@valor", CuentaID);
            SqlDataAdapter d = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            d.Fill(dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Transaccion1", dataTable);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Dell\\Documents\\Visual Studio 2022\\Visual Studio 2017\\ProyectoFinal\\Caja\\Caja\\Registro\\TranIndi.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
