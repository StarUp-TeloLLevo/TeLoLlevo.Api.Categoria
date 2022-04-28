using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Dto;
using TeLoLlevo.Api.Categoria.Persistencia;

namespace TeLoLlevo.Api.Categoria.Aplicacion
{
    public class Consulta
    {
        public class Ejecuta : IRequest<List<CategoriasDto>> { 

        }
        public class Manejador : IRequestHandler<Ejecuta, List<CategoriasDto>>
        {
            private readonly CategoriasContexto _contexto;
            private readonly IMapper _mapper;
            public Manejador(CategoriasContexto contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }

            public Task<List<CategoriasDto>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                
            }
        }
    }
}
