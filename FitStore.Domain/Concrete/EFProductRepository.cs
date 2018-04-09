using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitStore.Domain.Abstract;
using FitStore.Domain.Entities;

namespace FitStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }
    }
}
