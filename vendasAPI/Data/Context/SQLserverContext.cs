using Microsoft.EntityFrameworkCore;

namespace vendasAPI.Model.Context
{
    public class SQLserverContext : DbContext
    {
        public SQLserverContext()
        {
        }

        public SQLserverContext(DbContextOptions <SQLserverContext>options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
