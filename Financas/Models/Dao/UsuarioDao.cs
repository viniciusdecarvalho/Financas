using Financas.Models.DataSource;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace Financas.Models.Dao
{
    public class UsuarioDao: IUsuarioDao
    {
        private readonly FinancasContext context;

        public UsuarioDao(FinancasContext context)
        {
            this.context = context;
        }

        public Usuario Get(int id)
        {
            return this.context.Usuarios.Find(id);
        }

        public IEnumerable<Usuario> Listar()
        {
            return this.context.Usuarios.ToList();
        }

        public void Salvar(Usuario usuario)
        {
            this.context.Usuarios.AddOrUpdate(usuario);
        }
    }
}