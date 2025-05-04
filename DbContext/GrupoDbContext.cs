using MySql.Data.MySqlClient;
using Mysqlx.Cursor;
using Org.BouncyCastle.Crypto.Digests;
using Rota_LivreWEB_API.Models;


namespace Rota_LivreWEB_API.DbContext
{
    public class GrupoDbContext
    {
        public const string StringDeConexao = "Server=rotalivre.c30u6uc8o0pe.us-east-2.rds.amazonaws.com;Port=3306;Database=rotalivre;Uid=admin;Pwd=$Rotalivre1;";


        public static string Cadastrar_Grupo(Grupo NovoLinkGrupo)
        {
            try
            {
                MySqlConnection conexao = new();
                conexao.ConnectionString = StringDeConexao;
                string query = "INSERT INTO grupo (link_grupo) VALUES (@Novo_link_grupo);";
                MySqlCommand comando = new(query, conexao);
                comando.Parameters.AddWithValue("@Novo_link_grupo", NovoLinkGrupo.link_grupo);
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
