using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortech_TP3A1.Model
{
    public class Endereco
    {
        [Key]
        public int Id { get; set; }
        
        public string cep { get; set; }

        public string rua { get; set; }

        public string numero { get; set; }

        public string bairro { get; set; }

        public string complemento { get; set; }
        
        public string cidade { get; set; }
        
        public string estado { get; set; }
    }
}
