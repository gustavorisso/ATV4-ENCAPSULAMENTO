using System;
using System.Collections.Generic;
using System.Text;

namespace ATV4___Encapsulamento
{
    public class Restaurante
    {
        private string nome;
        private List<Menu> menus = new List<Menu>();

        public string Nome { get => nome; set => nome = value; }
        public List<Menu> Menus { get => menus; set => menus = value; }

        public Restaurante(string nome)
        {
            this.Nome = nome;
        }
        public void AdicionarMenu(Menu menu)
        {
            Menus.Add(menu);
        }
    }
}
