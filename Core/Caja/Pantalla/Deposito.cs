using Caja.DsCajaTableAdapters;
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

namespace Caja.Pantalla
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void bttRetirar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retiro retiro = new Retiro();
            if (retiro.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            if (configuracion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void bttCancelarD_Click(object sender, EventArgs e)
        {
            txtMontoD.Clear();
            txtDescripD.Clear();
            txtCuentaD.Clear();
        }

        // VERIFICAR LA INSERCION DE TRANSACTION
        private void bttConfirmarD_Click(object sender, EventArgs e)
        {
            TransaccionTableAdapter transaccionTableAdapter = new TransaccionTableAdapter();
            transaccionTableAdapter.Connection.Open();
            SqlTransaction trans = transaccionTableAdapter.Connection.BeginTransaction(); 

            //conexion a la capa de integracion
            bool conn = true;

            wsIntegracion.wsIntegracionSoapClient webServiceIntegracion = new wsIntegracion.wsIntegracionSoapClient();

            bool Valido;

            int monto = int.Parse(txtMontoD.Text);
            int numero_cuenta = int.Parse(txtCuentaD.Text);
            int tipo_transaccion = 2;

            //Insert en la tabla de transacciones
            transaccionTableAdapter.spInsertTransaccion(tipo_transaccion, 0, int.Parse(txtCuentaD.Text), int.Parse(txtMontoD.Text), 1);

            //Upsert en la tabla de MontoDiario
            transaccionTableAdapter.spUpsertMontoInicial(tipo_transaccion, int.Parse(txtMontoD.Text));
            MessageBox.Show("Proceso Completado", "Estado de Deposito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            trans.Commit();

            if (conn)
            {
                try
                {
                    Valido = webServiceIntegracion.InsertTransaccion(tipo_transaccion, 0, numero_cuenta, monto, 1);
                    trans.Commit();
                }
                catch (Exception Error)
                {
                    MessageBox.Show("ERROR", "Ocurrio un error en la transaccion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trans.Rollback();
                }

            }
            else 
            {
                MessageBox.Show("Desconectado", "Se encuentra desconectado de la red", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtMontoD.Clear();
            txtDescripD.Clear();
            txtCuentaD.Clear();

        }

        private void bttReciboD_Click(object sender, EventArgs e)
        {
            
            TransacInd1 transac = new TransacInd1();
            transac.ShowDialog();
        }

        private void txtMontoD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCuentaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
