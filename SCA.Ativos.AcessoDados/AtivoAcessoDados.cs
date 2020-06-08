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
        public AtivoAcessoDados()
        {
            //    var cache = _memoryCache.Get("Lista");
            //    _listaAtivos = cache == null ? new List<Ativo>() : (List<Ativo>)cache;
        }
        //public AtivoDados(MemoryCache memoryCache)
        //{
        //    _memoryCache = memoryCache;
        //}
        public List<Ativo> ObterLista()
        {
           

            using (var contexto = new AtivosContext(_options))
            {
                return contexto.Ativos.ToList();
            }
            //var lista =_memoryCache.Get("Lista");
            //if (lista == null)
            //{
            //    return new List<Ativo>();
            //}
            //else
            //{
            //    return (List<Ativo>)lista;
            //}
            //return new List<Ativo>();
        }

        public void Inserir(Ativo ativo)
        {
            using (var contexto = new AtivosContext(_options))
            {
                contexto.Add(ativo);
                contexto.SaveChanges();
            }
            //_listaAtivos.Add(ativo);
            //_memoryCache.Remove("Lista");
            //_memoryCache.AddOrGetExisting("Lista", _listaAtivos, politicaCache);
        }
    }
}
