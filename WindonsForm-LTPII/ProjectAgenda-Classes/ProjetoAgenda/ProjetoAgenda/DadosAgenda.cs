using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProjetoAgenda
{
    class DadosAgenda
    {
        private int codigo;
        private string nome;
        private string telefone;
        private string cidade;
        private byte[] foto;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public byte[] Foto { get => foto; set => foto = value; }

        private ConexaoDados objetoConexao = new ConexaoDados();
        public void Inserir()
        {
            string sql = $"Insert into DadosAgenda (Nome, Telefone, Cidade, foto) values ('{Nome}', '{Telefone}', '{Cidade}' , @BINARIO)";
            objetoConexao.Executar(sql,foto);
        }

        public void Alterar()
        {
            string sql = $"Update DadosAgenda set Telefone = '{Telefone}',Cidade = '{Cidade}', Foto = @Binario Where Codigo =" + Codigo.ToString();
            objetoConexao.Executar(sql, foto);
        }

        public void Excluir()
        {
            string sql = $"Delete DadosAgenda where codigo = {Codigo.ToString()}";
            objetoConexao.Executar(sql, foto);
        }

        public void ConsultarDados()
        {
            string sql = $"Select * from DadosAgenda where Codigo = {Codigo}";
            objetoConexao.Consultar(sql);

            if (objetoConexao.dr.Read())
            {
                Telefone = objetoConexao.dr["Telefone"].ToString();
                Cidade = objetoConexao.dr["Cidade"].ToString();
                Foto = (byte[])objetoConexao.dr["foto"];
            }
            objetoConexao.Desconectar();
        }

        public DataSet ListarDados()
        {
            string sql = "Select * from DadosAgenda";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }

        public DataSet ListarDadosPorNome()
        {
            string sql = $"Select * from DadosAgenda where Nome LIKE '{Nome}%' ";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }

        public DataSet ListarDadosPorCidade()
        {
            string sql = $"Select * from DadosAgenda where Cidade LIKE '{Cidade}%' ";
            objetoConexao.Listar(sql);
            return objetoConexao.ds;
        }


    }
}
