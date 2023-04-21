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
    public partial class UsuariosV : Form
    {
        public UsuariosV()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            CrearUsuario usuario = new CrearUsuario();
            this.Hide();
            usuario.Show();
        }

        private void BtnUpdt_Click(object sender, EventArgs e)
        {
            Updt updt = new Updt();
            this.Hide();
            updt.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();

            if (txtUsuario_ID.Text == "")
            {
                dgvUsuario.DataSource = ws.ObtenerUsuarios();
            }
            else
            {
                dgvUsuario.DataSource = ws.ObtenerUsuarioByID(int.Parse(txtUsuario_ID.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.BorrarUsuario(int.Parse(txtUsuario_ID.Text)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
