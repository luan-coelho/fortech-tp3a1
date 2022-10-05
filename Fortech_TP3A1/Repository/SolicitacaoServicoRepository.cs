using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class SolicitacaoServicoRepository : Repository<SolicitacaoServico>
    {
        public override List<SolicitacaoServico> BuscarTodos()
        {
            return DbContext.solicitacaoServico.Select(x => x).ToList();
        }

        public override void Salvar(SolicitacaoServico objeto)
        {
            DbContext.solicitacaoServico.Add(objeto);
            DbContext.SaveChanges();
        }

        public override void Atualizar(SolicitacaoServico objeto)
        {
            DbContext.Entry(objeto).State = EntityState.Modified;
            DbContext.SaveChanges();
        }
    }
}