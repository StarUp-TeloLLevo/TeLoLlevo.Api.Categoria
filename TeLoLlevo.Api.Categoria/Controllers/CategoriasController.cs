using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Aplicacion;
using TeLoLlevo.Api.Categoria.Dto;

namespace TeLoLlevo.Api.Categoria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        /// <summary>
        /// Este metodo se encarga de generar el metodo de consultar dentro de un controlador
        /// </summary>
        /// <returns>regresa una tarea o una lista de categorias</returns>
        [HttpGet]
        public async Task<ActionResult<List<CategoriasDto>>> Consultar()
        {
            ///regresamos un mediator como metodo async en su llamada a la clase consulta a traves del manejdor de la clase
            return await _mediator.Send( new Consulta.Ejecuta() );
        }
    }
}
