using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductBusiness
    {
        public static void AddProductBusiness(ProductClass1 product)
        {
            ProductDB.AddProductDB(product);
        }

        public static void UpdateProductBusiness(ProductClass1 product)
        {
            ProductDB.UpdateProductDB(product);
        }

        public static void DeleteProductBusiness(ProductClass1 product)
        {
            ProductDB.DeleteProductDB(product);
        }

        public static DataTable SelectAllProductBusiness()
        {
            return ProductDB.SelectAllProducts();
        }



    }


}
