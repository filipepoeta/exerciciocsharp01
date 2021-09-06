
using System.Globalization;
using System.Text;

namespace Exercicio04.Entidades
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public  virtual string tagPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nome} R${Preco.ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
