using System;
using System.Data;
using Business;
using System.Windows.Forms;

namespace FrontEnd
{
    public partial class frmGeladeria : Form
    {
        public frmGeladeria()
        {
            InitializeComponent();
        }

        private void frmGeladeria_Load(object sender, EventArgs e)
        {
            // buscar receitas
            Listar();

        }

        private void Listar()
        {
            try
            {

                BSControle o_L = new BSControle();
                DataTable dtRec;
                dtRec = o_L.Listar();
                dgvReceitas.DataSource = dtRec;

                configGridReceita();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Listar Receita Erro ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        private void configGridReceita()
        {
            // Caso não tenha sido feito nas propriedade em modo design
            dgvReceitas.AllowUserToAddRows = false;
            dgvReceitas.AllowUserToDeleteRows = false;            
            dgvReceitas.Columns[2].Visible = false;

            dgvReceitas.Columns[0].HeaderText = "Cód:";
            dgvReceitas.Columns[0].Width = 30;
            dgvReceitas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvReceitas.Columns[1].HeaderText = "Receita:";
            dgvReceitas.Columns[1].Width = 90;
            dgvReceitas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvReceitas.Columns[3].HeaderText = "Status";
            dgvReceitas.Columns[3].Width = 50;
            dgvReceitas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvReceitas.Columns[4].HeaderText = "Etapas";
            dgvReceitas.Columns[4].Width = 50;
            dgvReceitas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=1Brmku0KVas

            var objChart = chart1.ChartAreas[0];
            // coluna index
            objChart.AxisX.IntervalType = dgvReceitas.Columns[0].ToString();
            objChart.AxisX.Minimum = 1;
            objChart.AxisX.Maximum = 10;
            // coluna temperatura
            objChart.AxisX.IntervalType = dgvReceitas.
            objChart.AxisY.Minimum = 1;
            objChart.AxisY.Maximum = 30;



        }
    }
}
