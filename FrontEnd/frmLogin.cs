using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void configurarReceitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exportar datatable da rampa
            Form frm_ctrl = new frmControle();

            frm_ctrl.Show();
        }

        private void visualisarGeladeirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm_stat = new frmStatus();
            frm_stat.Show();
        }
    }
}
