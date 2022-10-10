using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));
            foreach (var productDetailDto in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(productDetailDto.ProductName + " - " + productDetailDto.CategoryName);
            }



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), new CategoryManager(new EfCategoryDal()));

            var result = productManager.GetProductDetails();

            if (result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            

            //Console.WriteLine("------------------");

            //foreach (var product in productManager.GetAllByCategoryId(3))
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //Console.WriteLine("------------------");

            //foreach (var product in productManager.GetByUnitPrice(50,200))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
        }
    }
}
