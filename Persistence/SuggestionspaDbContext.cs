using Microsoft.EntityFrameworkCore;
using suggestionspa.Models;

namespace suggestionspa.Persistence
{
    public class SuggestionspaDbContext : DbContext
    {
        public SuggestionspaDbContext(DbContextOptions<SuggestionspaDbContext> options)
            : base(options)
        {            
        }

        public DbSet<Gender> Genders { get; set; }
    }
}