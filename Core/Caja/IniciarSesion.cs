using Caja.Pantalla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void bttIniciar_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Deposito deposito = new Deposito();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
                
        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {
        }

        private void IniciarSesion_Load_1(object sender, EventArgs e)
        {

        }
    }
}
