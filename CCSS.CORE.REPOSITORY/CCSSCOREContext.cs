using CCSS.CORE.MODEL;
using Microsoft.EntityFrameworkCore;

namespace CCSS.CORE.REPOSITORY
{
    public class CCSSCOREContext : DbContext
    {
        public CCSSCOREContext(DbContextOptions<CCSSCOREContext> options)
            : base(options)
        {
        }

        public DbSet<Knowledge> Knowledge { get; set; }
        public DbSet<Technology> Technology { get; set; }
    }
}
