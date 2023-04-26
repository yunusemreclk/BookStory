﻿using AutoMapper;
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
            CreateMap<Book,BookDto>().ReverseMap();
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Invoice,InvoiceDto>().ReverseMap();
            CreateMap<Invoice, InvoiceDetailDto>();
            CreateMap<Writer,WriterDto>().ReverseMap();
            CreateMap<Book, BookDetailDto>().ReverseMap();
            CreateMap<Book_Category,Book_CategoryDto>().ReverseMap();
            CreateMap<Book_Category,BookDetailDto>().ReverseMap();
            CreateMap<Category,Book_Category>().ReverseMap();
            CreateMap<Comment,CommentDto>();
        
        }
    }
}
