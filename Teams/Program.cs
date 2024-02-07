using TeamsDAL;

namespace Teams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new TeamContext())
            {
                var team = new Team() { Name = "Team1", Wins = 1, Defeats = 0, Draws = 0 };
                context.Add(team);
                context.SaveChanges();
            }
        }
    }
}