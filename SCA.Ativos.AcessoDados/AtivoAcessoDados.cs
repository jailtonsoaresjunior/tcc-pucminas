//using System.Runtime.Caching;

using SCA.Ativos.Modelo.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SCA.Ativos.Modelo;

namespace SCA.Ativos.AcessoDados
{
    public class AtivoAcessoDados : IAtivoInterface
    {

        private DbContextOptions<AtivosContext> _options = new DbContextOptionsBuilder<AtivosContext>().Options;

        private List<Ativo> _listaAtivos;
       
      
        public List<Ativo> ObterLista()
        {
           

            using (var contexto = new AtivosContext(_options))
            {
                return contexto.Ativos.ToList();
            }
            
        }

        public void Inserir(Ativo ativo)
        {
            using (var contexto = new AtivosContext(_options))
            {
                contexto.Add(ativo);
                contexto.SaveChanges();
            }
        }

        public void Excluir(int id)
        {
            using (var contexto = new AtivosContext(_options))
            {
                Ativo ativo = new Ativo() { Id = id };

                contexto.Ativos.Remove(ativo);
                contexto.SaveChanges();
            }
        }
    }
}
