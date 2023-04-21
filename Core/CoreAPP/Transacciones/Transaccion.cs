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
            crearTransaccion.Show(this);
        }

        private void BtnActializar_Click(object sender, EventArgs e)
        {
            Transacciones.updateTransaccion update = new updateTransaccion();
            update.Show(this);
        }
    }
}
