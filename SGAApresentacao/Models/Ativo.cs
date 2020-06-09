using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SCA.Apresentacao.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        public string Descricao { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Data da Compra")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataCompra { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Somente maiores que zero")]
        [Display(Name = "Prazo Manutenção(Meses)")]
        public int MesesManutencao { get; set; }
        [Display(Name = "Categoria")]
        public String CategoriaAtivo { get; set; }
    }
}
