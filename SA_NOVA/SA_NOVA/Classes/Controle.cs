using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA_NOVA.DAL
{
    public class Controle
    {

        public bool cadastrado;
        public String mensagem = "";

        public bool acessar(String login, String senha)
        {
            Login loginDao = new Login();
            cadastrado = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return cadastrado;
        }
    }
}
