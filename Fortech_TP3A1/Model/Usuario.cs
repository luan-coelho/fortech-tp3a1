using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortech_TP3A1.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public DateTime date { get; set; }

        public Endereco endereco { get; set; }

        public List<SolicitacaoServico>  solicitacoes { get; set; }

        public bool admin { get; set; }
    }
}
