using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_racao
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection();

        //Construtor
        public Conexao()
        {
            con.ConnectionString = "server=localhost; database=sistema_entregas; uid=root; pwd=9608";
        }
        //Método para conectar
        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Método para desconexão
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
