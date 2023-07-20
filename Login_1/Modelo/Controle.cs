using Login_1.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_1.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";
        public bool acessar(String login, String senha)
        {
            loginComandos loginDao = new loginComandos();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public String cadastrar(String email, String senha, String confSenha)
        {
            loginComandos loginDao = new loginComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem)//a mensagem que vai vir e de sucesso
            {
                this.tem = true;
            }
            return mensagem;
        }
    }

}
