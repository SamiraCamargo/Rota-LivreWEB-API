namespace Rota_LivreWEB_API.Models
{
    public class Categoria
    {
        public int id_categoria {  get; set; }
        public string tipo_categoria { get; set; }


        public Categoria(string Novo_tipo_Categoria) 
        {
          tipo_categoria = Novo_tipo_Categoria;
           
        }
    }
}
