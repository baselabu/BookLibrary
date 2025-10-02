using CRUD_Application.Models;
using CRUD_Application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Pages.Book
{
    public class DeleteModel : PageModel
    {
        private readonly AppDbContext _context;

        public DeleteModel(AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            var book = await _context.Books.FindAsync(Books.Bookid);
            if (book == null)
            {
                return RedirectToPage("./Index");
            }
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}

