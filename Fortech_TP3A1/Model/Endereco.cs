using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class Endereco
    {
        [Key]
        public int id { get; set; }
        
        public string cep { get; set; }

        public string rua { get; set; }

        public string numero { get; set; }

        public string bairro { get; set; }

        public string complemento { get; set; }
        
        public string cidade { get; set; }
        
        public string estado { get; set; }
    }
}
