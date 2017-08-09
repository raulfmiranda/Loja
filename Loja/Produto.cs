using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Produto
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string Descricao { get; set; }
        public string ImgSource { get; set; }

        public Produto(string nome, decimal valor, string descricao, string imgSource)
        {
            this.Nome = nome;
            this.Valor = valor;
            this.Descricao = descricao;
            this.ImgSource = imgSource;
        }
    }
}
