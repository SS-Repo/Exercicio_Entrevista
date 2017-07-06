using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace WebExercicioEntrevista.CNVeiculo
{
    public class dalVeiculos
    {
        string conexao = ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString;
        SqlConnection conn = null;

        internal List<ddVeiculos> Loadlist() {

            StringBuilder sql = new StringBuilder();
            sql.Append("select");
            sql.Append(" codigo");
            sql.Append(",nome");
            sql.Append(" from tipo_veiculos");

            using (conn = new SqlConnection(conexao))
            {
                SqlCommand Command = new SqlCommand(sql.ToString(), conn);
                List<ddVeiculos> lista = new List<ddVeiculos>();
                ddVeiculos pDados = null;

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = Command.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        while (reader.Read())
                        {
                            pDados = new ddVeiculos();
                            pDados.Codigo = (int)reader["codigo"];
                            pDados.Tipo_Veiculos = reader["nome"].ToString(); ;
                            lista.Add(pDados);
                        }
                    }
                }

                finally
                {
                    conn.Close();
                }
                return lista;
            }

        }
        
    

    }
}