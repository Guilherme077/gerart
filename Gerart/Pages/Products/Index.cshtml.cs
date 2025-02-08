using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Gerart.Data;
using Gerart.Models;

namespace Gerart.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly Gerart.Data.GerartContext _context;

        public IndexModel(Gerart.Data.GerartContext context)
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
