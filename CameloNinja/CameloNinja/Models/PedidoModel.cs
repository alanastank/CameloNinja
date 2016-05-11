using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CameloNinja.Models
{
    public class PedidoModel
    {
        public DateTime DataDesejoEntrega { get; set; }
        public string NomeProduto { get; set; }
        public int ValorDeVenda { get; set; }
        public string TipoDePagamento { get; set; }
        public string NomeCliente { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}