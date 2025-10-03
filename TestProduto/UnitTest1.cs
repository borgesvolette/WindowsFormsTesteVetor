using ClassProduto;

namespace TestProduto
{
    public class UnitTest1
    {

        [Fact]
        public void TesteAdicionar()
        {
           
            var produto = new ClassProduto1("", "");
            string adicionar = produto.MostrarProduto("Leite");
            Assert.Equal("Leite", adicionar);

        }
        [Fact]

        public void Testfalha()
        {
            var produto = new ClassProduto1("", "");
            string adicionar = produto.MostrarProduto("Leite");
            Assert.NotEqual("Leite", adicionar);
        }

        [Fact]
        public void TestListar()
        {
            var produto1 = new ClassProduto1("Leite", "açucar");
            var produto2 = new ClassProduto1("leite", "açucar");
           Assert.NotEqual(produto1, produto2);
                
        }


        [Fact]
        public void TestQuantidade()
        {

        }

    }
}