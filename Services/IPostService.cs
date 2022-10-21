using ForumWebAPI.Models;
using ForumWebAPI.Repositories;

namespace ForumWebAPI.Services
{
    public interface IPostService
    {
        public IList<Post> FindAll();

        public Post FindById(string id);

        public Post Save(Post post);

        public Post Update(Post post);

        public bool DeleteById(string id);
    }
    
}
