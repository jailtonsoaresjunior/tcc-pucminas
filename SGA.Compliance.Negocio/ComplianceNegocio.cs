using SCA.Compliance.Dados;
using SCA.Compliance.Modelo.Interfarce;
using System.Collections.Generic;

namespace SCA.Compliance.RegraNegocio
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
