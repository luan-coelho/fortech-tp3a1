using System;
using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class Eletronico
    {
        [Key] public int Id { get; set; }

        public string nome { get; set; }

        public string modelo { get; set; }

        public string marca { get; set; }

        public string numeroNotaFiscal { get; set; }

        public DateTime dataFabricao { get; set; }

        public string observacoes { get; set; }

        public Eletronico(string nome, string modelo, string marca, string numeroNotaFiscal, DateTime dataFabricao,
            string observacoes)
        {
            this.nome = nome;
            this.modelo = modelo;
            this.marca = marca;
            this.numeroNotaFiscal = numeroNotaFiscal;
            this.dataFabricao = dataFabricao;
            this.observacoes = observacoes;
        }

        public Eletronico()
        {
        }
    }
}