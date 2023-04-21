using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Cliente
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            Cliente.Crear Crear = new Cliente.Crear();
            Crear.Show(this);

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Cliente.Update update = new Cliente.Update();
            update.Show(this);
        }
    }
}
