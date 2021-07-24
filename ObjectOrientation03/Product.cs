using System;
namespace ObjectOrientation03
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;

        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                 + ", $ "
                 + Price.ToString("F2")
                 + ", "
                 + Quantity
                 + " unidades, Total: $ "
                 + ValorTotalEmEstoque().ToString("F2");
        }
    }
}
