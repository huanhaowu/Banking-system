using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Pantalla
{
    public partial class Prestamos2 : Form
    {
        public Prestamos2()
        {
            InitializeComponent();
        }

        private void bttReciboP_Click(object sender, EventArgs e)
        {

        }

        private void bttRetirar4_Click(object sender, EventArgs e)
        {

            Retiro retiro = new Retiro();
            this.Hide();
            if (retiro.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttDepositar4_Click(object sender, EventArgs e)
        {

            Deposito deposito = new Deposito();
            this.Hide();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
