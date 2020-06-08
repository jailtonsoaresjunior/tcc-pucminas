using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Ativos.Modelo
{
    public class Ativo
    {
        public int Id { get; set; }
        
        public string Descricao { get; set; }

        public CategoraAtivo CategoriaAtivo { get; set; }
    }
}
