
namespace FrontEnd
{
    partial class frmGeladeria
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCopiaRampa = new System.Windows.Forms.Button();
            this.btnAtivaRampa = new System.Windows.Forms.Button();
            this.btnRemoveRampa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdGela4 = new System.Windows.Forms.RadioButton();
            this.rdGela3 = new System.Windows.Forms.RadioButton();
            this.rdGela2 = new System.Windows.Forms.RadioButton();
            this.rdGela1 = new System.Windows.Forms.RadioButton();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnChart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopiaRampa
            // 
            this.btnCopiaRampa.Location = new System.Drawing.Point(316, 38);
            this.btnCopiaRampa.Name = "btnCopiaRampa";
            this.btnCopiaRampa.Size = new System.Drawing.Size(109, 23);
            this.btnCopiaRampa.TabIndex = 0;
            this.btnCopiaRampa.Text = "Copiar Rampa";
            this.btnCopiaRampa.UseVisualStyleBackColor = true;
            // 
            // btnAtivaRampa
            // 
            this.btnAtivaRampa.Location = new System.Drawing.Point(316, 67);
            this.btnAtivaRampa.Name = "btnAtivaRampa";
            this.btnAtivaRampa.Size = new System.Drawing.Size(109, 23);
            this.btnAtivaRampa.TabIndex = 2;
            this.btnAtivaRampa.Text = "Ativar Rampa";
            this.btnAtivaRampa.UseVisualStyleBackColor = true;
            // 
            // btnRemoveRampa
            // 
            this.btnRemoveRampa.Location = new System.Drawing.Point(316, 96);
            this.btnRemoveRampa.Name = "btnRemoveRampa";
            this.btnRemoveRampa.Size = new System.Drawing.Size(109, 23);
            this.btnRemoveRampa.TabIndex = 3;
            this.btnRemoveRampa.Text = "Remover Rampa";
            this.btnRemoveRampa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grafico Rampas :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Receitas :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdGela4);
            this.groupBox1.Controls.Add(this.rdGela3);
            this.groupBox1.Controls.Add(this.rdGela2);
            this.groupBox1.Controls.Add(this.rdGela1);
            this.groupBox1.Location = new System.Drawing.Point(453, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geladeiras :";
            // 
            // rdGela4
            // 
            this.rdGela4.AutoSize = true;
            this.rdGela4.Location = new System.Drawing.Point(181, 63);
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
            this.rdGela3.Location = new System.Drawing.Point(181, 26);
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
            this.rdGela2.Location = new System.Drawing.Point(30, 63);
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
            this.rdGela1.Location = new System.Drawing.Point(30, 26);
            this.rdGela1.Name = "rdGela1";
            this.rdGela1.Size = new System.Drawing.Size(79, 17);
            this.rdGela1.TabIndex = 0;
            this.rdGela1.TabStop = true;
            this.rdGela1.Text = "Geladeira 1";
            this.rdGela1.UseVisualStyleBackColor = true;
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(16, 35);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceitas.Size = new System.Drawing.Size(291, 331);
            this.dgvReceitas.TabIndex = 8;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(331, 193);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(404, 172);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(453, 156);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 23);
            this.btnChart.TabIndex = 10;
            this.btnChart.Text = "Refresh";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // frmGeladeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(773, 390);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvReceitas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveRampa);
            this.Controls.Add(this.btnAtivaRampa);
            this.Controls.Add(this.btnCopiaRampa);
            this.Name = "frmGeladeria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuração de Geladeiras :";
            this.Load += new System.EventHandler(this.frmGeladeria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopiaRampa;
        private System.Windows.Forms.Button btnAtivaRampa;
        private System.Windows.Forms.Button btnRemoveRampa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdGela4;
        private System.Windows.Forms.RadioButton rdGela3;
        private System.Windows.Forms.RadioButton rdGela2;
        private System.Windows.Forms.RadioButton rdGela1;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnChart;
    }
}