using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class TipoServicoRepository : Repository<TipoServico>
    {
        public TipoServico BuscarPeloId(int id)
        {
            return DbContext.tipoServicos.FirstOrDefault(x => x.id == id);
        } 
        
        public override List<TipoServico> BuscarTodos()
        {
            return DbContext.tipoServicos.Select(x => x).ToList();
        }

        public override void Salvar(TipoServico objeto)
        {
            DbContext.tipoServicos.Add(objeto);
            DbContext.SaveChanges();
        }

        public override void Atualizar(TipoServico objeto)
        {
            DbContext.Entry(objeto).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}