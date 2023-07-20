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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_entrar.Enabled = false;
        }

        private void text_text_Change(object sender, EventArgs e)
        {
            button_entrar.Enabled = text_usuario.Text != "" && text_senha.Text != "" ? true : false;
        }

        private void text_usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_senha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_entrar_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(text_usuario.Text, text_senha.Text);
            if (controle.mensagem.Equals(""))//return;
            {
                if (controle.tem)
                {
                    MessageBox.Show("Entrou");
                    BemVindo bv = new BemVindo();
                    bv.Show();
                }
                else
                {
                    MessageBox.Show("Login nao encontrado, verificar login ou senha", "ERRO!");
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_cadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
        }
    }
}
