﻿// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.Concrete.EntityFramework;
using System.Threading.Channels;




ProductManager productManager = new ProductManager(new EfProductDal());
foreach (var product in productManager.GetProductDetails().Data)
{
    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
}

//CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());


//foreach (var product in categoryManager.GetAll())

//    Console.WriteLine(product.CategoryId);



