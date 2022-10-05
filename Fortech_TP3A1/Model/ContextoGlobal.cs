using System.Collections.Generic;

namespace Fortech_TP3A1.Model
{
    public class ContextoGlobal
    {
        public static Usuario usuarioLogado { get; set; }
        public static string cpf { get; set; }
        public static Eletronico eletronico { get; set; }
        public static Usuario usuarioSelecionado { get; set; }
    }
}
