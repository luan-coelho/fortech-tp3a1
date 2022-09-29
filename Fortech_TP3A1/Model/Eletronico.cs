﻿using System.ComponentModel.DataAnnotations;

namespace Fortech_TP3A1.Model
{
    public class Eletronico
    {
        [Key]
        public int Id { get; set; }

        public string nome { get; set; }
        
        public string modelo { get; set; }
        
        public string marca { get; set; }
        
        public string numeroNotaFiscal { get; set; }
        
        public string dataFabricao { get; set; }
        
        public string detalhes { get; set; }
        
        public string observacoes { get; set; }
    }
}
