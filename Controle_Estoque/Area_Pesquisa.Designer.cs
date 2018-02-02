namespace Controle_Estoque
{
    partial class Area_Pesquisa
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
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_pesq = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.btn_Atu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Contato = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Deslogar = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_pesq = new System.Windows.Forms.Button();
            this.btn_produto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(85, 225);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(64, 23);
            this.btn_Cadastrar.TabIndex = 11;
            this.btn_Cadastrar.Text = "Cad. Prod";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txt_pesq
            // 
            this.txt_pesq.Location = new System.Drawing.Point(96, 31);
            this.txt_pesq.Name = "txt_pesq";
            this.txt_pesq.Size = new System.Drawing.Size(104, 20);
            this.txt_pesq.TabIndex = 10;
            this.txt_pesq.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Location = new System.Drawing.Point(6, 34);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(88, 13);
            this.Pesquisar.TabIndex = 9;
            this.Pesquisar.Text = "Pesquisar Cliente";
            // 
            // btn_Atu
            // 
            this.btn_Atu.Location = new System.Drawing.Point(155, 225);
            this.btn_Atu.Name = "btn_Atu";
            this.btn_Atu.Size = new System.Drawing.Size(58, 23);
            this.btn_Atu.TabIndex = 8;
            this.btn_Atu.Text = "Cliente";
            this.btn_Atu.UseVisualStyleBackColor = true;
            this.btn_Atu.Click += new System.EventHandler(this.btn_Atu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_menu_Contato,
            this.btn_menu_Deslogar,
            this.btn_menu_Sair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // btn_menu_Contato
            // 
            this.btn_menu_Contato.Name = "btn_menu_Contato";
            this.btn_menu_Contato.Size = new System.Drawing.Size(120, 22);
            this.btn_menu_Contato.Text = "Contato";
            this.btn_menu_Contato.Click += new System.EventHandler(this.btn_menu_Contato_Click);
            // 
            // btn_menu_Deslogar
            // 
            this.btn_menu_Deslogar.Name = "btn_menu_Deslogar";
            this.btn_menu_Deslogar.Size = new System.Drawing.Size(120, 22);
            this.btn_menu_Deslogar.Text = "Deslogar";
            this.btn_menu_Deslogar.Click += new System.EventHandler(this.btn_menu_Deslogar_Click);
            // 
            // btn_menu_Sair
            // 
            this.btn_menu_Sair.Name = "btn_menu_Sair";
            this.btn_menu_Sair.Size = new System.Drawing.Size(120, 22);
            this.btn_menu_Sair.Text = "Sair";
            this.btn_menu_Sair.Click += new System.EventHandler(this.btn_menu_Sair_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(1, 225);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(79, 23);
            this.btn_Enviar.TabIndex = 12;
            this.btn_Enviar.Text = "cad. Cliente";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(277, 159);
            this.dataGridView1.TabIndex = 13;
            // 
            // btn_pesq
            // 
            this.btn_pesq.Location = new System.Drawing.Point(206, 30);
            this.btn_pesq.Name = "btn_pesq";
            this.btn_pesq.Size = new System.Drawing.Size(75, 23);
            this.btn_pesq.TabIndex = 14;
            this.btn_pesq.Text = "Pesquisa";
            this.btn_pesq.UseVisualStyleBackColor = true;
            this.btn_pesq.Click += new System.EventHandler(this.btn_pesq_Click);
            // 
            // btn_produto
            // 
            this.btn_produto.Location = new System.Drawing.Point(218, 226);
            this.btn_produto.Name = "btn_produto";
            this.btn_produto.Size = new System.Drawing.Size(63, 23);
            this.btn_produto.TabIndex = 15;
            this.btn_produto.Text = "Produto";
            this.btn_produto.UseVisualStyleBackColor = true;
            this.btn_produto.Click += new System.EventHandler(this.btn_produto_Click);
            // 
            // Area_Pesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_produto);
            this.Controls.Add(this.btn_pesq);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_pesq);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.btn_Atu);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Area_Pesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Area_Pesquisa";
            this.Load += new System.EventHandler(this.Area_Pesquisa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_pesq;
        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.Button btn_Atu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Contato;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Sair;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Deslogar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_pesq;
        private System.Windows.Forms.Button btn_produto;
    }
}