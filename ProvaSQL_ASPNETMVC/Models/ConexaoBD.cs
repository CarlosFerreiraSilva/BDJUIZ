using System.Data.SqlClient;

namespace ProvaSQL_ASPNETMVC.Models
{
    public class ConexaoBD
    {
        private static SqlConnection Banco;
        public static SqlConnection getConexao()
        {
            if (Banco == null)
            {
                Banco = new SqlConnection(@"Server=.\SENAI2022; Database=BDJUIZ; User id =sa; Password=senai.123;");
            }

            return Banco;
        }
    }
}
