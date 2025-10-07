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
            string adicionar = produto.MostrarProduto("Maça");
            Assert.Equal("Leite", adicionar);
        }

        [Fact]
        public void TestListar()
        {
           
        }


        [Fact]
        public void TestQuantidade()
        {

        }

    }
}