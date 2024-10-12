using Microsoft.EntityFrameworkCore;
using MutliShop.Message.DAL.Entities;

namespace MutliShop.Message.DAL.Context
{
    public class MessageContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1443;initial Catalog=MessageDb;User=sa;Password=Betaberk1907*");
        }
        public DbSet<UserMessage> UserMessages { get; set; }
    }
}
