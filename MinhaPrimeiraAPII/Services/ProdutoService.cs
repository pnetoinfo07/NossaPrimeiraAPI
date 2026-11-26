namespace MinhaPrimeiraAPII.Services
{
    public static class ProdutoService
    {
        public static List<string> Produtos = new List<string>()
        { "Caneta" , "Borracha" };

        public static void Adicionar(string descricao)
        {
            Produtos.Add(descricao);
        }
    }
}
