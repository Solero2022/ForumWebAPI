global using System.ComponentModel.DataAnnotations;
namespace ForumWebAPI.Models
{
    public class Thread : IEntity
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public string title { get; set; }


        public Thread(string title)
        {
            this.title = title;
        }
    }
}
