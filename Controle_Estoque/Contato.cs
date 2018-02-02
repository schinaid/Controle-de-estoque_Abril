using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * autor Anderson Alves Schinaid
 * final da construção dia 02/02/2018
 * 
 */

namespace Controle_Estoque
{
    public partial class Contato : Form
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void btn_menu_Voltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_menu_Sair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0x00);
        }
    }
}
