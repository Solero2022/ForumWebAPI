using ForumWebAPI.Models;
using ForumWebAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ForumWebAPI.Repositories
{
    public class PostRepository
    {
        private readonly DataContext context;
        public PostRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<Post> Add(Post post)
        {
            context.Set<Post>().Add(post);
            await context.SaveChangesAsync();
            return post;
        }

        public async Task<Post> Delete(string id)
        {
            var post = await context.Set<Post>().FindAsync(id);
            if (post == null)
            {
                return null;
            }

            context.Set<Post>().Remove(post);
            await context.SaveChangesAsync();

            return post;
        }

        public async Task<Post> Get(string id)
        {
            return await context.Set<Post>().FindAsync(id);
        }

        public async Task<List<Post>> GetAll()
        {
            return await context.Set<Post>().ToListAsync();
        }

        public async Task<Post> Update(Post post)
        {
            context.Entry(post).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return post;
        }
    }
}
