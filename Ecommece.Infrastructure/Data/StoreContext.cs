using Ecommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommece.Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) :base(options) // Is Used to send Connection string to DbContext .
        {
        }

       public DbSet<Product> Products { set; get;  }
       public DbSet<ProductBrand> productBrands { set; get;  }
       public DbSet<ProductType> ProductType { set; get;  }

    }
}
