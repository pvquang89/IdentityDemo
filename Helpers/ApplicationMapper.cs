using AutoMapper;
using IndentityDemo.Data;
using IndentityDemo.Models;

namespace IndentityDemo.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
