using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyProductAdmin.Model;

namespace MyProductAdmin.Data
{
    public class MyProductAdminContext : DbContext
    {
        public MyProductAdminContext (DbContextOptions<MyProductAdminContext> options)
            : base(options)
        {
        }

        public DbSet<MyProductAdmin.Model.Product> Product { get; set; } = default!;
    }
}
