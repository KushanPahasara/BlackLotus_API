using BlackLotus.Data;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var conn = "Data Source=DESKTOP-6KQ0841\\SQL2019;Initial Catalog=BlackLotusDB;Persist Security Info=True;User ID=sa;Password=sql@123";
builder.Services.AddDbContext<AppDBContex>(options => options.UseSqlServer(conn));
builder.Services.AddScoped<IFlowerRepo, FlowerRepo>();
builder.Services.AddScoped<ICatagoryRepo, CatagoryRepo>();
builder.Services.AddScoped<IStockRepo, StockRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();
builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddControllers(); 

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
