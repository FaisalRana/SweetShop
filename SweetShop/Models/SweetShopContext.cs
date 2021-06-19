using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace SweetShop.Models
{
  public class SweetShopContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<AuthorBook> AuthorBook { get; set; }
    public DbSet<Patron> Patrons { get; set; }

    public SweetShopContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}