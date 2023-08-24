using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using ToDo_Web_App.Models;

namespace ToDo_Web_App.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ToDo_Web_App.Models.Assignment> Assignment { get; set; }






        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Assignment>()
            .HasOne(a => a.User)
            .WithMany(u => u.Assignments)
            .HasForeignKey(a => a.UserId);
        }
    }
}