using Layer.Core.IUnitOfWork;
using Layer.Core.Repositories;
using Layer.Repository.Repositories;
using Layer.Repository.UnitOfWork;
using Layer.Repository;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System;
using Layer.Core.Services;
using Layer.Service.Services;
using Layer.Service.Mapping;
using Layer.Core.Servicies;
using FluentValidation.AspNetCore;
using Layer.Service.Validations;
using Layer.API.Filters;
using Microsoft.AspNetCore.Mvc;
using Layer.API.Middlewares;
using Layer.Core.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options=>options.Filters.Add(new ValidateFilterAttribute())).
    AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<BookDtoValidator>());

builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.SuppressModelStateInvalidFilter=true;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped(typeof(NotFoundFilter<>));

builder.Services.AddAutoMapper(typeof(MapProfile));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IWriterRepository, WriterRepository>();
builder.Services.AddScoped<IWriterService, WriterService>();

builder.Services.AddDbContext<BookDbContext>(x =>
{

    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
    {
        option.MigrationsAssembly(Assembly.GetAssembly(typeof(BookDbContext)).GetName().Name);
    });

});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCustomException();

app.UseAuthorization();

app.MapControllers();

app.Run();
