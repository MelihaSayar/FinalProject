using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll(); //IDataResult = işlem sonucu, mesaj, döndüreceği veriyi içeren bir yapı görevi görür
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId); // Sadece product döndürür. Ürün detayını görüntülediğimizde çalışır
        IResult Add(Product product); //IResult = void
    }
}
