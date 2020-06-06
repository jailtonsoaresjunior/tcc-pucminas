using SCA.Compliance.Interface;
using System.Collections.Generic;

namespace SCA.Compliance.Negocio
{
    public class ComplianceNegocio : ICompliance
    {
        public List<string> ObterLista()
        {
            return new List<string> { "Compliance 1", "Compliance 2", "Compliance 3", "Compliance 4" };
        }

    }
}
