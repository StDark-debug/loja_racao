using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_racao
{
    class LoginComandos
    {
        public bool exist = false;
        public String message;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;

        public bool verificarLogin (String login, String senha)
        {
            cmd.CommandText = "select* from users where login = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);
            

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    exist = true;
                   
                }
            }
            catch (SqlException a)
            {
                this.message = "Erro ao acessar banco de dados";
                
            }
            return exist;
        }

        public String cadastrar (String login, String senha)
        {
            return message;
        }
    }
}
