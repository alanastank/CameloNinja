﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CameloNinja.Models
{
    public class PedidoModel
    {
        [Required(ErrorMessage = "Data de Entrega deve ser informada")]
        [DisplayName("Data desejada de entrega")]
        public DateTime DataDesejoEntrega { get; set; }

        [Required(ErrorMessage = "Nome do Produto deve ser informado")]
        [DisplayName("Nome do Produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "Valor de venda deve ser informado")]
        [DisplayName("Valor de Venda")]
        public float ValorDeVenda { get; set; }

        [Required]
        [DisplayName("Tipo de Pagamento")]
        public string TipoDePagamento { get; set; }

        [Required(ErrorMessage = "Nome do Cliente deve ser informado")]
        [DisplayName("Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Cidade deve ser informada")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Estado deve ser informado")]
        public string Estado { get; set; }
    }
}