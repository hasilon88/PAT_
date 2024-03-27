using Microsoft.EntityFrameworkCore;
using PAT.Models.Entities;


namespace PAT.Models
{
    public class PatDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dataBasePath = "C:/PAT_DB/appData.db";
            Directory.CreateDirectory("C:/PAT_DB");
            optionsBuilder.UseSqlite("Data Source=" + dataBasePath);
        }
    }
}
