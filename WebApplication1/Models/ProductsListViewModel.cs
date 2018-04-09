﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitStore.Domain.Entities;

namespace WebApplication1.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}