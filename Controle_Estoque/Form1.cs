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


    public partial class Form1 : Form
    {

        Boolean logado = false;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\ander\Desktop\Projetos (1)\C#\Projetos\Grupo Abril\Controle_Estoque\Controle_Estoque\Controle_Estoque.mdf ;Integrated Security = True; Connect Timeout = 30");
        public Form1()
        {
            InitializeComponent();
        }
        private void ContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contato cont = new Contato();
            cont.Show();
        }

        private void btn_menu_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x00);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x00);
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            verificar();

        }

        private void verificar()
        {
            string login, senha;
            try
            {
                login = txt_Login.Text;
                senha = txt_Senha.Text;

                SqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select count(Id) from funcionario where usuario = @usuario AND senha = @senha";
                cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                connection.Open();

                int teste = (int)cmd.ExecuteScalar();
                if (teste > 0)
                {
                    

                    this.Hide();
                    MessageBox.Show("Logado com sucesso");
                    Area_Pesquisa area = new Area_Pesquisa();
                    area.Show();
                    logado = true;
                    connection.Close();

                }
                else
                {
                    MessageBox.Show("Erro ao logar");
                    logado = false;
                }
            }
            catch (SqlException ev)
            {

                MessageBox.Show("Erro no banco de dados");
            }
            connection.Close();
            }
    }
}

            

            
          
            
    
       
        
     

      
    

