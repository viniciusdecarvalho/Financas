using Financas.Models.DataSource;
using System.Collections.Generic;

namespace Financas.Models.Dao
{
    public interface IUsuarioDao
    {
        IEnumerable<Usuario> Listar();

        void Salvar(Usuario usuario);
        Usuario Get(int id);
    }
}