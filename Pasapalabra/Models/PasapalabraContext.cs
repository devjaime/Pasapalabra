using System.Data.Entity;

namespace Pasapalabra.Models
{
    public class PasapalabraContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }

        public PasapalabraContext()
            : base("PasapalabraDb")
        {

        }
    }
}