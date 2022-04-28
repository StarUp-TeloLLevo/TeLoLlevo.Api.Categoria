using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeLoLlevo.Api.Categoria.Dto
{
    /// <summary>
    /// Configuracion de la clase Dto de categorias
    /// </summary>
    public class CategoriasDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsMaster { get; set; }

        public string FkCategory { get; set; }

    }
}
