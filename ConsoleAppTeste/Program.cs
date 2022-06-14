using Atacado.Service.Estoque;
using Atacado.Poco.Estoque;
using Atacado.EF.Database;

namespace ConsoleAppTeste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestarListarService();
            Console.ReadLine();
        }

        //private static void TestarListarService()
        //{
        //    CategoriaService srv = new CategoriaService();
        //    List<CategoriaPoco> listaPoco = srv.Listar();
        //    foreach (CategoriaPoco poco in listaPoco)
        //    {
        //        Console.WriteLine("Codigo: {0} - {1} - {2}", poco.Codigo, poco.Descricao, poco.Situacao);
        //        Console.WriteLine("-------------------------------------------------");
        //    }
        //}

        private static void TestarListarService()
        {
            SubcategoriaService srv = new SubcategoriaService();
            List<SubcategoriaPoco> listaPoco = srv.Listar();
            foreach (SubcategoriaPoco poco in listaPoco)
            {
                Console.WriteLine("Codigo: {0} - {1} - {2}", poco.IdSubcategoria, poco.DescricaoSubcategoria, poco.Situacao);
                Console.WriteLine("-------------------------------------------------");
            }
        }

    }
}
