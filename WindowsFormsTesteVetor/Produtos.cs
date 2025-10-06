using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsTesteVetor
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
        }

        private List<string> _produtos = new List<string>();
        ArrayList itens = new ArrayList();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


            string produtos = tbxProdutos.Text.Trim();
            if (produtos != "") 
            {
                _produtos.Add(produtos); 
                MessageBox.Show($"O produto {produtos} foi adicionado. ", "Adição de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxProdutos.Clear();
                tbxProdutos.Focus(); //btnProdutos
                lbxQuantidade.Items.Clear();
                lbxQuantidade.Items.Add(_produtos.Count.ToString());

            }
            else
            {
                MessageBox.Show($"Campo Vazio, precisa preencher a caixa de texto ", "Campo Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbxProdutos.Items.Clear();
           

            if (_produtos.Count > 0)
            {
                foreach (string p in _produtos) 
                    lbxProdutos.Items.Add(p);
                  
            }
            else
            {
                MessageBox.Show(" Nenhum produto cadastrado. ");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lbxProdutos.SelectedItem != null)
            {
                string produto = lbxProdutos.SelectedItem.ToString();
                _produtos.Remove(produto); 
                lbxProdutos.Items.Remove(produto); 
                MessageBox.Show($"O produto {produto} foi removido. ", "Remoção de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Selecione um item da caixa de Lista para Remover", "Remoção de Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuantidade_Click(object sender, EventArgs e)
        {

            lbxQuantidade.Items.Clear();

            int quantidadeProdutos = _produtos.Count;


            if (quantidadeProdutos > 0)
            {
                    lbxQuantidade.Items.Add(quantidadeProdutos);

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
                                    
            }

        }
    }
}
