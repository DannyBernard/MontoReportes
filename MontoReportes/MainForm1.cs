using MontoReportes.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontoReportes
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCuentasReportes rCuentas = new RCuentasReportes();

            rCuentas.Show();
            rCuentas.MdiParent = this;
           

        }
    }
}
