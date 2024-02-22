using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace ReactAspCrud.Models
{
    public class StudentDBContext :DbContext
    {
        public StudentDBContext(DbContextOptions Options) : base(Options)
        {

        }
        public DbSet<students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-B0CVUV9;Initial Catalog=studentDb;Integrated Security=True");
        }
    }
}
