
namespace FrontEnd
{
    partial class frmControle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.lbCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.txtReceita = new System.Windows.Forms.TextBox();
            this.lbReceita = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lbStat = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.LbEtapas = new System.Windows.Forms.Label();
            this.lbReceitas = new System.Windows.Forms.Label();
            this.txtEtapa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumEtapa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefTemp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.txtCodEtapa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGela = new System.Windows.Forms.Button();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lbHoras = new System.Windows.Forms.Label();
            this.txtTempLida = new System.Windows.Forms.TextBox();
            this.lbTempLida = new System.Windows.Forms.Label();
            this.btnInserirEtapa = new System.Windows.Forms.Button();
            this.btnAlteraEtapa = new System.Windows.Forms.Button();
            this.btnLimparEtapas = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 109);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(47, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.AllowUserToResizeColumns = false;
            this.dgvReceitas.AllowUserToResizeRows = false;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(12, 160);
            this.dgvReceitas.MultiSelect = false;
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.RowHeadersWidth = 20;
            this.dgvReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceitas.Size = new System.Drawing.Size(326, 250);
            this.dgvReceitas.TabIndex = 1;
            this.dgvReceitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceitas_CellClick);
            this.dgvReceitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceitas_CellContentClick);
            // 
            // lbCod
            // 
            this.lbCod.AutoSize = true;
            this.lbCod.Location = new System.Drawing.Point(9, 17);
            this.lbCod.Name = "lbCod";
            this.lbCod.Size = new System.Drawing.Size(29, 13);
            this.lbCod.TabIndex = 2;
            this.lbCod.Text = "Cód:";
            // 
            // txtCod
            // 
            this.txtCod.BackColor = System.Drawing.Color.Aqua;
            this.txtCod.Location = new System.Drawing.Point(44, 14);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(30, 20);
            this.txtCod.TabIndex = 3;
            // 
            // txtReceita
            // 
            this.txtReceita.Location = new System.Drawing.Point(70, 40);
            this.txtReceita.Name = "txtReceita";
            this.txtReceita.Size = new System.Drawing.Size(165, 20);
            this.txtReceita.TabIndex = 5;
            // 
            // lbReceita
            // 
            this.lbReceita.AutoSize = true;
            this.lbReceita.Location = new System.Drawing.Point(9, 43);
            this.lbReceita.Name = "lbReceita";
            this.lbReceita.Size = new System.Drawing.Size(50, 13);
            this.lbReceita.TabIndex = 4;
            this.lbReceita.Text = "Receita :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(70, 66);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(65, 20);
            this.txtUsuario.TabIndex = 9;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(9, 69);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(49, 13);
            this.lbUser.TabIndex = 8;
            this.lbUser.Text = "Usuario :";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(144, 14);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(91, 20);
            this.txtStatus.TabIndex = 11;
            // 
            // lbStat
            // 
            this.lbStat.AutoSize = true;
            this.lbStat.Location = new System.Drawing.Point(92, 17);
            this.lbStat.Name = "lbStat";
            this.lbStat.Size = new System.Drawing.Size(43, 13);
            this.lbStat.TabIndex = 10;
            this.lbStat.Text = "Status :";
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(95, 109);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(65, 23);
            this.btnRemover.TabIndex = 12;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(198, 109);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(51, 23);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(286, 109);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(52, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // LbEtapas
            // 
            this.LbEtapas.AutoSize = true;
            this.LbEtapas.Location = new System.Drawing.Point(141, 69);
            this.LbEtapas.Name = "LbEtapas";
            this.LbEtapas.Size = new System.Drawing.Size(46, 13);
            this.LbEtapas.TabIndex = 16;
            this.LbEtapas.Text = "Etapas :";
            // 
            // lbReceitas
            // 
            this.lbReceitas.AutoSize = true;
            this.lbReceitas.Location = new System.Drawing.Point(9, 142);
            this.lbReceitas.Name = "lbReceitas";
            this.lbReceitas.Size = new System.Drawing.Size(55, 13);
            this.lbReceitas.TabIndex = 17;
            this.lbReceitas.Text = "Receitas :";
            // 
            // txtEtapa
            // 
            this.txtEtapa.Location = new System.Drawing.Point(198, 66);
            this.txtEtapa.Name = "txtEtapa";
            this.txtEtapa.Size = new System.Drawing.Size(37, 20);
            this.txtEtapa.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Etapas :";
            // 
            // txtNumEtapa
            // 
            this.txtNumEtapa.Location = new System.Drawing.Point(688, 18);
            this.txtNumEtapa.Name = "txtNumEtapa";
            this.txtNumEtapa.Size = new System.Drawing.Size(36, 20);
            this.txtNumEtapa.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Etapa :";
            // 
            // txtRefTemp
            // 
            this.txtRefTemp.Location = new System.Drawing.Point(530, 18);
            this.txtRefTemp.Name = "txtRefTemp";
            this.txtRefTemp.Size = new System.Drawing.Size(37, 20);
            this.txtRefTemp.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Ref. Temp. :";
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.AllowUserToResizeColumns = false;
            this.dgvEtapas.AllowUserToResizeRows = false;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Location = new System.Drawing.Point(357, 160);
            this.dgvEtapas.MultiSelect = false;
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.ReadOnly = true;
            this.dgvEtapas.RowHeadersWidth = 20;
            this.dgvEtapas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapas.Size = new System.Drawing.Size(372, 250);
            this.dgvEtapas.TabIndex = 25;
            this.dgvEtapas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapasClick);
            this.dgvEtapas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEtapas_CellContentClick);
            // 
            // txtCodEtapa
            // 
            this.txtCodEtapa.BackColor = System.Drawing.Color.Aqua;
            this.txtCodEtapa.Location = new System.Drawing.Point(423, 17);
            this.txtCodEtapa.Name = "txtCodEtapa";
            this.txtCodEtapa.ReadOnly = true;
            this.txtCodEtapa.Size = new System.Drawing.Size(29, 20);
            this.txtCodEtapa.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cód Etapa :";
            // 
            // btnGela
            // 
            this.btnGela.Location = new System.Drawing.Point(259, 14);
            this.btnGela.Name = "btnGela";
            this.btnGela.Size = new System.Drawing.Size(79, 72);
            this.btnGela.TabIndex = 29;
            this.btnGela.Text = "Exportar Rampa";
            this.btnGela.UseVisualStyleBackColor = true;
            this.btnGela.Click += new System.EventHandler(this.btnGela_Click);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(401, 46);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(37, 20);
            this.txtHoras.TabIndex = 31;
            // 
            // lbHoras
            // 
            this.lbHoras.AutoSize = true;
            this.lbHoras.Location = new System.Drawing.Point(354, 49);
            this.lbHoras.Name = "lbHoras";
            this.lbHoras.Size = new System.Drawing.Size(41, 13);
            this.lbHoras.TabIndex = 30;
            this.lbHoras.Text = "Horas :";
            // 
            // txtTempLida
            // 
            this.txtTempLida.Location = new System.Drawing.Point(517, 47);
            this.txtTempLida.Name = "txtTempLida";
            this.txtTempLida.Size = new System.Drawing.Size(37, 20);
            this.txtTempLida.TabIndex = 33;
            // 
            // lbTempLida
            // 
            this.lbTempLida.AutoSize = true;
            this.lbTempLida.Location = new System.Drawing.Point(445, 49);
            this.lbTempLida.Name = "lbTempLida";
            this.lbTempLida.Size = new System.Drawing.Size(66, 13);
            this.lbTempLida.TabIndex = 32;
            this.lbTempLida.Text = "Temp. Lida :";
            // 
            // btnInserirEtapa
            // 
            this.btnInserirEtapa.Location = new System.Drawing.Point(539, 109);
            this.btnInserirEtapa.Name = "btnInserirEtapa";
            this.btnInserirEtapa.Size = new System.Drawing.Size(47, 23);
            this.btnInserirEtapa.TabIndex = 36;
            this.btnInserirEtapa.Text = "Inserir";
            this.btnInserirEtapa.UseVisualStyleBackColor = true;
            this.btnInserirEtapa.Click += new System.EventHandler(this.btnInserirEtapa_Click);
            // 
            // btnAlteraEtapa
            // 
            this.btnAlteraEtapa.Location = new System.Drawing.Point(605, 109);
            this.btnAlteraEtapa.Name = "btnAlteraEtapa";
            this.btnAlteraEtapa.Size = new System.Drawing.Size(51, 23);
            this.btnAlteraEtapa.TabIndex = 38;
            this.btnAlteraEtapa.Text = "Alterar";
            this.btnAlteraEtapa.UseVisualStyleBackColor = true;
            this.btnAlteraEtapa.Click += new System.EventHandler(this.btnAlteraEtapa_Click);
            // 
            // btnLimparEtapas
            // 
            this.btnLimparEtapas.Location = new System.Drawing.Point(677, 109);
            this.btnLimparEtapas.Name = "btnLimparEtapas";
            this.btnLimparEtapas.Size = new System.Drawing.Size(52, 23);
            this.btnLimparEtapas.TabIndex = 41;
            this.btnLimparEtapas.Text = "Limpar Campos";
            this.btnLimparEtapas.UseVisualStyleBackColor = true;
            this.btnLimparEtapas.Click += new System.EventHandler(this.btnLimparEtapas_Click);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(612, 46);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(114, 20);
            this.txtEstado.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(560, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Estado :";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Aqua;
            this.txtTotal.Location = new System.Drawing.Point(401, 81);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(58, 20);
            this.txtTotal.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Total :";
            // 
            // frmControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(757, 446);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLimparEtapas);
            this.Controls.Add(this.btnAlteraEtapa);
            this.Controls.Add(this.btnInserirEtapa);
            this.Controls.Add(this.txtTempLida);
            this.Controls.Add(this.lbTempLida);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.lbHoras);
            this.Controls.Add(this.btnGela);
            this.Controls.Add(this.txtCodEtapa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.txtNumEtapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRefTemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtapa);
            this.Controls.Add(this.lbReceitas);
            this.Controls.Add(this.LbEtapas);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lbStat);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtReceita);
            this.Controls.Add(this.lbReceita);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lbCod);
            this.Controls.Add(this.dgvReceitas);
            this.Controls.Add(this.btnInserir);
            this.Name = "frmControle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControle";
            this.Load += new System.EventHandler(this.frmControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Label lbCod;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtReceita;
        private System.Windows.Forms.Label lbReceita;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lbStat;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label LbEtapas;
        private System.Windows.Forms.Label lbReceitas;
        private System.Windows.Forms.TextBox txtEtapa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumEtapa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.TextBox txtCodEtapa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGela;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label lbHoras;
        private System.Windows.Forms.TextBox txtTempLida;
        private System.Windows.Forms.Label lbTempLida;
        private System.Windows.Forms.Button btnInserirEtapa;
        private System.Windows.Forms.Button btnAlteraEtapa;
        private System.Windows.Forms.Button btnLimparEtapas;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
    }
}