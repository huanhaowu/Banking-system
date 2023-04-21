using Caja.Pantalla;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caja
{
    public partial class TranInd : Form
    {
        
        public TranInd()
        {
            InitializeComponent();
            
          
        }


      

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Dell\\Documents\\Visual Studio 2022\\Visual Studio 2017\\ProyectoFinal\\Caja\\Caja\\DbCaja.mdf\";Integrated Security=True");
        private void TranInd_Load(object sender, EventArgs e)
        {
            //Deposito deposito = new Deposito();

            //SqlCommand command = new SqlCommand("Select * from Transaccion WHERE Transaccion_ID = @valor", connection);
            //command.Parameters.AddWithValue("@valor", DatodeForm1);


            //SqlDataAdapter d = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //d.Fill(dt);

            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource source = new ReportDataSource("Intento122", dt);
            //reportViewer1.LocalReport.ReportPath = "C:\\Users\\Dell\\Documents\\Visual Studio 2022\\Visual Studio 2017\\ProyectoFinal\\Caja\\Caja\\TransaccIndividual.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(source);
            //reportViewer1.RefreshReport();

            this.reportViewer1.RefreshReport();
        }

        private void bttImprimir_Click(object sender, EventArgs e)
        {
            int DatodeForm1 = int.Parse(txtCuenta.Text);
            SqlCommand command = new SqlCommand("Select * from Transaccion WHERE Transaccion_ID = @valor", connection);
            command.Parameters.AddWithValue("@valor", DatodeForm1);


            SqlDataAdapter d = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            d.Fill(dt);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource source = new ReportDataSource("Intento122", dt);
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Dell\\Documents\\Visual Studio 2022\\Visual Studio 2017\\ProyectoFinal\\Caja\\Caja\\TransaccIndividual.rdlc";
            reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();
        }
    }
}
