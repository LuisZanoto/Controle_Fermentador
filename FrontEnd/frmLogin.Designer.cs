
namespace FrontEnd
{
    partial class frmLogin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efetuarLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarReceitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geladeirasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarGeladeirasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualisarGeladeirasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.receitasToolStripMenuItem,
            this.geladeirasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.efetuarLoginToolStripMenuItem,
            this.cadastrarUsuáriosToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // efetuarLoginToolStripMenuItem
            // 
            this.efetuarLoginToolStripMenuItem.Name = "efetuarLoginToolStripMenuItem";
            this.efetuarLoginToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.efetuarLoginToolStripMenuItem.Text = "Efetuar Login";
            // 
            // cadastrarUsuáriosToolStripMenuItem
            // 
            this.cadastrarUsuáriosToolStripMenuItem.Name = "cadastrarUsuáriosToolStripMenuItem";
            this.cadastrarUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarUsuáriosToolStripMenuItem.Text = "Cadastrar Usuários";
            // 
            // receitasToolStripMenuItem
            // 
            this.receitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarReceitasToolStripMenuItem});
            this.receitasToolStripMenuItem.Name = "receitasToolStripMenuItem";
            this.receitasToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.receitasToolStripMenuItem.Text = "Receitas";
            // 
            // configurarReceitasToolStripMenuItem
            // 
            this.configurarReceitasToolStripMenuItem.Name = "configurarReceitasToolStripMenuItem";
            this.configurarReceitasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.configurarReceitasToolStripMenuItem.Text = "Configurar Receitas";
            this.configurarReceitasToolStripMenuItem.Click += new System.EventHandler(this.configurarReceitasToolStripMenuItem_Click);
            // 
            // geladeirasToolStripMenuItem
            // 
            this.geladeirasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarGeladeirasToolStripMenuItem,
            this.visualisarGeladeirasToolStripMenuItem});
            this.geladeirasToolStripMenuItem.Name = "geladeirasToolStripMenuItem";
            this.geladeirasToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.geladeirasToolStripMenuItem.Text = "Geladeiras";
            // 
            // cadastrarGeladeirasToolStripMenuItem
            // 
            this.cadastrarGeladeirasToolStripMenuItem.Name = "cadastrarGeladeirasToolStripMenuItem";
            this.cadastrarGeladeirasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cadastrarGeladeirasToolStripMenuItem.Text = "Cadastrar Geladeiras";
            // 
            // visualisarGeladeirasToolStripMenuItem
            // 
            this.visualisarGeladeirasToolStripMenuItem.Name = "visualisarGeladeirasToolStripMenuItem";
            this.visualisarGeladeirasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.visualisarGeladeirasToolStripMenuItem.Text = "Visualisar Geladeiras";
            this.visualisarGeladeirasToolStripMenuItem.Click += new System.EventHandler(this.visualisarGeladeirasToolStripMenuItem_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(658, 386);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hteck Lab - Controle Fermentação";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efetuarLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarReceitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geladeirasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarGeladeirasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualisarGeladeirasToolStripMenuItem;
    }
}