using OnlineStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Concrete
{
    public class EFProductRepository : IProductRepository
    {
        private readonly EFDbContext context = new EFDbContext();
        public IEnumerable<Entities.Product> Products
        {
            get { return context.Products; }
        }
    }
}
