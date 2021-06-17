using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ProjetoProdutosNaoPereciveis.Models
{
    public class ProdutosNaoPereciveis
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Insira de 2 a 30 caracteres.")]
        public string Produtos { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(150, MinimumLength = 5, ErrorMessage = "Insira de 5 a 150 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 80, ErrorMessage = "Insira um peso, em kg, de 1 a 80")]
        public int Peso { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Insira de 5 a 100 caracteres")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 750, ErrorMessage = "Insira um valor de 1 a 750R$")]
        public int Valor { get; set; }
    }
}