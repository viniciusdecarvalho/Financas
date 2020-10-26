using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;

namespace Financas.Models.ViewModel
{
    public class UsuarioEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string Nome { get; set; }

        [Required, EmailAddress]
        [StringLength(255)]
        public string Email { get; set; }
    }
}