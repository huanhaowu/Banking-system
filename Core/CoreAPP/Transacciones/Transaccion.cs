using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Transacciones
{
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Transacciones.CrearTransaccion crearTransaccion = new Transacciones.CrearTransaccion();
            this.Hide();
            crearTransaccion.Show();
        }

        private void BtnActializar_Click(object sender, EventArgs e)
        {
            Transacciones.updateTransaccion update = new updateTransaccion();
            this.Hide();
            update.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();

            if (txtTransaccionID.Text == "")
            {
                dgvTransaccion.Visible = true;
                txtData.Visible = false;
                dgvTransaccion.DataSource = ws.ObtenerTiposTransacciones();
            }
            if (txtTransaccionID.Text != "")
            {
                SRCore.TipoTransaccion transaccion = new SRCore.TipoTransaccion();
                dgvTransaccion.Visible = false;
                txtData.Visible = true;
                transaccion = ws.ObtenerTipoTransaccionByID(int.Parse(txtTransaccionID.Text));
                txtData.Text = ("Tipo Transaccio ID : " + transaccion.TipoTransaccionID + "\n" +
                                    "Descripcion : " + transaccion.Descripcion + "\n"
                    );
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.BorrarTipoTransaccion(int.Parse(txtTransaccionID.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
