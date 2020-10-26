using AutoMapper;
using Financas.Models.DataSource;
using Financas.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.Models.Mapper
{
    public static class MapperExtensions
    {
        private static IMapper mapper = new MapperConfiguration(cfg => {
            cfg.CreateMap<Usuario, UsuarioEditViewModel>();
            cfg.CreateMap<UsuarioEditViewModel, Usuario>();
        })
        .CreateMapper();

        public static TOut Convert<TIn, TOut>(this TIn input) where TIn: class
        {
            return mapper.Map<TOut>(input);
        }
    }
}