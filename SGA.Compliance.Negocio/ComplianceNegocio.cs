using SCA.Compliance.Dados;
using SCA.Compliance.Interface;
using System.Collections.Generic;

namespace SCA.Compliance.Negocio
{
    public class ComplianceNegocio : ICompliance
    {
        private readonly AcessoDados _acessoDados;
        public ComplianceNegocio(AcessoDados acessoDados)
        {
            _acessoDados = acessoDados;
        }
        public List<string> ObterLista()
        {
            return _acessoDados.ObterLista();
        }

    }
}
