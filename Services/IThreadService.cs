using ForumWebAPI.Models;
using ForumWebAPI.Repositories;
using Thread = ForumWebAPI.Models.Thread;

namespace ForumWebAPI.Services
{
    public interface IThreadService
    {
        public IList<Thread> FindAll();

        public Thread FindById(string id);

        public Thread Save(Thread thread);

        public Thread Update(Thread thread);

        public bool DeleteById(string id);
    }
    
}
