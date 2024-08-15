// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System.Threading.Channels;


static void Main(string[] args)
{

  
}

ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetProductDetails())
{
    Console.WriteLine(product.ProductName + "/" + product.ProductName);
}

//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


//foreach (var product in categoryManager.GetAll())

//    Console.WriteLine(product.CategoryId);



