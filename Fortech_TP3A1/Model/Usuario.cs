using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class Usuario
    {
        public Usuario() { }

        public Usuario(string nome, string email, string senha, bool admin, bool ativo)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.admin = admin;
            this.ativo = ativo;
        }

        public Usuario(string nome, string email, string senha, string cpf, string rg, string cnpj, DateTime dataNascimento, bool ativo)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.cpf = cpf;
            this.rg = rg;
            this.cnpj = cnpj;
            this.dataNascimento = dataNascimento;
            this.ativo = ativo;
        }

        [Key]
        public int Id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }

        public string cpf { get; set; }

        public string rg { get; set; }

        public string cnpj { get; set; }

        public DateTime dataNascimento { get; set; }

        public List<Endereco> enderecos { get; set; }

        public List<SolicitacaoServico>  solicitacoes { get; set; }

        public bool admin { get; set; }

        public bool ativo { get; set; }
    }
}
