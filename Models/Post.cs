global using System.ComponentModel.DataAnnotations;
using ForumWebAPI.Models;

namespace ForumWebAPI.Models
{
    public class Post : IEntity
    {
        [Key]
        public string Id { get; set; }

        [Required]
        public Category categoria { get; set; }

        [Required]
        public Thread thread { get; set; }


        public Post(Category categoria)
        {
            this.categoria = categoria;
        }
    }
}
