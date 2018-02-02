using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

/*
 * autor Anderson Alves Schinaid
 * final da construção dia 02/02/2018
 * 
 */

namespace Controle_Estoque
{
    public partial class Cadastro_Cliente : Form
    {

        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename= C:\Users\ander\Desktop\Projetos (1)\C#\Projetos\Grupo Abril\Controle_Estoque\Controle_Estoque\Controle_Estoque.mdf;Integrated Security = True; Connect Timeout = 30");
        public Cadastro_Cliente()
        {
            InitializeComponent();
        }

        private void btn_Resetar_Click(object sender, EventArgs e)
        {
            txt_Email.Text = "";
            txt_ID_Cliente.Text = "";
            txt_Nome_Cliente.Text = "";
            txt_Telefone.Text = "";
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
            try
            {
                connection.Open();
                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO [dbo].[Cliente](Id ,nome, email, telefone) VALUES (@Id,@nome, @email, @telefone)";
                cmd.Parameters.Add(new SqlParameter("@Id", this.txt_ID_Cliente.Text));
                cmd.Parameters.Add(new SqlParameter("@nome", this.txt_Nome_Cliente.Text));
                cmd.Parameters.Add(new SqlParameter("@email", this.txt_Email.Text));
                cmd.Parameters.Add(new SqlParameter("@telefone", this.txt_Telefone.Text));

                //cmd.CommandText = "insert into [Cliente](Id, nome, email, telefone) values('" + txt_Nome_Cliente + "', '" + txt_Email + "','" + txt_Telefone + "')";
                //cmd.CommandText = "insert into [Produto](Id) values('" + txt_ID_Prod + "')";
                cmd.ExecuteNonQuery();
                connection.Close();


                MessageBox.Show("sucesso ao Cadastrar");
                txt_Email.Text = "";
                txt_ID_Cliente.Text = "";
                txt_Nome_Cliente.Text = "";
                txt_Telefone.Text = "";
            }
            catch (Exception ev)
            {
                MessageBox.Show("Erro ao enviar para o banco de dados");
            }








        }
    }
}
