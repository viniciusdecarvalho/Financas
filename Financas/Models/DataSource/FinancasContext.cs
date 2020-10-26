using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Financas.Models.DataSource
{
    public class FinancasContext: DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Movimentacao> Movimentacoes { get; set; }

        public FinancasContext(): base("FinancasContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Financas.Models.ViewModel.UsuarioEditViewModel> UsuarioEditViewModels { get; set; }
    }
}