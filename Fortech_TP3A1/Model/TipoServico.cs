using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class TipoServico
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }
    }
}