using System;
using System.Collections.Generic;
using System.Text;

namespace SCA.Ativos.Modelo
{
    public class Ativo
    {
        public int Id { get; set; }
        
        public string Descricao { get; set; }

        public String CategoriaAtivo { get; set; }

        public DateTime DataCompra { get; set; }
        public int MesesManutencao { get; set; }
    }
}
