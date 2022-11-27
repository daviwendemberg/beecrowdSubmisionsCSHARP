using System; 
using System.Globalization;
using System.Collections.Generic;
class URI {

    static void Main(string[] args) {

        //https://www.beecrowd.com.br/judge/pt/problems/view/1038

        List<Produto> produtos = new List<Produto>();
        produtos.Add(new Produto { Nome = "Cachorro quente", Valor = 4.00M });
        produtos.Add(new Produto { Nome = "Cachorro quente", Valor = 4.00M });
        produtos.Add(new Produto { Nome = "X-Salado", Valor = 4.50M });
        produtos.Add(new Produto { Nome = "X-Bacon", Valor = 5.00M });
        produtos.Add(new Produto { Nome = "Torrada simples", Valor = 2.00M });
        produtos.Add(new Produto { Nome = "Refrigerante", Valor = 1.50M });

        string pedido = Console.ReadLine();
        string[] pedidoTratado = pedido.Split(" ");
        int produtoPedido = Convert.ToInt32(pedidoTratado[0]);
        int calculoProduto = Convert.ToInt32(pedidoTratado[1]);
        decimal valorDoProduto = produtos[produtoPedido].Valor * calculoProduto;
        
        System.Console.WriteLine($"Total: R$ {valorDoProduto.ToString(CultureInfo.InvariantCulture)}");
        Console.ReadKey();
    }

    class Produto
    {

        public string Nome { get; set; }
        public decimal Valor { get; set; }

        
    }

}