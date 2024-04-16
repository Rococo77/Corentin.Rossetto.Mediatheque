using Mediatheque.Core.Model;
using Microsoft.EntityFrameworkCore;


namespace Mediatheque.Core.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<CD> CDs { get; set; }
        public DbSet<JeuxDeSociete> Jeux { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server = localhost; Port = 3306; Database = mediatheque; Uid = mediatheque; Pwd =; ";
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
            optionsBuilder.UseMySql(connectionString, serverVersion);
        }

    }
}
