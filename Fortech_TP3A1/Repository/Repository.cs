using System.Collections.Generic;

namespace Fortech_TP3A1.Repository
{
    public abstract class Repository<T>
    {
        protected FortechContext DbContext = new FortechContext();

        public abstract List<T> BuscarTodos();

        public abstract void Salvar(T objeto);
        
        public abstract void Atualizar(T objeto);
    }
}