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
    }
}
