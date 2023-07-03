using Microsoft.EntityFrameworkCore;
using ProductsManagement.Application.Services;
using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Infrastructure.Contexts;
using ProductsManagement.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// DI
// Repositories
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
// Services
builder.Services.AddScoped<ICategoryService, CategoryService>();

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("SqlServerConnectionString");
builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
