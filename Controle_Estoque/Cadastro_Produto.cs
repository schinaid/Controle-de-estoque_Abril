using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 * autor Anderson Alves Schinaid
 * final da construção dia 02/02/2018
 * 
 */

namespace Controle_Estoque
{
    public partial class Cadastro_Produto : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ander\Desktop\Projetos (1)\C#\Projetos\Grupo Abril\Controle_Estoque\Controle_Estoque\Controle_Estoque.mdf ;Integrated Security = True; Connect Timeout = 30");

        public Cadastro_Produto()
        {
            InitializeComponent();
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            txt_descricao.Text = "";
            txt_Nome_Produto.Text = "";
            txt_preco.Text = "";
            txt_quantidade.Text = "";
        }

        private void btn_menu_Contato_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Show();
        }

        private void btn_menu_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x00);
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            cadastrar();

        }
        public void cadastrar()
        {

            //string sql = 
            connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO [dbo].[Produto](Id,nome, descricao, preco, quantidade) VALUES (@Id,@nome, @descricao, @preco, @quantidade)";
            cmd.Parameters.Add(new SqlParameter("@Id", this.txt_ID.Text));
            cmd.Parameters.Add(new SqlParameter("@nome", this.txt_Nome_Produto.Text));
            cmd.Parameters.Add(new SqlParameter("@descricao", this.txt_descricao.Text));
            cmd.Parameters.Add(new SqlParameter("@preco", this.txt_preco.Text));
            cmd.Parameters.Add(new SqlParameter("@quantidade", this.txt_quantidade.Text));
            cmd.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("sucesso ao cadastrar");

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
