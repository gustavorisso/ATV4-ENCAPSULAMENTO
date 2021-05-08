using System;
using System.Collections.Generic;
using System.Text;

namespace ATV4___Encapsulamento
{
    public class Menu
    {
        private string país;
        internal List<Produto> Produtos { get => produtos; set => produtos = value; }
        public string País { get => país; set => país = value; }

        public List<Produto> produtos = new List<Produto>();

        public Menu(string país)
        {
            this.País = país;
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }
            
    }
}
