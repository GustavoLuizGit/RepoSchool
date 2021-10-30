using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoBrasileirao
{
    class BrasileiraoClass
    {
        private int idTime;
        private string nome;
        private string quantidadeTitulos;
        private string fundacao;
        private string tituloEpico;

        public int IdTime { get => idTime; set => idTime = value; }
        public string Nome { get => nome; set => nome = value; }
        public string QuantidadeTitulos { get => quantidadeTitulos; set => quantidadeTitulos = value; }
        public string Fundacao { get => fundacao; set => fundacao = value; }
        public string TituloEpico { get => tituloEpico; set => tituloEpico = value; }

        private ConexaoSQL objetoConexao = new ConexaoSQL();

        public void Inserir()
        {
            string sql = $"Insert into Times (nome, quantidadeTitulos, fundacao, tituloEpico) values ('{Nome}', '{QuantidadeTitulos}', '{Fundacao}' , '{TituloEpico}')";
            objetoConexao.Executar(sql);
        }

        public void Alterar()
        {
            string sql = "Update Times set quantidadeTitulos = '" + QuantidadeTitulos + "',fundacao = '" + Fundacao + "',tituloEpico = '" + TituloEpico + "'Where idTime =" + idTime.ToString();
            objetoConexao.Executar(sql);
        }

        public void Excluir()
        {
            string sql = $"Delete Times where idTime = {idTime.ToString()}";
            objetoConexao.Executar(sql);
        }

        public void ConsultarDados()
        {
            string sql = $"Select *from Times where idTime = {idTime}";
            objetoConexao.Consultar(sql);

            if (objetoConexao.dr.Read())
            {
                quantidadeTitulos = objetoConexao.dr["quantidadeTitulos"].ToString();
                fundacao = objetoConexao.dr["fundacao"].ToString();
                tituloEpico = objetoConexao.dr["tituloEpico"].ToString();
            }
            objetoConexao.Desconectar();
        }

        public DataSet ListarDados()
        {
            string sql = "Select * from Times";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }

        public DataSet ListarDadosPorNome()
        {
            string sql = $"Select * from Times where nome LIKE '{Nome}%' ";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }

        public DataSet ListarDadosPorFundacao()
        {
            string sql = $"Select * from Times where fundacao LIKE '{fundacao}%' ";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }
    }
}
