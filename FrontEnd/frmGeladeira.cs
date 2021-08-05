using System;
using System.Data;
using Business;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FrontEnd
{
    public partial class frmGeladeira : Form
    {
        string nome_receita;
        DataTable dt_rampa;
        string tb_nome;
        public frmGeladeira(string tb_nome, DataTable dt_rampa, string nome_receita)
        {

           
            this.dt_rampa = dt_rampa;
            this.nome_receita = nome_receita;
            this.tb_nome = tb_nome;

            InitializeComponent();                   


        }

        private void frmGeladeira_Load(object sender, EventArgs e)
        {
            txtNomeReceita.Text = nome_receita;

            dgvEtapas.DataSource = dt_rampa;
            configGridEtapas();
        }


        private void configGridEtapas()
        {
            // Caso não tenha sido feito nas propriedade em modo design
            dgvEtapas.AllowUserToAddRows = false;
            dgvEtapas.AllowUserToDeleteRows = false;

            dgvEtapas.Columns[7].Visible = false;
            dgvEtapas.Columns[0].Visible = false;          
            dgvEtapas.Columns[2].Visible = false;
            dgvEtapas.Columns[5].Visible = false;
            dgvEtapas.Columns[6].Visible = false;

            dgvEtapas.Columns[1].HeaderText = "Nº ";
            dgvEtapas.Columns[1].Width = 40;
            dgvEtapas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[3].HeaderText = "Ref_Temp.";
            dgvEtapas.Columns[3].Width = 60;
            dgvEtapas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[4].HeaderText = "Horas";
            dgvEtapas.Columns[4].Width = 40;
            dgvEtapas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


        }

        private void grafico()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("X_Value", typeof(double));
            dt.Columns.Add("Y_Value", typeof(double));

            //loop rows
            int maximo = dgvEtapas.Rows.Count;
            int valor;
            for (int x = 1; x <= maximo; x++)
            {
                valor = int.Parse(dgvEtapas[3, x - 1].Value.ToString());
                dt.Rows.Add(x, valor);
            }

            chart1.DataSource = dt;
            chart1.Series[0].XValueMember = "X_Value";
            chart1.Series[0].YValueMembers = "Y_Value";
            //
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Color = System.Drawing.Color.DarkBlue;

            chart1.DataBind();
        }


      

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

     

        private void dgvReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nao mexer
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            grafico();
        }

        private void btnCopiaRampa_Click(object sender, EventArgs e)
        {

        }

        private void btnAtivaRampa_Click(object sender, EventArgs e)
        {

        }
    }
}
