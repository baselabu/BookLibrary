using CRUD_Application.Data;
using CRUD_Application.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            this._context = context;
        }

        public IList<Books> Books { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Books != null)
            {
                Books = await _context.Books.ToListAsync();
            }
        }
    }
}
