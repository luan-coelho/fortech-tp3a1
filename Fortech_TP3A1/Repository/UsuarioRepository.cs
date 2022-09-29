using Fortech_TP3A1.Model;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Fortech_TP3A1.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        private FortechContext db = new FortechContext();

        public bool existePeloCpf(string cpf)
        {
            List<Usuario> pesquisa = db.usuario.Where(x => x.cpf == cpf).ToList();
            return pesquisa.Count() > 0;
        }

        public List<Usuario> BuscarTodos()
        {
            return null;
        }

        public void Salvar(Usuario usuario)
        {
            try
            {
                db.usuario.Add(usuario);
                db.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
