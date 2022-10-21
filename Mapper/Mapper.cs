using AutoMapper;
using ForumWebAPI.Models;
using ForumWebAPI.DTOs;


namespace ForumWebAPI.Mapper

{
    public class Mapper : Profile
    {

        public Mapper()
        {

            //Cita
            CreateMap<PostDTO, Post>();
            CreateMap<Post, PostDTO>();


           
        }

    }
}
