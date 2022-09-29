using System.Collections.Generic;

namespace Fortech_TP3A1.Repository
{
    public interface Repository <T>
    {
        List <T> BuscarTodos();
        void Salvar(T objeto);
    }
}
