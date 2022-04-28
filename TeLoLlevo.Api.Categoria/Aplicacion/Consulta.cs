using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Dto;
using TeLoLlevo.Api.Categoria.Modelo;
using TeLoLlevo.Api.Categoria.Persistencia;

namespace TeLoLlevo.Api.Categoria.Aplicacion
{
    /// <summary>
    /// clase que s eencarga de consultar un dato de un microservicio
    /// </summary>
    public class Consulta
    {
        public class Ejecuta : IRequest<List<CategoriasDto>> { 
            //no se reciben parametros
        }
        public class Manejador : IRequestHandler<Ejecuta, List<CategoriasDto>>
        {
            private readonly CategoriasContexto _contexto;
            private readonly IMapper _mapper;
            /// <summary>
            /// se inyectan las dependencias dentro del constructor
            /// </summary>
            /// <param name="contexto">se inyecta la clase de contexto</param>
            /// <param name="mapper">se inyecta la clase del mapeo</param>
            public Manejador(CategoriasContexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public async Task<List<CategoriasDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var categorias = await _contexto.Categorias.ToListAsync();
                var  categoriasDto= _mapper.Map<List<Categorias>, List<CategoriasDto>>(categorias);
                return categoriasDto;

            }
        }
    }
}
