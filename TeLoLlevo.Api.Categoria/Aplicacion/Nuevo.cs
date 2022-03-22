using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TeLoLlevo.Api.Categoria.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta: IRequest
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public bool IsMaster { get; set; }
            public string FkCategory { get; set; }
        }
        public class Manejador : IRequestHandler<Ejecuta>
        {
            public Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }


    }
}
