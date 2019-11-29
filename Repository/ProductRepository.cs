using genericRepo.Models;
using genericRepo.Data;
using System.Collections.Generic;
using System.Linq;
using genericRepo.GenericRepository;

namespace genericRepo.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) :base(context)
        {
        }
}
}