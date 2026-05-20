using BOOK_STORE.DAL;
using BOOK_STORE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BOOK_STORE.Pages.Book
{
    public class IndexModel : PageModel
    {
        private readonly MyAppDBContext _context;

        public IndexModel(MyAppDBContext context)
        {
            _context = context;
        }
        public IList<Books> Books { get; set; }
        public async Task  OnGetAsync()
        {
            Books =await _context.Books.ToListAsync();

        }
    }
}
