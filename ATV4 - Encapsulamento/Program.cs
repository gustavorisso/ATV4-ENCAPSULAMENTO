using System;

namespace ATV4___Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto CarneQueijo = new Produto("X-Carne e Queijo", "Queijo da melhor qualidade, símples mas suculento!", 7.50);
            Produto XLaboratorio = new Produto("X-Laboratorio", "Para os corajosos de plantão, todos os ingrdientes juntos!!", 25.90);
            Produto Frango = new Produto("X-Frango", "O clássico mais pedido!", 6.50);
            Produto Salada = new Produto("X-Salada", "Pra você que está de dieta mas não resiste a um lanchinho", 6.90);
            Produto Peixe = new Produto("X-Fish", "For you who like fish", 9.90);
            Produto Cheddar = new Produto("Cheddar", "The classic cheddar, enjoy our best lunch", 11.90);
            Produto Bacon = new Produto("Bacon", "Suculent bacon, the most searched!", 12.60);
            Produto Choripán = new Produto("Choripán", "Hot dog argentino, con salsas especiales", 12.90);

            Menu menuBR = new Menu("Brasil");
            Menu menuJP = new Menu("Japão");
            Menu menuEUA = new Menu("EUA");
            Menu menuARG = new Menu("Argentina");

            menuBR.AdicionarProduto(CarneQueijo);
            menuBR.AdicionarProduto(XLaboratorio);
            menuBR.AdicionarProduto(Frango);
            menuBR.AdicionarProduto(Salada);

            menuARG.AdicionarProduto(Choripán);
            menuARG.AdicionarProduto(Cheddar);
            menuARG.AdicionarProduto(Salada);

            menuEUA.AdicionarProduto(Cheddar);
            menuEUA.AdicionarProduto(Choripán);
            menuEUA.AdicionarProduto(Bacon);

            menuJP.AdicionarProduto(Cheddar);
            menuJP.AdicionarProduto(Peixe);

            Restaurante MammaMia = new Restaurante("Mamma-Mia");

            MammaMia.AdicionarMenu(menuBR);
            MammaMia.AdicionarMenu(menuARG);
            MammaMia.AdicionarMenu(menuEUA);
            MammaMia.AdicionarMenu(menuJP);
            
            
            

            int cont = 1;

            string paisSelecionado = "";

            SelecionarPais();

            void SelecionarPais()
            {
                int pais = 0;

                Console.WriteLine("Selecione o cardápio de qual pais você deseja acessar");
                Console.WriteLine("");
                Console.WriteLine("1 = Brasil");
                Console.WriteLine("2 = Argentina");
                Console.WriteLine("3 = EUA");
                Console.WriteLine("4 = Japão");
                Console.WriteLine("5 = Todos");
                Console.WriteLine("");
                Console.Write("Selecione:");
                pais = int.Parse(Console.ReadLine());

                if (pais == 1)
                {
                    paisSelecionado = "Brasil";
                }
                else if (pais == 2)
                {
                    paisSelecionado = "Argentina";
                }
                else if (pais == 3)
                {
                    paisSelecionado = "EUA";
                }
                else if (pais == 4)
                {
                    paisSelecionado = "Japão";
                }                              
                else if (pais == 5)
                {
                    paisSelecionado = "Todos";
                }
                else
                {
                    Console.WriteLine("País inválido");
                }
            }


            foreach (Menu menu in MammaMia.Menus)
            {
                if (paisSelecionado == "Todos")
                {
                    Console.WriteLine("Cardapio #" + cont);
                    Console.WriteLine("País: " + menu.País);
                    Console.WriteLine("Produtos: ");

                    foreach (Produto produto in menu.Produtos)
                    {
                        Console.WriteLine("    Nome: " + produto.Nome);
                        Console.WriteLine("    Descrição: " + produto.Descricao);
                        Console.WriteLine("    Preço: " + produto.Preco);
                        Console.WriteLine("");
                    }
                }
                else if (menu.País == paisSelecionado)
                {
                    Console.WriteLine("Cardapio #" + cont);
                    Console.WriteLine("País: " + menu.País);
                    Console.WriteLine("Produtos: ");

                    foreach (Produto produto in menu.Produtos)
                    {
                        Console.WriteLine("    Nome: " + produto.Nome);
                        Console.WriteLine("    Descrição: " + produto.Descricao);
                        Console.WriteLine("    Preço: " + produto.Preco);
                        Console.WriteLine("");
                    }
                }
                cont++;
            }
        }
    }
}

