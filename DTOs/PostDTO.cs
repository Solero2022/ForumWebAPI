using ForumWebAPI.Models;
using Thread = ForumWebAPI.Models.Thread;

namespace ForumWebAPI.DTOs
{
    public class PostDTO
    {
        public string Id { get; set; }
        public Category categoria { get; set; }

        public Thread thread { get; set; }
    }
}
