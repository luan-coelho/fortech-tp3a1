using System.Collections.Generic;
using System.Linq;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private readonly FortechContext _db = new FortechContext();

        public Usuario BuscarPeloId(int id)
        {
            var pesquisa = _db.usuario.Where(x => x.Id == id).ToList();
            return pesquisa[0];
        }

        public Usuario Autenticado(string email, string senha)
        {
            var usuario = _db.usuario.Where(x => x.email == email && x.senha == senha).ToList();
            return usuario.Count > 0 ? usuario[0] : null;
        }

        public bool ExistePeloCpf(string cpf)
        {
            var pesquisa = _db.usuario.Where(x => x.cpf == cpf).ToList();
            return pesquisa.Any();
        }

        public bool ExistePeloEmail(string email)
        {
            var pesquisa = _db.usuario.Where(x => x.email == email).ToList();
            return pesquisa.Any();
        }

        public List<Usuario> BuscarTodos()
        {
            return _db.usuario.Select(x => x).ToList();
        }

        public void Salvar(Usuario usuario)
        {
            _db.usuario.Add(usuario);
            _db.SaveChanges();
        }
    }
}