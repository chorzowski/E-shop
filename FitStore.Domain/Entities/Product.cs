using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitStore.Domain.Entities
{
    // Model danych. W tym projekcie jest model danych czyli logika przeznaczona do przechowywania i pobierania danych
    // z trwałego magazynu danych.
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
