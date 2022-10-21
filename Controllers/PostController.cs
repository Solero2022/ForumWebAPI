using Microsoft.AspNetCore.Mvc;
using ForumWebAPI.DTOs;
using ForumWebAPI.Models;
using ForumWebAPI.Services;
using AutoMapper;


namespace ForumWebAPI.Controllers
{
    [Route("Posts")]
    [ApiController]
    public class PostController : Controller
    {
        private IPostService postService;
        private IThreadService threadService;
        private IMapper mapper;

        public PostController(IPostService postService, IMapper mapper)
        {
            this.postService = postService;
            this.mapper = mapper;
        }


        [HttpGet]
        public IList<PostDTO> Index()
        {
            IList<PostDTO> postsDTO = new List<PostDTO>();
            var posts = postService.FindAll();
            foreach (Post u in posts)
            {
                postsDTO.Add(mapper.Map<PostDTO>(u));
            }
            return postsDTO;
        }


        [HttpGet("{id}")]
        public PostDTO Details(string id)
        {
            var post = postService.FindById(id);
            if (post is null)
            {
                return null;
            }

            return mapper.Map<PostDTO>(post);
        }


        [HttpPost]
        public PostDTO Create(PostDTO postDto)
        {
            Post post = mapper.Map<Post>(postDto);
            post = postService.Save(post);

            return mapper.Map<PostDTO>(post);
        }

        [HttpPut("{id}")]
        public PostDTO Edit(string id, PostDTO postDto)
        {
            var post = mapper.Map<Post>(postDto);
            if (id != post.Id)
            {
                return null;
            }

            post = postService.Update(post);

            return mapper.Map<PostDTO>(post);
        }


        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var deleted = postService.DeleteById(id);
            
        }
    }
}
