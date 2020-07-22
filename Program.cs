using System;

namespace caixa_troco
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto;
            double valorProduto = 0;

            double valorPagamento = 0;

            double troco = 0;

            bool pagar = true;

            while (pagar || valorProduto > 0)
            {
                Console.WriteLine("Informar valor do Produto R$:");    
                produto = Console.ReadLine();
                if  (produto == "")
                {
                    pagar = false;
                }
                else
                {
                    valorProduto = Convert.ToDouble(produto);
                }
                

                if (valorProduto > 0 )
                {
                    Console.WriteLine("Informar valor do pagamento R$:");
                    valorPagamento = Convert.ToDouble(Console.ReadLine());

                    troco = valorPagamento - valorProduto;
                    Console.WriteLine($"Valor do troco R$: {troco}");
                    valorProduto = 0;
                    valorPagamento = 0;
                }
                else
                {
                    pagar = false;
                }
            }
        }
    }
}
