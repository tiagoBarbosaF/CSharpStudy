using System.Globalization;
namespace Builders

{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() // Builder default
        {
        }

        public Produto(string nome, double preco) : this()// Builder 1
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) // Builder 2
        {
            Quantidade = quantidade;
        }

        public string Nome  // Properties
        {
            get
            {
                return _nome;
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }


        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }


        public override string ToString()
        {
            return _nome
                 + ", $ "
                 + Preco.ToString("F2", CultureInfo.InvariantCulture)
                 + ", "
                 + Quantidade
                 + " unidades, Total: $ "
                 + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
