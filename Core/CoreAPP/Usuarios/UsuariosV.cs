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
            usuario.Show(this);
        }

        private void BtnUpdt_Click(object sender, EventArgs e)
        {
            Updt updt = new Updt();
            updt.Show(this);
        }
    }
}
