using SoaProductApp.DAO;
using SoaProductApp.DTO;
using SoaProductApp.Model;

namespace SoaProductApp.Service
{
    internal class ProductServiceImpl : IProductService
    {
        private readonly ProductDaoImpl? productDaoImpl;

        public ProductServiceImpl(ProductDaoImpl? productDaoImpl)
        {
            this.productDaoImpl = productDaoImpl;
        }

        public void InsertProduct(ProductDTO productDTO)
        {
            Product product = new() { Name = productDTO!.Name, Price = productDTO!.Price, Quantity = productDTO!.Quantity };
            productDaoImpl!.Insert(product);
        }

        public bool UpdateProduct(ProductDTO productDTO, int id)
        {
            Product product = new() { Name = productDTO!.Name, Price = productDTO!.Price, Quantity = productDTO!.Quantity };
            bool response = productDaoImpl!.Update(product, id);
            return response;
        }

        public bool DeleteProduct(int id)
        {
            bool response = productDaoImpl!.Delete(id);
            return response;
        }

        public Product? FindProduct(int id)
        {
            return productDaoImpl!.Find(id);
        }

        public Dictionary<int, Product> GetAll()
        {
            return productDaoImpl!.GetAll();
        }

    }
}
