using ForumWebAPI.Models;
using ForumWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Thread = ForumWebAPI.Models.Thread;

namespace ForumWebAPI.Repositories
{
    public class ThreadRepository
    {
        private readonly DataContext context;
        public ThreadRepository(DataContext context)
        {
            this.context = context;
        }
        public async Task<Thread> Add(Thread thread)
        {
            context.Set<Thread>().Add(thread);
            await context.SaveChangesAsync();
            return thread;
        }

        public async Task<Thread> Delete(string id)
        {
            var thread = await context.Set<Thread>().FindAsync(id);
            if (thread == null)
            {
                return null;
            }

            context.Set<Thread>().Remove(thread);
            await context.SaveChangesAsync();

            return thread;
        }

        public async Task<Thread> Get(string id)
        {
            return await context.Set<Thread>().FindAsync(id);
        }

        public async Task<List<Thread>> GetAll()
        {
            return await context.Set<Thread>().ToListAsync();
        }

        public async Task<Thread> Update(Thread thread)
        {
            context.Entry(thread).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return thread;
        }
    }
}
