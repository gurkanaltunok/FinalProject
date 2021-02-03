﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            foreach (var product in productManager.GetByUnitPrice(15,35))
            {
                Console.WriteLine("Ürün Adı: {0}, Ürün Fiyatı: {1} ",product.ProductName, product.UnitPrice);
            }
        }
    }
}
