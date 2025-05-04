namespace Rota_LivreWEB_API.Models
{
    public class Grupo
    {

        public int id_grupo { get; set; }
        public string link_grupo { get; set; }
       // public Guid id_passeio {  get; set; }

        public Grupo( string Novo_link_grupo)
        {
           link_grupo = Novo_link_grupo;
           
        }
    }
}
