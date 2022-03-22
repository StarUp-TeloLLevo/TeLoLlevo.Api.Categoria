using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeLoLlevo.Api.Categoria.Modelo;

namespace TeLoLlevo.Api.Categoria.Persistencia
{
    public class CategoriasContexto: DbContext
    {
        public CategoriasContexto(DbContextOptions<CategoriasContexto> options): base(options)
        {

        }

        public DbSet<Categorias> Categorias { get; set; }


    }
}
