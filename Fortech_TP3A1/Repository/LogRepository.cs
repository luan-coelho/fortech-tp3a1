using System;
using System.Collections.Generic;
using System.Linq;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Repository
{
    public class LogRepository
    {
        private readonly FortechContext _dbContext = new FortechContext();
        
        public List<Log> BuscarTodos()
        {
            return _dbContext.log.Select(x => x).ToList();
        }

        public void Salvar(string descricao)
        {
            var log = new Log(DateTime.Now, descricao, 1);
            _dbContext.log.Add(log);
            _dbContext.SaveChanges();
        }
    }
}