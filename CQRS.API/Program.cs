using CQRS.API.Persistance;
using CQRS.API.Persistance.Repositories;
using CQRS.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>(); //It's Singletion only to use the _customerList on CustomerRepository

builder.Services.AddDbContext<ProjectDbContext>(options => //Configuration of Entity Framework in memory
    options.UseInMemoryDatabase("CQRS-example")
);

builder.Services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly())); //DI of MediatR

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
