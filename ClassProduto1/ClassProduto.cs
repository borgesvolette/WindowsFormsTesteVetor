using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProduto

{
    public class ClassProduto1

    {
        private List<int> _quantidade = new List<int>();
        private List<string> _produtos = new List<string>();

        public string Produtos { get; set; }
        public string ListaProdutos { get; set; }

        public ClassProduto1(string produtos, string listaProdutos)
        {
            this.Produtos = produtos;
            this.ListaProdutos = listaProdutos;
        }

        public string MostrarProduto(string produto) 
        {
            return produto;
        } 

        public void Adicionar( string produtos)
        {
            _produtos.Add(produtos);
        }

        public void Remover(string produtos)
        {
            _produtos.Remove(produtos);

        }
        private List<string> ListarTodos() =>

          new List<string>(_produtos);

        public void Quantidade(string produtos) 
        
        {
            List<int> _quantidade = new List<int>();

        }

            

    }
}
