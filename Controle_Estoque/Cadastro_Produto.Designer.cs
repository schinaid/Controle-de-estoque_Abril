namespace Controle_Estoque
{
    partial class Cadastro_Produto
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
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Resetar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Contato = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_quantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome_Produto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(86, 151);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(174, 20);
            this.txt_preco.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Preço";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(96, 191);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 11;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txt_descricao
            // 
            this.txt_descricao.Location = new System.Drawing.Point(85, 116);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(174, 20);
            this.txt_descricao.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "descrição ";
            // 
            // btn_Resetar
            // 
            this.btn_Resetar.Location = new System.Drawing.Point(182, 191);
            this.btn_Resetar.Name = "btn_Resetar";
            this.btn_Resetar.Size = new System.Drawing.Size(75, 23);
            this.btn_Resetar.TabIndex = 8;
            this.btn_Resetar.Text = "Resetar";
            this.btn_Resetar.UseVisualStyleBackColor = true;
            this.btn_Resetar.Click += new System.EventHandler(this.btn_Resetar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(272, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_menu_Contato,
            this.btn_menu_Sair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // btn_menu_Contato
            // 
            this.btn_menu_Contato.Name = "btn_menu_Contato";
            this.btn_menu_Contato.Size = new System.Drawing.Size(117, 22);
            this.btn_menu_Contato.Text = "Contato";
            this.btn_menu_Contato.Click += new System.EventHandler(this.btn_menu_Contato_Click);
            // 
            // btn_menu_Sair
            // 
            this.btn_menu_Sair.Name = "btn_menu_Sair";
            this.btn_menu_Sair.Size = new System.Drawing.Size(117, 22);
            this.btn_menu_Sair.Text = "Sair";
            this.btn_menu_Sair.Click += new System.EventHandler(this.btn_menu_Sair_Click);
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Location = new System.Drawing.Point(85, 84);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(174, 20);
            this.txt_quantidade.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantidade ";
            // 
            // txt_Nome_Produto
            // 
            this.txt_Nome_Produto.Location = new System.Drawing.Point(85, 52);
            this.txt_Nome_Produto.Name = "txt_Nome_Produto";
            this.txt_Nome_Produto.Size = new System.Drawing.Size(174, 20);
            this.txt_Nome_Produto.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-1, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome do produto";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(85, 26);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(174, 20);
            this.txt_ID.TabIndex = 19;
            this.txt_ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(27, 29);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 18;
            this.ID.Text = "ID";
            this.ID.Click += new System.EventHandler(this.label5_Click);
            // 
            // Cadastro_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 230);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome_Produto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Resetar);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(288, 269);
            this.MinimumSize = new System.Drawing.Size(288, 269);
            this.Name = "Cadastro_Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro_Produto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Resetar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Contato;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Sair;
        private System.Windows.Forms.TextBox txt_quantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome_Produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label ID;
    }
}