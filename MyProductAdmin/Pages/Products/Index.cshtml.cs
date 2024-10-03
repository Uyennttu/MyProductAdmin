using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyProductAdmin.Data;
using MyProductAdmin.Model;

namespace MyProductAdmin.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly MyProductAdmin.Data.MyProductAdminContext _context;

        public IndexModel(MyProductAdmin.Data.MyProductAdminContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
