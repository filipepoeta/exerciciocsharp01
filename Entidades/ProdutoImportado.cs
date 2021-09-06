using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double preco, double taxaImportacao):base(nome,preco)
        {
            TaxaImportacao = taxaImportacao;

        }
        public double precoTotal()
        {
            return Preco + TaxaImportacao;
        }


        public override string tagPreco()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nome} R${precoTotal().ToString("F2", CultureInfo.InvariantCulture)} " +
                $"(Taxa de Importação: R${TaxaImportacao})");
            return sb.ToString();
        }
    }

}
