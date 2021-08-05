using Business;

using System;
using System.Data;
using System.Windows.Forms;


namespace FrontEnd
{
    public partial class frmControle : Form
    {

        string tb_nome = "";
        string nome_receita = "";
        DataTable dt_rampa;
        public frmControle()
        {
            InitializeComponent();
        }

        private void frmControle_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvReceitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroLin;

            nroLin = e.RowIndex;

            if (nroLin != -1)
            {
                txtCod.Text = dgvReceitas.Rows[nroLin].Cells[0].Value.ToString();
                txtReceita.Text = dgvReceitas.Rows[nroLin].Cells[1].Value.ToString();               
                txtUsuario.Text = dgvReceitas.Rows[nroLin].Cells[2].Value.ToString();
                txtStatus .Text = dgvReceitas.Rows[nroLin].Cells[3].Value.ToString();
                txtEtapa.Text = dgvReceitas.Rows[nroLin].Cells[4].Value.ToString();                

            }

            try
            {
                chkEtapas();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Falha no Banco de Dados ! frmControle, dgvReceitasClick !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void chkEtapas()
        {
            // verifica se a tabela já existe
            tb_nome = "tb_etapa_" + txtCod.Text.ToString();
            BSControle a_tbe = new BSControle();
            DataTable dtEx;
            dtEx = a_tbe.Verifica(tb_nome);
            string resultado = dtEx.Rows[0][0].ToString();
            if (resultado == "False")
            {   // caso não existe, cria a tabela com o nome tb_etapa + txtCod 
                a_tbe.CriarTBEtapa(tb_nome);
                // cria tuplas com a quantidade de etapas 
                for ( int i = 1 ; i <= Convert.ToInt32(txtEtapa.Text.ToString()); i++)
                {
                    a_tbe.N_etapa = i;
                    a_tbe.Estado = "Inicial";
                    a_tbe.Ref_temp = 22;
                    a_tbe.Horas = 190;
                    a_tbe.Temp_lida = 0;
                    a_tbe.Alarme = "ok";
                    a_tbe.Contador = 0;
                    a_tbe.inserirEtapas(tb_nome);
                    // delay
                    for(long j = 1; j <= 1000000; j++) { }

                }
            }
            // lista as tuplas

            ListarEtapas(tb_nome);
            dgvEtapas.ClearSelection();

        }





        private void limparCampos()
        {
            txtCod.Text = "";           
            txtReceita.Text = "";
            txtStatus.Text = "";
            txtUsuario.Text = "";
            txtEtapa.Text = "";
        }

        private void limparCamposEtapas()
        {
            txtCodEtapa.Text = "";
            txtNumEtapa.Text = "";
            txtEstado.Text = "";
            txtRefTemp.Text = "";
            txtHoras.Text = "";
            txtTempLida.Text = "";
            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Business.BSControle a_Rec = new Business.BSControle();             
                

                a_Rec.Receita = txtReceita.Text.ToString();               
                a_Rec.Usuario = txtUsuario.Text.ToString();
                a_Rec.Status = txtStatus.Text.ToString();
                a_Rec.Etapas = Convert.ToInt32(txtEtapa.Text.ToString());
                
                //a_Rec.inserir();
                a_Rec.inserir();
                MessageBox.Show(" Inserido ok");

                Listar();

                limparCampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Inserir Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
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
                dgvReceitas.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Listar Receita Erro ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void calculaTotal()
        {
            int maximo = dgvEtapas.Rows.Count;
            int total = 0;
            for(int x = 0; x < maximo; x++)
            {
                total = total + int.Parse(dgvEtapas[4, x].Value.ToString());
            }

            total = total / 24;
            txtTotal.Text = total.ToString() + " Dias";

        }


        private void ListarEtapas(string tb_nome)
        {
            try
            {

                BSControle o_L = new BSControle();
                DataTable dtRec;
                dtRec = o_L.ListarTuplas(tb_nome);
                dgvEtapas.DataSource = dtRec;

                dt_rampa = dtRec; // copia datatable rampa pra exportar
                configGridEtapas();
                calculaTotal();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Listar TabelaEtapas Erro ! ",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void configGridReceita()
        {
            // Caso não tenha sido feito nas propriedade em modo design
            dgvReceitas.AllowUserToAddRows = false;
            dgvReceitas.AllowUserToDeleteRows = false;           

            dgvReceitas.Columns[0].HeaderText = "ID";
            dgvReceitas.Columns[0].Width = 30;
            dgvReceitas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvReceitas.Columns[1].HeaderText = "Receita:";
            dgvReceitas.Columns[1].Width = 90;
            dgvReceitas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;           

            dgvReceitas.Columns[2].HeaderText = "Usuario";
            dgvReceitas.Columns[2].Width = 80;
            dgvReceitas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvReceitas.Columns[3].HeaderText = "Status";
            dgvReceitas.Columns[3].Width = 50;
            dgvReceitas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvReceitas.Columns[4].HeaderText = "Etapas";
            dgvReceitas.Columns[4].Width = 50;
            dgvReceitas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void configGridEtapas()
        {
            // Caso não tenha sido feito nas propriedade em modo design
            dgvEtapas.AllowUserToAddRows = false;
            dgvEtapas.AllowUserToDeleteRows = false;
            dgvEtapas.Columns[5].Visible = false;
            dgvEtapas.Columns[6].Visible = false;
            dgvEtapas.Columns[7].Visible = false;

            dgvEtapas.Columns[0].HeaderText = "Cód";
            dgvEtapas.Columns[0].Width = 40;
            dgvEtapas.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[1].HeaderText = "Nº ";
            dgvEtapas.Columns[1].Width = 40;
            dgvEtapas.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[2].HeaderText = "Estado.";
            dgvEtapas.Columns[2].Width = 130;
            dgvEtapas.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[3].HeaderText = "Ref_Temp.";
            dgvEtapas.Columns[3].Width = 60;
            dgvEtapas.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvEtapas.Columns[4].HeaderText = "Horas";
            dgvEtapas.Columns[4].Width = 40;
            dgvEtapas.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

           



        }




        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado !");
        }

        private void dgvReceitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //nao mecher
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();            

        }

        private void btnGela_Click(object sender, EventArgs e)
        {

            nome_receita = txtReceita.Text;

            
            // exportar datatable da rampa
            Form frm_gela = new frmGeladeira(tb_nome, dt_rampa, nome_receita);

            frm_gela.Show();
            

            
        }

        private void dgvEtapasClick(object sender, DataGridViewCellEventArgs e)
        {
            int nroLin;

            nroLin = e.RowIndex;

            if (nroLin != -1)
            {
                txtCodEtapa.Text = dgvEtapas.Rows[nroLin].Cells[0].Value.ToString();
                txtNumEtapa.Text = dgvEtapas.Rows[nroLin].Cells[1].Value.ToString();
                txtEstado.Text = dgvEtapas.Rows[nroLin].Cells[2].Value.ToString();
                txtRefTemp.Text = dgvEtapas.Rows[nroLin].Cells[3].Value.ToString();
                txtHoras.Text = dgvEtapas.Rows[nroLin].Cells[4].Value.ToString();
                txtTempLida.Text = dgvEtapas.Rows[nroLin].Cells[5].Value.ToString();                


            }


        }

        private void dgvEtapas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // nao mexer
        }

        private void btnAlteraEtapa_Click(object sender, EventArgs e)
        {
            try
            {
                BSControle o_Contr = new BSControle();

                o_Contr.Cod_etapa = int.Parse(txtCodEtapa.Text);
                o_Contr.N_etapa = int.Parse(txtNumEtapa.Text);
                o_Contr.Estado = txtEstado.Text.ToString();
                o_Contr.Ref_temp = int.Parse(txtRefTemp.Text);
                o_Contr.Horas = int.Parse(txtHoras.Text);
                o_Contr.Temp_lida = int.Parse(txtTempLida.Text);
                o_Contr.Alarme = "";
                o_Contr.Contador = 0;

                o_Contr.alteraEtapas(tb_nome);

                ListarEtapas(tb_nome);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Atualizar Etapas Erro !",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnLimparEtapas_Click(object sender, EventArgs e)
        {
            limparCamposEtapas();
        }

        private void btnInserirEtapa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado !");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ainda não implementado !");
        }
    }
}
