
using CakeShop.Service.Products.Model;
using CakeShop.Service.Products.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CakeShop.Service.Products.Interface
{
    public interface IProductService
    {
        Task<int> CreateProduct(ModelCreateProduct request);
        Task<int> UpdateProduct(ModelUpdateProduct request);
        Task<int> DeleteProduct(int productId);
        Task<PagedResultProduct<ModelViewProduct>> GetAllProductService();
        Task<List<ModelViewProduct>> GetById(int productId, string languageId);
        Task<List<ModelViewProduct>> SearchByKeyWord(KeyWordForSearch request);
        Task<List<ModelViewProduct>> GetProductByCategoryId(int categoryId, string language);
    }
}
