using Dapper;
using ProvaSQL_ASPNETMVC.Models;
using System.Data.SqlClient;

namespace ProvaSQL_ASPNETMVC.DAL
{
    public class DocumentoJuizDAO
    {
        private SqlConnection _conexao;
        public DocumentoJuizDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }
        public List<DocumentoJuiz> getTodosDocumentoJuiz()
        {
            string sql = "select * from DocumentoJuiz";
            var dados = (List<DocumentoJuiz>)_conexao.Query<DocumentoJuiz>(sql);
            return dados;
        }
    }
}
