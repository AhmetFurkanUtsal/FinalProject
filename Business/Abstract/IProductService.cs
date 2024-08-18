using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); // referans verdik. entity ve dataaccess e

        IDataResult<List<Product>> GetAllByCategoryId(int id);// kategory ıd sine göre getir

        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        IDataResult<List<ProductDetailDto>>GetProductDetails(); // liste şeklinde döndürür

        IDataResult<Product> GetById(int productId); // tek ürün döndürür

        IResult Add(Product product);
    }
}
