using CRUD_Application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Application.Pages.Book
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
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
        [BindProperty]
        public Models.Books Books { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _context.Books.Update(Books);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}