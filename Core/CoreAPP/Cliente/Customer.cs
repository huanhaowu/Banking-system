﻿using System;
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
            this.Hide();
            Crear.Show();

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Cliente.Update update = new Cliente.Update();
            this.Hide();
            update.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();

            if (txtClienteID.Text == "")
            {
                dgvClientes.DataSource =  ws.ObtenerClientes();
            }
            else
            {
                dgvClientes.DataSource = ws.ObtenerClienteByID(Convert.ToInt32(txtClienteID.Text));
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.BorrarCliente(Convert.ToInt32(txtClienteID.Text)));
        }

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
