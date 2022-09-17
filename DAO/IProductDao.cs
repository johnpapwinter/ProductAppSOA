using SoaProductApp.Model;

namespace SoaProductApp.DAO
{
    internal interface IProductDao
    {
        void Insert(Product? product);
        bool Update(Product? product, int id);
        Product? Find(int id);
        bool Delete(int id);
        Dictionary<int, Product> GetAll();

    }
}
