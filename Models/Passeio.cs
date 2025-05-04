namespace Rota_LivreWEB_API.Models
{
    public class Passeio
    {
        public Guid id_passeio {  get; set; }
        public Guid id_categoria { get; set; }
        public Guid id_localização   { get; set; }
        public Guid grupo_id { get; set; }
        public DateTime dataHora_ida { get; set; }
        public DateTime dataHora_volta { get; set; }
        public string endereco {  get; set; }   
        public Guid id_grupo { get; set; }

    }
}
