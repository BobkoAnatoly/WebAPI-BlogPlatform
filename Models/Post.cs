using System.ComponentModel.DataAnnotations;

namespace WebAPI_Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
