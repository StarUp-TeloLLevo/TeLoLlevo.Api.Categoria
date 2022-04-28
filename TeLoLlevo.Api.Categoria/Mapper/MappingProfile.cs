using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Dto;
using TeLoLlevo.Api.Categoria.Modelo;

namespace TeLoLlevo.Api.Categoria.Mapper
{
    /// <summary>
    /// Configuracion de la clase de mapeo  extendiendo su funcionalidad del profile
    /// </summary>
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Categorias, CategoriasDto>().ReverseMap();
        }
    }
}
