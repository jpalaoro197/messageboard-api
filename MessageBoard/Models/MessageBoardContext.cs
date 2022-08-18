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
        new Topic { TopicId = 1, Title = "Coding", Description = "Computer chat for big nerds." },
        new Topic { TopicId = 2, Title = "Gamin'", Description = "Talking about gaming... lol"},
        new Topic { TopicId = 3, Title = "Movies", Description = "Motion Picture Appreciators"},
        new Topic { TopicId = 4, Title = "Sports", Description = "SporsBall... americas passtime"},
        new Topic { TopicId = 5, Title = "Misc", Description = "Anything goes"}
      );
    }
  }
}