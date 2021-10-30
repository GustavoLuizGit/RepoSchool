using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoBrasileirao
{
    class ConexaoSQL
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cd = new SqlCommand();
        public SqlDataReader dr;
        SqlDataAdapter da;
        public DataSet ds;
        public void Conectar()
        {
            cn.ConnectionString = "SERVER = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database=Brasileirao;UID=sa;PWD=123;";
            cn.Open();
        }

        public void Desconectar()
        {
            cn.Close();
        }

        public void Executar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            cd.ExecuteNonQuery();
            Desconectar();
        }

        public void Listar(string sql)
        {
            Conectar();
            da = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            da.Fill(ds);
            Desconectar();
        }

        public void Consultar(string sql)
        {
            Conectar();
            cd.Connection = cn;
            cd.CommandText = sql;
            dr = cd.ExecuteReader();
        }
    }
}
