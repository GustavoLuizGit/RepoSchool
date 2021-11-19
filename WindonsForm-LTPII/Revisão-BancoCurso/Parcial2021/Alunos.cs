using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Parcial2021
{
    class Alunos
    {
        public int IdAluno { get; set; }
        public string Aluno { get; set; }

        public void PesquisarAlunoporId()
        {
            SqlConnection cn = new SqlConnection();
            SqlCommand cd = new SqlCommand();
            cn.ConnectionString = "Server = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database =Curso; UID=sa; PWD=123";
            cn.Open();
            string sql = $"Select *from TabelaAluno where idAluno LIKE '{IdAluno}%'";
            cd.CommandText = sql;
            cd.Connection = cn;
            SqlDataReader dr = cd.ExecuteReader();
            if (dr.Read())
                Aluno = dr["Aluno"].ToString();
            cn.Close();
        }

    }
}
