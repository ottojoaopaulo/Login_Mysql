using Login_1.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_1
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle()
;           String mensagem = controle.cadastrar(text_login.Text, text_senha.Text, text_conf_senha.Text);
            if (controle.tem)//mensagemn de sucesso
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(controle.mensagem);//mensagem de erro
            }
        }
    }
}
