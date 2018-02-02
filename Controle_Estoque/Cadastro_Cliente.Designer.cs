namespace Controle_Estoque
{
    partial class Cadastro_Cliente
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
            this.txt_Nome_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Telefone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Resetar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Contato = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_menu_Sair = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ID_Cliente = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nome_Cliente
            // 
            this.txt_Nome_Cliente.Location = new System.Drawing.Point(85, 85);
            this.txt_Nome_Cliente.Name = "txt_Nome_Cliente";
            this.txt_Nome_Cliente.Size = new System.Drawing.Size(174, 20);
            this.txt_Nome_Cliente.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 27;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Location = new System.Drawing.Point(86, 168);
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(174, 20);
            this.txt_Telefone.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Telefone Cliente";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.Location = new System.Drawing.Point(96, 212);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cadastrar.TabIndex = 22;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = true;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(86, 127);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(174, 20);
            this.txt_Email.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "E-mail do Cliente";
            // 
            // btn_Resetar
            // 
            this.btn_Resetar.Location = new System.Drawing.Point(182, 212);
            this.btn_Resetar.Name = "btn_Resetar";
            this.btn_Resetar.Size = new System.Drawing.Size(75, 23);
            this.btn_Resetar.TabIndex = 19;
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
            this.menuStrip1.Size = new System.Drawing.Size(267, 24);
            this.menuStrip1.TabIndex = 18;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Nome Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "ID Cliente";
            // 
            // txt_ID_Cliente
            // 
            this.txt_ID_Cliente.Location = new System.Drawing.Point(85, 46);
            this.txt_ID_Cliente.Name = "txt_ID_Cliente";
            this.txt_ID_Cliente.Size = new System.Drawing.Size(174, 20);
            this.txt_ID_Cliente.TabIndex = 26;
            // 
            // Cadastro_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 243);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Nome_Cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ID_Cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Resetar);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(283, 282);
            this.MinimumSize = new System.Drawing.Size(283, 282);
            this.Name = "Cadastro_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de novos clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nome_Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Telefone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Resetar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Contato;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Sair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ID_Cliente;
    }
}