using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using Rota_LivreWEB_API.Models;

namespace Rota_LivreWEB_API.DbContext
{
    public class UsuarioDbContext
    {
        private const string StringDeConexao = "Server=rotalivre.c30u6uc8o0pe.us-east-2.rds.amazonaws.com;Port=3306;Database=rotalivre;Uid=admin;Pwd=$Rotalivre1;";

        public static string Cadastra_Usuario(Usuario NovoUsuario)
        {
            try
            {
                MySqlConnection conexao = new();
                conexao.ConnectionString = StringDeConexao;
                string query = "INSERT INTO usuario (nome_completo, data_nasc, email, senha) VALUES (@Novo_Usuario_Nome, @Novo_Usuario_Nasc, @Novo_Usuario_Email, @Novo_Usuario_Senha);";
                MySqlCommand comando = new(query, conexao);

                comando.Parameters.AddWithValue("@Novo_Usuario_Nome", NovoUsuario.nome_completo);
                comando.Parameters.AddWithValue("@Novo_Usuario_Nasc", NovoUsuario.data_nasc);
                comando.Parameters.AddWithValue("@Novo_Usuario_Email", NovoUsuario.email);
                comando.Parameters.AddWithValue("@Novo_Usuario_Senha", NovoUsuario.senha);
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
        public static string Alterar_senha(int id_usuario, string Velha_senha, string Nova_senha)
        {
            try
            {
                MySqlConnection conexao = new();
                conexao.ConnectionString = StringDeConexao;
                string query = "UPDATE usuario SET senha = @Nova_senha WHERE id_usuario = @id_usuario;";
                MySqlCommand comando = new(query, conexao);
                comando.Parameters.AddWithValue("@id_usuario", id_usuario);
                comando.Parameters.AddWithValue("@Nova_senha", Nova_senha);
                conexao.Open();
                comando.ExecuteNonQuery();
                conexao.Close();
                return "Sucesso na senha";
            }
            catch (Exception)
            {

                return "Deu Ruim na senha";
            }
        }

    }
}
