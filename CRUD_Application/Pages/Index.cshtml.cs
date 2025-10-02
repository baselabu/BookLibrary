using CRUD_Application.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CRUD_Application.Pages
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<CRUD_Application.Models.Books> Books { get; set; } = new();

        public void OnGet()
        {
            Books = _context.Books.ToList();
        }
    }
}
