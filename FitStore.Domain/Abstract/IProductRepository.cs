using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitStore.Domain.Entities;

namespace FitStore.Domain.Abstract
{
    // Odpowiada za obsługe danych z klasy Product.
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
