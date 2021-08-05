using System;
using Business;
using System.Windows.Forms;
using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrontEnd
{
    public partial class frmStatus : Form
    {
        public frmStatus()
        {
            InitializeComponent();
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            listarGeladeiras();
            grafico();
        }



        private void listarGeladeiras()
        {
            BSControle a_ge = new BSControle();
            DataTable dt;
            dt = a_ge.ListarTuplas("tb_geladeira_01");

            dgvGela1.DataSource = dt;

            configGridGela1();

        }

        private void configGridGela1()
        {
            // Caso não tenha sido feito nas propriedade em modo design
            dgvGela1.AllowUserToAddRows = false;
            dgvGela1.AllowUserToDeleteRows = false;
            dgvGela1.Columns[0].Visible = false;

            dgvGela1.Columns[1].HeaderText = "Et.";
            dgvGela1.Columns[1].Width = 30;
            dgvGela1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGela1.Columns[2].HeaderText = "Estado:";
            dgvGela1.Columns[2].Width = 120;
            dgvGela1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGela1.Columns[3].HeaderText = "Ref_Temp";
            dgvGela1.Columns[3].Width = 80;
            dgvGela1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvGela1.Columns[4].HeaderText = "Horas";
            dgvGela1.Columns[4].Width = 80;
            dgvGela1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGela1.Columns[5].HeaderText = "Temp_Lida";
            dgvGela1.Columns[5].Width = 80;
            dgvGela1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGela1.Columns[6].HeaderText = "Alarme";
            dgvGela1.Columns[6].Width = 80;
            dgvGela1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvGela1.Columns[7].HeaderText = "Contador";
            dgvGela1.Columns[7].Width = 80;
            dgvGela1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            listarGeladeiras();
            grafico();
        }

        private void grafico()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X_Value", typeof(double));
            dt.Columns.Add("Y_Value", typeof(double));
            dt.Columns.Add("Y_Value2", typeof(double));

            //loop rows
            int maximo = dgvGela1.Rows.Count;
            int ref_temp;
            int temp_lida;
            for (int x = 1; x <= maximo; x++)
            {
                ref_temp = int.Parse(dgvGela1[3, x - 1].Value.ToString());
                temp_lida = int.Parse(dgvGela1[5, x - 1].Value.ToString());
                dt.Rows.Add(x, ref_temp,temp_lida);
            }

            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "X_Value";
            chart1.Series[0].YValueMembers = "Y_Value";

            chart1.Series[1].XValueMember = "X_Value";
            chart1.Series[1].YValueMembers = "Y_Value2";
            //
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = System.Drawing.Color.DarkBlue;
            //
            chart1.Series[1].ChartType = SeriesChartType.Line;
            chart1.Series[1].Color = System.Drawing.Color.Red;
            //
            chart1.Series[0].BorderWidth = 4;
            chart1.Series[1].BorderWidth = 4;

            chart1.DataBind();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
