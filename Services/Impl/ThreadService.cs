using ForumWebAPI.Models;
using ForumWebAPI.Repositories;
using Thread = ForumWebAPI.Models.Thread;

namespace ForumWebAPI.Services
{
   
    public class ThreadService : IThreadService
    {
        ThreadRepository ThreadRepository;

        public ThreadService(ThreadRepository threadRepository)
        {
            ThreadRepository = threadRepository;
        }

        public bool DeleteById(string id)
        {
            var ret = ThreadRepository.Delete(id).Result;
            if (ret == null) return false;
            return true;
        }

        public IList<Thread> FindAll()
        {
            return ThreadRepository.GetAll().Result;
        }

        public Thread FindById(string id)
        {
            return ThreadRepository.Get(id).Result;
        }

        public Thread Save(Thread thread)
        {
            Thread thread2 = ThreadRepository.Add(thread).Result;
            return thread2;
        }

        public Thread Update(Thread thread)
        {
            Thread thread2 = ThreadRepository.Update(thread).Result;
            return thread2;
        }
    }
}
