using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class SolicitacaoServico
    {
        [Key] public int id { get; set; }

        public string nome { get; set; }

        public string detalhes { get; set; }

        public decimal valor { get; set; }

        public List<Eletronico> eletronico { get; set; }

        public List<TipoServico> tipoServicos { get; set; }
    }
}