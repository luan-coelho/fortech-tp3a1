using System;
using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class Log
    {
        [Key] public int id { get; set; }

        public DateTime dataHora { get; set; }

        public string descricao { get; set; }

        public int idUsuario { get; set; }

        public Log(DateTime dataHora, string descricao, int idUsuario)
        {
            this.dataHora = dataHora;
            this.descricao = descricao;
            this.idUsuario = idUsuario;
        }
    }
}