using AutoMapper;
using Layer.Core.DTOs;
using Layer.Core.Entities;
using Layer.Repository.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookDto>().ReverseMap();
            CreateMap<Book, BookDetailDto>().ReverseMap();
            CreateMap<Book, BookAddDto>().ReverseMap();

            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryWithBooksDto>();
    
            CreateMap<Book_Category,Book_CategoryDto>().ReverseMap();
            CreateMap<Book_Category,BookDetailDto>().ReverseMap();
            
            CreateMap<Writer,WriterDto>().ReverseMap();
            CreateMap<Writer, WriterWithBooksDto>();

            CreateMap<Invoice,InvoiceDto>().ReverseMap();
            CreateMap<Invoice, InvoiceDetailDto>();
           
            CreateMap<Comment,CommentDto>();

        }
    }
}
