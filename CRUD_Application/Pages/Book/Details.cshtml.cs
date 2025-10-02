using CRUD_Application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CRUD_Application.Models;

namespace CRUD_Application.Pages.Book
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Books Books { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Books == null)
            {
                return RedirectToPage("./Index");
            }

            var book = await _context.Books.FirstOrDefaultAsync(b => b.Bookid == id);

            if (book == null)
            {
                return RedirectToPage("./Index");
            }
            else
            {
                Books = book;
            }
            return Page();
        }
    }
}
