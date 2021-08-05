
namespace FrontEnd
{
    partial class frmStatus
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvGela1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rbGela1 = new System.Windows.Forms.RadioButton();
            this.rbGela2 = new System.Windows.Forms.RadioButton();
            this.rbGela3 = new System.Windows.Forms.RadioButton();
            this.rbGela4 = new System.Windows.Forms.RadioButton();
            this.lbTempAtual = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGela1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGela1
            // 
            this.dgvGela1.AllowUserToAddRows = false;
            this.dgvGela1.AllowUserToDeleteRows = false;
            this.dgvGela1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGela1.Location = new System.Drawing.Point(12, 77);
            this.dgvGela1.Name = "dgvGela1";
            this.dgvGela1.ReadOnly = true;
            this.dgvGela1.RowHeadersWidth = 10;
            this.dgvGela1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGela1.Size = new System.Drawing.Size(572, 194);
            this.dgvGela1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Geladeira 1:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 27);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineWidth = 3;
            this.chart1.BorderSkin.BorderWidth = 2;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 292);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Ref_Temp";
            series1.SmartLabelStyle.CalloutLineWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temp_Lida";
            series2.SmartLabelStyle.CalloutLineWidth = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(572, 203);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // rbGela1
            // 
            this.rbGela1.AutoSize = true;
            this.rbGela1.Location = new System.Drawing.Point(125, 12);
            this.rbGela1.Name = "rbGela1";
            this.rbGela1.Size = new System.Drawing.Size(89, 19);
            this.rbGela1.TabIndex = 11;
            this.rbGela1.TabStop = true;
            this.rbGela1.Text = "Geladeira 1";
            this.rbGela1.UseVisualStyleBackColor = true;
            // 
            // rbGela2
            // 
            this.rbGela2.AutoSize = true;
            this.rbGela2.Location = new System.Drawing.Point(125, 37);
            this.rbGela2.Name = "rbGela2";
            this.rbGela2.Size = new System.Drawing.Size(89, 19);
            this.rbGela2.TabIndex = 12;
            this.rbGela2.TabStop = true;
            this.rbGela2.Text = "Geladeira 2";
            this.rbGela2.UseVisualStyleBackColor = true;
            // 
            // rbGela3
            // 
            this.rbGela3.AutoSize = true;
            this.rbGela3.Location = new System.Drawing.Point(220, 12);
            this.rbGela3.Name = "rbGela3";
            this.rbGela3.Size = new System.Drawing.Size(89, 19);
            this.rbGela3.TabIndex = 13;
            this.rbGela3.TabStop = true;
            this.rbGela3.Text = "Geladeira 3";
            this.rbGela3.UseVisualStyleBackColor = true;
            // 
            // rbGela4
            // 
            this.rbGela4.AutoSize = true;
            this.rbGela4.Location = new System.Drawing.Point(220, 37);
            this.rbGela4.Name = "rbGela4";
            this.rbGela4.Size = new System.Drawing.Size(89, 19);
            this.rbGela4.TabIndex = 14;
            this.rbGela4.TabStop = true;
            this.rbGela4.Text = "Geladeira 4";
            this.rbGela4.UseVisualStyleBackColor = true;
            // 
            // lbTempAtual
            // 
            this.lbTempAtual.AutoSize = true;
            this.lbTempAtual.Location = new System.Drawing.Point(324, 14);
            this.lbTempAtual.Name = "lbTempAtual";
            this.lbTempAtual.Size = new System.Drawing.Size(75, 15);
            this.lbTempAtual.TabIndex = 15;
            this.lbTempAtual.Text = "Temp. Atual:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(407, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(44, 21);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estado Relé:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(407, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(44, 21);
            this.textBox2.TabIndex = 18;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(522, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 27);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(634, 535);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbTempAtual);
            this.Controls.Add(this.rbGela4);
            this.Controls.Add(this.rbGela3);
            this.Controls.Add(this.rbGela2);
            this.Controls.Add(this.rbGela1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGela1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status Atual :";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGela1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGela1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RadioButton rbGela1;
        private System.Windows.Forms.RadioButton rbGela2;
        private System.Windows.Forms.RadioButton rbGela3;
        private System.Windows.Forms.RadioButton rbGela4;
        private System.Windows.Forms.Label lbTempAtual;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSair;
    }
}