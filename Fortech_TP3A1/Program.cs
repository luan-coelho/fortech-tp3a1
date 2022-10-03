using Fortech_TP3A1.Model;
using System;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Windows.Forms;

namespace Fortech_TP3A1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class FortechContext : DbContext
    {
        public FortechContext() : base("name=ConnectionString")
        {
        }

        public DbSet<Usuario> usuario { get; set; }

        public DbSet<Endereco> endereco { get; set; }

        public DbSet<Eletronico> eletronico { get; set; }

        public DbSet<SolicitacaoServico> solicitacaoServico { get; set; }

        public DbSet<Log> log { get; set; }


        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {
            dbModelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
