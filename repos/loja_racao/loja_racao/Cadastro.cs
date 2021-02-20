using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace loja_racao
{
    public class Cadastro
    {
        MySqlCommand cmd = new MySqlCommand();
        Conexao conex = new Conexao();
        public String message;

        public Cadastro (String cliente, String rua, String valor, String telefone, String cpf, String numero, String cidade, String bairro, String uf, Double distancia, Double frete, String date)
        {
            //comando sql -- sql command
            cmd.CommandText = "insert into entregas (cliente, rua, valor, telefone, cpf, rua_numero, cidade, bairro, uf, distancia, frete, data) " +
                "values (@cliente, @rua, @valor, @telefone, @cpf, @rua_numero, @cidade, @bairro, @uf, @distancia, @frete, @data) ";

            //parametros
            cmd.Parameters.AddWithValue("@cliente", cliente);
            cmd.Parameters.AddWithValue("@rua", rua);
            cmd.Parameters.AddWithValue("@valor", valor);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@cpf", cpf);
            cmd.Parameters.AddWithValue("@rua_numero", numero);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@distancia", distancia);
            cmd.Parameters.AddWithValue("@frete", frete);
            cmd.Parameters.AddWithValue("@data", date);


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
