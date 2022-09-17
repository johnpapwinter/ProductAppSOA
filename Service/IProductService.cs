using SoaProductApp.DTO;
using SoaProductApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaProductApp.Service
{
    internal interface IProductService
    {
        void InsertProduct(ProductDTO productDTO);
        bool UpdateProduct(ProductDTO productDTO, int id);
        Product? FindProduct(int id);
        bool DeleteProduct(int id);
        Dictionary<int, Product> GetAll();
    }
}
