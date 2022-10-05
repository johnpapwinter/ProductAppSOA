using SoaProductApp.DAO;
using SoaProductApp.DTO;
using SoaProductApp.Model;
using SoaProductApp.Service;

namespace SoaProductApp.Controller
{
    internal class Controller
    {
        static readonly ProductDaoImpl dao = new ProductDaoImpl();
        static readonly ProductServiceImpl service = new ProductServiceImpl(dao);

        public void BusinessLogicHandler()
        {
            while (true)
            { 
                ShowMenu();
                string? selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        // insert a new product
                        Console.WriteLine("Please enter the product name");
                        string? productName = Console.ReadLine();
                        Console.WriteLine("Please enter the product price");
                        double productPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the product quantity");
                        int productQuantity = Convert.ToInt32(Console.ReadLine());
                        ProductDTO newProductDto = new() { Name = productName, Price = productPrice, Quantity = productQuantity};
                        service.InsertProduct(newProductDto);
                        Console.WriteLine();
                        break;
                    case "2":
                        // search for a product
                        Console.WriteLine("Please enter the id of the product");
                        int idToSearch = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(service.FindProduct(idToSearch));
                        Console.WriteLine();
                        break;
                    case "3":
                        foreach(KeyValuePair<int, Product> pair in service.GetAll())
                        {
                            Console.WriteLine($"Id: {pair.Key}, {pair.Value}");
                        }
                        Console.WriteLine();
                        break;
                    case "4":
                        // update a product
                        Console.WriteLine("Please enter the id of the product");
                        int idToUpdate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(service.FindProduct(idToUpdate));
                        Console.WriteLine("Please enter the new product name");
                        string? updatedProductName = Console.ReadLine();
                        Console.WriteLine("Please enter the product price");
                        double updatedProductPrice = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the product quantity");
                        int updatedProductQuantity = Convert.ToInt32(Console.ReadLine());
                        ProductDTO updatedProductDto = new() { Name = updatedProductName, Price = updatedProductPrice, Quantity = updatedProductQuantity };
                        service.UpdateProduct(updatedProductDto, idToUpdate);
                        Console.WriteLine();
                        break;
                    case "5":
                        // delete a product
                        Console.WriteLine("Please enter the id of the product");
                        int idToDelete = Convert.ToInt32(Console.ReadLine());
                        service.DeleteProduct(idToDelete);
                        Console.WriteLine();
                        break;
                    case "6":
                        // exit program
                        Console.WriteLine("Thank you! We hope to see you again!");
                        return;
                    default:
                        // invalid user input
                        Console.WriteLine("Please enter a valid selection");
                        Console.WriteLine();
                        break;
                }
            }
        }
        
        private void ShowMenu()
        {
            Console.WriteLine("Please enter an action:");
            Console.WriteLine("1. Create a product");
            Console.WriteLine("2. Find a product");
            Console.WriteLine("3. Show all products");
            Console.WriteLine("4. Update a product");
            Console.WriteLine("5. Delete a product");
            Console.WriteLine("6. Exit");
            Console.WriteLine();
        }

    }
}