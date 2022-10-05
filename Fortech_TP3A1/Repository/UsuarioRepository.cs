using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class UsuarioRepository : Repository<Usuario>
    {
        public Usuario BuscarPeloId(int id)
        {
            return DbContext.usuario
                .Include(usuario => usuario.enderecos)
                .Include(usuario => usuario.solicitacoes) 
                .FirstOrDefault(x => x.Id == id);
        }

        public List<Usuario> BuscarTodosPeloNome(string nome)
        {
            return DbContext.usuario.Where(usuario => usuario.nome.Contains(nome)).ToList();
        }

        public Usuario Autenticado(string email, string senha)
        {
            return DbContext.usuario.FirstOrDefault(x => x.email == email && x.senha == senha);
        }

        public bool ExistePeloCpf(string cpf)
        {
            var pesquisa = DbContext.usuario.Where(x => x.cpf == cpf).ToList();
            return pesquisa.Any();
        }

        public bool ExistePeloEmail(string email)
        {
            var pesquisa = DbContext.usuario.Where(x => x.email == email).ToList();
            return pesquisa.Any();
        }

        public override List<Usuario> BuscarTodos()
        {
            return DbContext.usuario.Select(x => x).ToList();
        }

        public override void Salvar(Usuario usuario)
        {
            DbContext.usuario.Add(usuario);
            DbContext.SaveChanges();
        }
        
        public override void Atualizar(Usuario usuario)
        {
            DbContext.Entry(usuario).State = EntityState.Modified;
            DbContext.Entry(usuario.solicitacoes).State = EntityState.Added;
            DbContext.SaveChanges();
        }

        public void AlterarAtividade(int id)
        {
            var usuario = DbContext.usuario.First(x => x.Id == id);
            DbContext.Entry(usuario).State = EntityState.Modified;

            if (usuario == null) return;
            usuario.ativo = !usuario.ativo;

            DbContext.SaveChanges();
        }

        public void AlterarPermissao(int id)
        {
            var usuario = DbContext.usuario.First(x => x.Id == id);
            DbContext.Entry(usuario).State = EntityState.Modified;

            if (usuario == null) return;
            usuario.admin = !usuario.admin;

            DbContext.SaveChanges();
        }
    }
}