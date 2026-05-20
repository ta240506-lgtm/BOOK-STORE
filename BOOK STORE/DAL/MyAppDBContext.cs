using BOOK_STORE.Models;
using Microsoft.EntityFrameworkCore;

namespace BOOK_STORE.DAL
{
    public class MyAppDBContext : DbContext
    {
        public MyAppDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Books> Books { get; set; }
        
    }
}
