using SoaProductApp.DAO;
using SoaProductApp.DTO;
using SoaProductApp.Model;
using SoaProductApp.Service;

namespace SoaProductApp
{
    internal class Program
    {
        static readonly ProductDaoImpl dao = new ProductDaoImpl();
        static readonly ProductServiceImpl service = new ProductServiceImpl(dao);
        static void Main(string[] args)
        {
            ProductDTO product1 = new() { Name = "chocolate", Price = 5.5, Quantity = 2};
            ProductDTO product2 = new() { Name = "milk", Price = 4.5, Quantity = 3 };
            ProductDTO product3 = new() { Name = "bread", Price = 2.0, Quantity = 1 };

            service.InsertProduct(product1);
            service.InsertProduct(product2);
            service.InsertProduct(product3);

            Console.WriteLine("Total products in the shop:");
            foreach(KeyValuePair<int, Product> pair in service.GetAll())
            {
                Console.WriteLine($"Id: {pair.Key}, {pair.Value}");
            }
            Console.WriteLine();

            Console.WriteLine(service.FindProduct(1));

            service.DeleteProduct(3);
            Console.WriteLine("Total products in the shop:");
            foreach (KeyValuePair<int, Product> pair in service.GetAll())
            {
                Console.WriteLine($"Id: {pair.Key}, {pair.Value}");
            }


        }
    }
}