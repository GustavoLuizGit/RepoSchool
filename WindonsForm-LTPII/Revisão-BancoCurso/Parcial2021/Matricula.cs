using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Parcial2021
{
    class Matricula
    {
        public int IdMatricula { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
        public float Nota1 { get; set; }

        private float media;
        public float Nota2 { get; set; }
        public float Global { get; set; }
        public float Final { get; set; }
        public string Situacao { get; set; }

        public void CalcularSituacaoporIdMatricula()
        {
            //SqlConnection cn = new SqlConnection();
            //SqlCommand cd = new SqlCommand();
            //cn.ConnectionString = "Server = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database =Curso; UID=sa; PWD=123";
            //cn.Open();
            //string sql = $"Select * from Matricula where idMatricula = '{IdMatricula}'";
            //cd.CommandText = sql;
            //cd.Connection = cn;
            //SqlDataReader dr = cd.ExecuteReader();
            //float media = 0;
            //if (dr.Read())
            //{
            //    Nota1 = float.Parse(dr["Nota1"].ToString());
            //    Nota2 = float.Parse(dr["Nota2"].ToString());
            //    Global = float.Parse(dr["Global"].ToString());
            //    media = (Nota1 + Nota2 + Global) / 3;
            //    if (media < 4)
            //        Situacao = "Reprovado";
            //    else if (media >= 4 && media < 6)
            //        Situacao = "Final";
            //    else
            //        Situacao = "Aprovado";
            //}
            //cn.Close();
            //cn.Open();
            //cd.CommandText = "Update Matricula set Situacao = " + Situacao + "where idMatricula = " + IdMatricula;
            //cd.Connection = cn;
            //cd.ExecuteNonQuery();

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database =Curso; UID=sa; PWD=123";
            cn.Open();
            SqlCommand ct = new SqlCommand();
            ct.CommandText = $"Select * from Matricula where IdMatricula = {IdMatricula}";
            ct.Connection = cn;
            SqlDataReader dr = ct.ExecuteReader();
            if(dr.Read())
            {
                Nota1 = float.Parse(dr["Nota1"].ToString());
                Nota2 = float.Parse(dr["Nota2"].ToString());
                Global = float.Parse(dr["Global"].ToString());
            }
            cn.Close();
            media = (Nota1 + Nota2 + Global) / 3;
            if (media < 4)
                Situacao = "Reprovado";
            else if (media >= 4 && media < 6)
                Situacao = "Final";
            else
                Situacao = "Aprovado";

            cn.Open();
            ct.CommandText = $"Update Matricula set Situacao = '{Situacao.ToString()}' where idMatricula = '{IdMatricula}'";
            ct.ExecuteNonQuery();
            cn.Close();

        }

        public DataSet PesquisarMatriculaSituacao()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Server = LAPTOP-PG3TNAT4\\SQLEXPRESS;Database =Curso; UID=sa; PWD=123";
            cn.Open();
            string sql = $"Select idMatricula from Matricula where Situacao like '{Situacao.ToString()}'";
            SqlDataAdapter da = new SqlDataAdapter(sql,cn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }


    }
}
