using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MessageBoard.Models
{
  public class Topic
  {
    public Topic()
    {
      this.Messages = new HashSet<Message>();
    }

    public int TopicId { get; set; }
    [Required]
    [StringLength(20)]
    public string Title { get; set; }
    [Required]
    public string Description { get; set; }
    public virtual ICollection<Message> Messages { get; set; }
  }
}