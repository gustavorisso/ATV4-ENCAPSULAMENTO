using System;
using System.Collections.Generic;
using System.Text;

namespace ATV4___Encapsulamento
{
    public class Produto
    {
        private string nome;
        private string descricao;
        private double preco;

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double Preco { get => preco; set => preco = value; }

        public Produto(string nome, string descricao, double preco)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.Preco = preco;
        }
    }
}
