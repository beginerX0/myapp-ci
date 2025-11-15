using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _1lab.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Abonent> Abonents { get; set; }
        public virtual DbSet<Schetchik> Schetchiks { get; set; }
        public virtual DbSet<Pokazanie> Pokazaniya { get; set; }
    }
}
