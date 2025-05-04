using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Crypto.Digests;
using Rota_LivreWEB_API.Models;

namespace Rota_LivreWEB_API.DbContext
{
    public class CategoriaDbContext
    {
        private const string StringDeConexao = "Server=rotalivre.c30u6uc8o0pe.us-east-2.rds.amazonaws.com;Port=3306;Database=rotalivre;Uid=admin;Pwd=$Rotalivre1;";

        public static string Escolher_Categoria (Categoria NovaCategoria)
        {
            try
            {
                MySqlConnection conexao = new();
                conexao.ConnectionString = StringDeConexao;
                string query = "SELECT * FROM categoria WHERE tipo_categoria = @Nova_Categoria";
                MySqlCommand comando = new MySqlCommand(query, conexao);
                comando.Parameters.AddWithValue("@Nova_Categoria", NovaCategoria.tipo_categoria);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                return "Sucesso";
            }
            catch (Exception)
            {
                 return "Falha";
            }
        
        }
    }
}
