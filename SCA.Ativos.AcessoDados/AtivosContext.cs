using Microsoft.EntityFrameworkCore;
using SCA.Ativos.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Ativos.AcessoDados
{
    class AtivosContext : DbContext
    {
        //public AtivosContext(DbContextOptions<AtivosContext> options) : base(options)
        public AtivosContext(DbContextOptions<AtivosContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("Ativos");
        }
        public DbSet<Ativo> Ativos{ get; set; }
        public DbSet<CategoraAtivo> CategoriasAtivo { get; set; }
    }
}
