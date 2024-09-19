namespace CalculadoraDePedido
{
  class Program
{
static void Main(string[] args)
 {
   Func<int, decimal, decimal, decimal, decimal> calcularValorTotal = (quantidade, precoUnitario, frete, desconto) =>
            {
 decimal valorItens = quantidade * precoUnitario;
 decimal valorTotal = valorItens + frete - desconto;
   return valorTotal < 0 ? 0 : valorTotal;
  };
 int quantidadeItens = 10;        
   decimal precoUnitario = 77.00m; 
   decimal frete = 17.00m;         
   decimal desconto = 27.00m;      

     decimal valorTotalPedido = calcularValorTotal(quantidadeItens, precoUnitario, frete, desconto);
 Console.WriteLine($"Quantidade de Itens: {quantidadeItens}");
 Console.WriteLine($"Preço Unitário: R$ {precoUnitario:F2}");
 Console.WriteLine($"Frete: R$ {frete:F2}");
 Console.WriteLine($"Desconto: R$ {desconto:F2}");
 Console.WriteLine($"Valor Total do Pedido: R$ {valorTotalPedido:F2}");
 Console.ReadLine();
    }
  }
}
