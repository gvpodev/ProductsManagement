using Microsoft.EntityFrameworkCore;
using ProductsManagement.Application.Services;
using ProductsManagement.Application.Services.Contracts;
using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Services;
using ProductsManagement.Infrastructure.Contexts;
using ProductsManagement.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// DI
// Repositories
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
// App Services
builder.Services.AddTransient<ICategoryAppService, CategoryAppService>();
builder.Services.AddTransient<IProductAppService, ProductAppService>();
// Domain Services
builder.Services.AddTransient<ICategoryDomainService, CategoryDomainService>();
builder.Services.AddTransient<IProductDomainService, ProductDomainService>();

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("SqlServerDockerLocal");
builder.Services.AddDbContext<SqlServerContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
