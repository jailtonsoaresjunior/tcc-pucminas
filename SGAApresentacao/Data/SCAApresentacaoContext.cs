using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCA.Apresentacao.Models;
//using SCA.Ativos.Model;

namespace SCA.Apresentacao.Data
{
    public class SCAApresentacaoContext : DbContext
    {
        public SCAApresentacaoContext (DbContextOptions<SCAApresentacaoContext> options)
            : base(options)
        {
        }

        public DbSet<Ativo> Ativo { get; set; }
    }
}
