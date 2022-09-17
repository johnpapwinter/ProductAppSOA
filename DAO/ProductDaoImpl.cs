using SoaProductApp.Model;

namespace SoaProductApp.DAO
{

    internal class ProductDaoImpl : IProductDao
    {
        private Dictionary<int, Product> data = new Dictionary<int, Product>();
        private int id = 0;

        public void Insert(Product? product)
        {
            id++;
            data.Add(id, product!);
        }

        public Product? Find(int id)
        {
            return data.ContainsKey(id) ? data[id] : null;
        }

        public Dictionary<int, Product> GetAll()
        {
            return data;
        }


        public bool Update(Product? product, int id)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }
            data[id] = new Product(product!.Name, product.Price, product.Quantity);
            return true;
        }
        public bool Delete(int id)
        {
            if (!data.ContainsKey(id))
            {
                return false;
            }
            data.Remove(id);
            return true;
        }

    }
}
