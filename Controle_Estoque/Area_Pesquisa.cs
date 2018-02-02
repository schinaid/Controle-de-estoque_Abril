using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

/*
 * autor Anderson Alves Schinaid
 * final da construção dia 02/02/2018
 * 
 */

namespace Controle_Estoque
{
    public partial class Area_Pesquisa : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ander\Desktop\Projetos (1)\C#\Projetos\Grupo Abril\Controle_Estoque\Controle_Estoque\Controle_Estoque.mdf ;Integrated Security = True; Connect Timeout = 30");
        public Area_Pesquisa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_menu_Deslogar_Click(object sender, EventArgs e)
        {
            Form1 tl = new Form1();
            tl.Show();
            Close();
        }

       

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro_Produto cad = new Cadastro_Produto();
            cad.Show();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            Cadastro_Cliente env = new Cadastro_Cliente();
            env.Show();
        }

        private void btn_menu_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x00);
        }

        private void btn_pesq_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Cliente] where nome = '" + txt_pesq.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            txt_pesq.Text = "";

        }
        public void Tabela_Cliente()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Cliente]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataa = new SqlDataAdapter(cmd);
            dataa.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();

        }
        public void Tabela_Produto()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Produto]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataa = new SqlDataAdapter(cmd);
            dataa.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();

        }

        private void btn_menu_Contato_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Show();
        }

        private void btn_Atu_Click(object sender, EventArgs e)
        {
            Tabela_Cliente();
        }

        private void btn_produto_Click(object sender, EventArgs e)
        {
            Tabela_Produto();
        }

        private void Area_Pesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
