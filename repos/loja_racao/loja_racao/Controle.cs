using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_racao
{
    public class Controle
    {
        public bool exist;
        public String message = "";
        public bool acessar(String login, String senha)
        {
            LoginComandos loginDao = new LoginComandos();
            exist = loginDao.verificarLogin(login, senha);
           
            return exist;
        }
        public String Cadastro_Usuario (String email, String senha)
        {
            return message;
        }
    }
}
