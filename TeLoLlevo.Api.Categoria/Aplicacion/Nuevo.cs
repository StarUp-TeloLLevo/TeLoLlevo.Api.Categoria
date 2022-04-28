using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Modelo;
using TeLoLlevo.Api.Categoria.Persistencia;

namespace TeLoLlevo.Api.Categoria.Aplicacion
{
    /// <summary>
    /// clase que s eecarga de insetar un nuevo elemento o entidad en el microservicio
    /// </summary>
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
            //atributo de contexto con ef
            private readonly CategoriasContexto _contexto;
            public Manejador(CategoriasContexto contexto)
            {
                //inyeccion de la clase de contexto
                _contexto = contexto;
            }

            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var Categoria = new Categorias {
                    Name = request.Name,
                    Description = request.Description,
                    IsMaster= request.IsMaster, 
                    FkCategory = request.FkCategory
                   
                };
                _contexto.Add(Categoria);
                var result= await _contexto.SaveChangesAsync();
                if (result > 0)
                {
                    return Unit.Value; 

                }
                throw new Exception("No se pudo insertar la categoria");
            }
        }


    }
}
