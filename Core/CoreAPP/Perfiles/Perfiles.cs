using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Perfiles
{
    public partial class Perfiles : Form
    {
        public Perfiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearPerfil perfil = new CrearPerfil();
            perfil.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show(this);
        }

        private void Perfiles_Load(object sender, EventArgs e)
        {

        }
    }
}
