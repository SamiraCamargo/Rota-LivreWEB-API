namespace Rota_LivreWEB_API.Models
{
    public class Avaliacao
    {
        public Guid id_avalicao {  get; set; }
        // TODO: Verificar com o grupo se a propriedade nota vai ser  do tipo double ou string
        public double nota {  get; set; }
        public string feedback { get; set; }

        public static void primeiro_metodo()
        {
            
        }
    }
}
