using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crisan_FelixMarian_Lab8.Data;
using Crisan_FelixMarian_Lab8.Models;

namespace Crisan_FelixMarian_Lab8.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Crisan_FelixMarian_Lab8.Data.Crisan_FelixMarian_Lab8Context _context;

        public IndexModel(Crisan_FelixMarian_Lab8.Data.Crisan_FelixMarian_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(b => b.Publisher)
                .ToListAsync();
        }
    }
}
