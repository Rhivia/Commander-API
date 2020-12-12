using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextoptions<CommanderContext> opt) : base(base)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}