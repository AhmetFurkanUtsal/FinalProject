// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;



ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetByUnitPrice(40,1000))
{
    Console.WriteLine(product.ProductName);
}