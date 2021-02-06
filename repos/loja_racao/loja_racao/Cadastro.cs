using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_racao
{
    public class Cadastro
    {
        SqlCommand cmd = new SqlCommand();
        Conexao conex = new Conexao();
        public String message;

        public Cadastro (String cliente, String endereco, String valor, String telefone, String cpf)
        {
            //comando sql -- sql command
            cmd.CommandText = "insert into entregas (cliente, endereco, valor, telefone, cpf) values (@cliente, @endereco, @valor, @telefone, @cpf) ";

            //parametros
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@cpf", cpf);

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
            catch(SqlException b)
            {
                this.message = "Erro ao tentar se conectar com o banco de Dados.";
            }
            
        }
    }
}
