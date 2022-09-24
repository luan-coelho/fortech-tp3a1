using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortech_TP3A1.Model
{
    public class SolicitacaoServico
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string detalhes { get; set; }

        public decimal valor { get; set; }

        public Eletronico eletronico { get; set; }

    }
}
