using Microsoft.EntityFrameworkCore;

namespace TeamsDAL
{
    public class TeamContext : DbContext
    {
        DbSet<Team> teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Teams;Integrated Security=True;Connect Timeout=30;");
        }
    }
}
