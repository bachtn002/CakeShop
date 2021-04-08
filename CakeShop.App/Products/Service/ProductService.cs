using CakeShop.Data.EF;
using CakeShop.Data.Entities;
using CakeShop.Service.Products.Interface;
using CakeShop.Service.Products.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CakeShop.Service.Products.Service
{
    public class ProductService : IProductService
    {
        private readonly CakeShopDbContext _context;

        public ProductService(CakeShopDbContext context)
        {
            _context = context;
        }
        public async Task<int> CreateProduct(ModelCreateProduct request)
        {
            var languages = _context.Languages;
            var translations = new List<ProductTranslation>();
            var product = new Product()
            {
                ProductPrice = request.ProductPrice,
                BrandProduct = request.BrandProduct,
                OriginalPrice = request.OriginalPrice,
                StockProduct = request.StockProduct,
                WeightProduct = request.WeightProduct,
                CodeProduct = request.CodeProduct,
                DateCreate = DateTime.Now,
                ImageProduct = request.ImageProduct,
                ProductTranslations = translations
            };
            foreach (var language in languages)
            {
                if (language.Id == request.LanguageId)
                {
                    translations.Add(new ProductTranslation()
                    {
                        NameProduct = request.NameProduct,
                        Description = request.Description,
                        SeoAlias = request.SeoAlias,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    });
                }
                else
                {
                    translations.Add(new ProductTranslation()
                    {

                    });
                }
            }
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.IdProduct;
        }

        public async Task<int> DeleteProduct(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null) throw new Exception($"Can not find product : {productId}");
            else
            {
                _context.Products.Remove(product);
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ModelViewProduct>> GetAll()
        {
            var query = from p in _context.Products
                        select new { p };
            var data = await query.Select(x => new ModelViewProduct()
            {
                ProductPrice = x.p.ProductPrice,
                BrandProduct = x.p.BrandProduct,
                CodeProduct = x.p.CodeProduct,
                ImageProduct = x.p.ImageProduct,
                OriginalPrice = x.p.OriginalPrice,
                StockProduct = x.p.StockProduct,
                WeightProduct = x.p.WeightProduct
            }).ToListAsync();
            return data;
        }

        public Task<List<ModelViewProduct>> GetById(int productId, string languageId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ModelViewProduct>> GetProductByCategoryId(int categoryId, string languageId)
        {
            var query = from p in _context.Products
                        join pc in _context.ProductWithCategories on p.IdProduct equals pc.ProductId
                        join pt in _context.ProductTranslations on p.IdProduct equals pt.ProductId
                        join c in _context.Categories on pc.CategoryId equals c.Id
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where c.Id == categoryId && pt.LanguageId == languageId && pt.LanguageId == ct.LanguageId
                        select new { p, pt, ct };
            var data = await query.Select(x => new ModelViewProduct()
            {
                NameProduct = x.pt.NameProduct,
                ProductPrice = x.p.ProductPrice,
                OriginalPrice = x.p.OriginalPrice,
                BrandProduct = x.p.BrandProduct,
                ImageProduct = x.p.ImageProduct,
                CodeProduct = x.p.CodeProduct
                //NameCategory=x.ct.NameCategory,
                //LanguageId=x.pt.LanguageId

            }).ToListAsync();

            return data;
        }

        public Task<List<ModelViewProduct>> SearchByKeyWord(KeyWordForSearch request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateProduct(ModelUpdateProduct request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var productTrans = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.Id == request.Id && x.LanguageId == request.LanguageId);
            if (product == null || productTrans == null) throw new Exception($"Can not find product : {request.Id}");
            else
            {
                product.ProductPrice = request.ProductPrice;
                product.ImageProduct = request.ImageProduct;
                product.StockProduct = request.StockProduct;
                productTrans.NameProduct = request.NameProduct;
                productTrans.Description = request.Description;
                productTrans.SeoAlias = request.SeoAlias;
                productTrans.SeoDescription = request.SeoDescription;
                productTrans.SeoTitle = request.SeoTitle;
            }
            return await _context.SaveChangesAsync();// Tra ve so luong ban ghi 
            // update thanh cong vao database // neu return >0 => success
        }
    }
}
