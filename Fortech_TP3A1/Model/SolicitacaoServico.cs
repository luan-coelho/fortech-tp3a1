using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class SolicitacaoServico
    {
        [Key] public int id { get; set; }

        public string nome { get; set; }

        public string detalhes { get; set; }

        public decimal valor { get; set; }

        public Eletronico eletronico { get; set; }

        public TipoServico tipoServico { get; set; }
        
        public int? Usuario_Id { get; set; }

        public SolicitacaoServico(string nome, string detalhes, decimal valor, Eletronico eletronico,
            TipoServico tipoServico)
        {
            this.nome = nome;
            this.detalhes = detalhes;
            this.valor = valor;
            this.eletronico = eletronico;
            this.tipoServico = tipoServico;
        }

        public SolicitacaoServico()
        {
        }

        public SolicitacaoServico(string nome, string detalhes, decimal valor, Eletronico eletronico, TipoServico tipoServico, int? usuarioId)
        {
            this.nome = nome;
            this.detalhes = detalhes;
            this.valor = valor;
            this.eletronico = eletronico;
            this.tipoServico = tipoServico;
            Usuario_Id = usuarioId;
        }
    }
}