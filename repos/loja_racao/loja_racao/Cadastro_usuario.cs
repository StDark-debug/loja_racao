using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace loja_racao
{
    class Cadastro_usuario
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao conex = new Conexao();
        public String message;

        public Cadastro_usuario(String novo_login, String nova_senha)
        {
            cmd.CommandText = "insert into users (login, senha) values (@login, @senha) ";
            
            cmd.Parameters.AddWithValue("@login", novo_login);
            cmd.Parameters.AddWithValue("@senha", nova_senha);
            

            //conectar com banco
            try
            {
                cmd.Connection = conex.conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conex.desconectar();
                //mensagem de erro ou sucesso
                this.message = "Cadastrado com Sucesso!";
            }
            catch (SqlException b)
            {
                this.message = "Erro ao tentar se conectar com o banco de Dados.";
            }
        }
    }
}
