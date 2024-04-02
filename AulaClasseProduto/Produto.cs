using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasseProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quant;

        public double ValorTotalEstoque() 
        {
            return Preco * Quant; 
        }

        public void addProduto(int quantidade)
        {
            Quant = Quant + quantidade;
        }

        public void removerProduto(int quantidade)
        {
            Quant -= quantidade;
        }

        public override string ToString()
        {
            return Nome 
                + ", $ " 
                + Preco.ToString("F2")
                +", "
                + Quant
                + " Unidades, total: $ "
                + ValorTotalEstoque().ToString("F2");
        }

    }
}
