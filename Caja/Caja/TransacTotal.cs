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
    public partial class TransacTotal : Form
    {
        public TransacTotal()
        {
            InitializeComponent();
        }

        private void TransacTotal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsCaja.Transaccion' table. You can move, or remove it, as needed.
            this.transaccionTableAdapter.Fill(this.dsCaja.Transaccion);

            this.reportViewer1.RefreshReport();
        }
    }
}
