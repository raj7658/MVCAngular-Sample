﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCAngular.Business.Entities;

namespace MVCAngular.Interfaces
{
    /// <summary>
    /// Product Data Service
    /// </summary>
    public interface IProductDataService : IDataRepository, IDisposable
    {
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        Product GetProduct(int productID);
        List<Product> GetProducts(int currentPageNumber, int pageSize, string sortExpression, string sortDirection, out int totalRows);
          
    }
}

