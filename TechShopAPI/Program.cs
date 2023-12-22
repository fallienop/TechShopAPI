using Microsoft.EntityFrameworkCore;
using TechShop.Application.Services.Abstract;
using TechShop.Application.Services.Interface;
using TechShop.Infrastructure;
//using TechShop.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext"), configure =>
    {
        configure.MigrationsAssembly("TechShop.Infrastructure");
    });
});
builder.Services.AddScoped<IService, Service>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddCors(x => x.AddDefaultPolicy(opt =>
{
    opt.AllowAnyMethod();
    opt.AllowAnyOrigin();
    opt.AllowAnyHeader();

}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
