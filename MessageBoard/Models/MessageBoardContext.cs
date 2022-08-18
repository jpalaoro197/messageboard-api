using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
  public class MessageBoardContext : DbContext
  {
    public MessageBoardContext(DbContextOptions<MessageBoardContext> options)
      : base(options) { }

    public DbSet<Message> Messages { get; set; }
    public DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Topic>().HasData(
        new Topic { TopicId = 1, Title = "mxgp", Description = "word motocross championship." },
        new Topic { TopicId = 5, Title = "wsx", Description = "world supercross championship"}
        new Topic { TopicId = 2, Title = "motocross'", Description = "American motocross championship"},
        new Topic { TopicId = 3, Title = "supercross", Description = "American supercross championship"},
        new Topic { TopicId = 4, Title = "fmx", Description = "freestyle freaks"},
      );
    }
  }
}