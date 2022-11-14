using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFamiliar_Click(object sender, EventArgs e)
        {

            FrmFamiliar F=new FrmFamiliar();
            F.ShowDialog();
        }
        private void btnEmpresarial_Click(object sender, EventArgs e)
        {
            FrmEmpresarial E = new FrmEmpresarial();
            E.ShowDialog();
        }
    }
}
