using ForumWebAPI.Models;
using ForumWebAPI.Repositories;

namespace ForumWebAPI.Services
{
   
    public class PostService : IPostService
    {
        PostRepository PostRepository;

        public PostService(PostRepository postRepository)
        {
            PostRepository = postRepository;
        }

        public bool DeleteById(string id)
        {
            var ret = PostRepository.Delete(id).Result;
            if (ret == null) return false;
            return true;
        }

        public IList<Post> FindAll()
        {
            return PostRepository.GetAll().Result;
        }

        public Post FindById(string id)
        {
            return PostRepository.Get(id).Result;
        }

        public Post Save(Post post)
        {
            Post post2 = PostRepository.Add(post).Result;
            return post2;
        }

        public Post Update(Post post)
        {
            Post post2 = PostRepository.Update(post).Result;
            return post2;
        }
    }
}
