using Financas.Models.Dao;
using Financas.Models.DataSource;
using Financas.Models.Mapper;
using Financas.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Financas.Controllers
{
    public class UsuariosController : Controller
    {
        IUsuarioDao usuarioDao = new UsuarioDao(new FinancasContext());

        // GET: Usuarios
        public ActionResult Index()
        {
            var usuarios = usuarioDao.Listar();

            return View(usuarios);
        }

        public ActionResult Edit(int id)
        {
            var usuario = this.usuarioDao.Get(id) ?? new Usuario();

            var model = usuario.Convert<Usuario, UsuarioEditViewModel>();

            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(UsuarioEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Usuario usuario = model.Convert<UsuarioEditViewModel, Usuario>();

                this.usuarioDao.Salvar(usuario);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
    }
}