
namespace FrontEnd
{
    partial class frmGeladeira
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCopiaRampa = new System.Windows.Forms.Button();
            this.btnAtivaRampa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGela4 = new System.Windows.Forms.RadioButton();
            this.rdGela3 = new System.Windows.Forms.RadioButton();
            this.rdGela2 = new System.Windows.Forms.RadioButton();
            this.rdGela1 = new System.Windows.Forms.RadioButton();
            this.dgvEtapas = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeReceita = new System.Windows.Forms.TextBox();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopiaRampa
            // 
            this.btnCopiaRampa.Location = new System.Drawing.Point(288, 25);
            this.btnCopiaRampa.Name = "btnCopiaRampa";
            this.btnCopiaRampa.Size = new System.Drawing.Size(109, 23);
            this.btnCopiaRampa.TabIndex = 0;
            this.btnCopiaRampa.Text = "Copiar Rampa";
            this.btnCopiaRampa.UseVisualStyleBackColor = true;
            this.btnCopiaRampa.Click += new System.EventHandler(this.btnCopiaRampa_Click);
            // 
            // btnAtivaRampa
            // 
            this.btnAtivaRampa.Location = new System.Drawing.Point(288, 54);
            this.btnAtivaRampa.Name = "btnAtivaRampa";
            this.btnAtivaRampa.Size = new System.Drawing.Size(109, 23);
            this.btnAtivaRampa.TabIndex = 2;
            this.btnAtivaRampa.Text = "Ativar Rampa";
            this.btnAtivaRampa.UseVisualStyleBackColor = true;
            this.btnAtivaRampa.Click += new System.EventHandler(this.btnAtivaRampa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gráfico Rampas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Rampa :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGela4);
            this.groupBox1.Controls.Add(this.rdGela3);
            this.groupBox1.Controls.Add(this.rdGela2);
            this.groupBox1.Controls.Add(this.rdGela1);
            this.groupBox1.Location = new System.Drawing.Point(453, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geladeiras :";
            // 
            // rdGela4
            // 
            this.rdGela4.AutoSize = true;
            this.rdGela4.Location = new System.Drawing.Point(181, 58);
            this.rdGela4.Name = "rdGela4";
            this.rdGela4.Size = new System.Drawing.Size(79, 17);
            this.rdGela4.TabIndex = 3;
            this.rdGela4.TabStop = true;
            this.rdGela4.Text = "Geladeira 4";
            this.rdGela4.UseVisualStyleBackColor = true;
            // 
            // rdGela3
            // 
            this.rdGela3.AutoSize = true;
            this.rdGela3.Location = new System.Drawing.Point(181, 21);
            this.rdGela3.Name = "rdGela3";
            this.rdGela3.Size = new System.Drawing.Size(79, 17);
            this.rdGela3.TabIndex = 2;
            this.rdGela3.TabStop = true;
            this.rdGela3.Text = "Geladeira 3";
            this.rdGela3.UseVisualStyleBackColor = true;
            // 
            // rdGela2
            // 
            this.rdGela2.AutoSize = true;
            this.rdGela2.Location = new System.Drawing.Point(30, 58);
            this.rdGela2.Name = "rdGela2";
            this.rdGela2.Size = new System.Drawing.Size(79, 17);
            this.rdGela2.TabIndex = 1;
            this.rdGela2.TabStop = true;
            this.rdGela2.Text = "Geladeira 2";
            this.rdGela2.UseVisualStyleBackColor = true;
            // 
            // rdGela1
            // 
            this.rdGela1.AutoSize = true;
            this.rdGela1.Location = new System.Drawing.Point(30, 21);
            this.rdGela1.Name = "rdGela1";
            this.rdGela1.Size = new System.Drawing.Size(79, 17);
            this.rdGela1.TabIndex = 0;
            this.rdGela1.TabStop = true;
            this.rdGela1.Text = "Geladeira 1";
            this.rdGela1.UseVisualStyleBackColor = true;
            // 
            // dgvEtapas
            // 
            this.dgvEtapas.AllowUserToAddRows = false;
            this.dgvEtapas.AllowUserToDeleteRows = false;
            this.dgvEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEtapas.Location = new System.Drawing.Point(12, 98);
            this.dgvEtapas.Name = "dgvEtapas";
            this.dgvEtapas.ReadOnly = true;
            this.dgvEtapas.RowHeadersWidth = 10;
            this.dgvEtapas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEtapas.Size = new System.Drawing.Size(222, 305);
            this.dgvEtapas.TabIndex = 8;
            this.dgvEtapas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dgvEtapas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceitas_CellContentClick);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(255, 164);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Ref_Temp";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(506, 239);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Receita :";
            // 
            // txtNomeReceita
            // 
            this.txtNomeReceita.Location = new System.Drawing.Point(69, 28);
            this.txtNomeReceita.Name = "txtNomeReceita";
            this.txtNomeReceita.Size = new System.Drawing.Size(100, 20);
            this.txtNomeReceita.TabIndex = 12;
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(393, 122);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(81, 23);
            this.btnGrafico.TabIndex = 13;
            this.btnGrafico.Text = "Visualizar";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // frmGeladeira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(773, 421);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.txtNomeReceita);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvEtapas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtivaRampa);
            this.Controls.Add(this.btnCopiaRampa);
            this.Name = "frmGeladeira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Geladeiras :";
            this.Load += new System.EventHandler(this.frmGeladeira_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEtapas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiaRampa;
        private System.Windows.Forms.Button btnAtivaRampa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGela4;
        private System.Windows.Forms.RadioButton rdGela3;
        private System.Windows.Forms.RadioButton rdGela2;
        private System.Windows.Forms.RadioButton rdGela1;
        private System.Windows.Forms.DataGridView dgvEtapas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeReceita;
        private System.Windows.Forms.Button btnGrafico;
    }
}