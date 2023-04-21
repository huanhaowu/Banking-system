using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Usuarios
{
    public partial class CrearUsuario : Form
    {
        public CrearUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            if (cbPerfil.Text == "Administrador")
            {
                MessageBox.Show(ws.CrearUsuarioCore(int.Parse(txtCliente_ID.Text), txtUsuario.Text, txtClave.Text));
            }
            else 
            {
                MessageBox.Show(ws.CrearUsuarioCaja(int.Parse(txtCliente_ID.Text), txtUsuario.Text, txtClave.Text));
            }
            
            txtCliente_ID.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UsuariosV usuariosV = new UsuariosV();
            this.Hide();
            usuariosV.Show();
        }
    }
}
