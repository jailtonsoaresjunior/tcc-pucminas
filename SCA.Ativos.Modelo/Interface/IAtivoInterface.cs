using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Ativos.Modelo.Interface
{
    public interface IAtivoInterface
    {
        void Inserir(Ativo ativo);
        List<Ativo> ObterLista();
    }
}
