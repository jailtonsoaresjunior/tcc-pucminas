using SCA.Ativos.AcessoDados;
using SCA.Ativos.Modelo;
using SCA.Ativos.Modelo.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Ativos.Negocio
{
    public class AtivoRegraNegocio : IAtivoInterface
    {
        private IAtivoInterface _ativoDados = new AtivoAcessoDados();
        //public AtivoNegocio(IAtivoInterface ativoDados)
        //{
        //    _ativoDados = ativoDados;
        //}
        public List<Ativo> ObterLista()
        {
            return _ativoDados.ObterLista();
        }

        public void Inserir(Ativo ativo)
        {
            _ativoDados.Inserir(ativo);
        }
    }
}
