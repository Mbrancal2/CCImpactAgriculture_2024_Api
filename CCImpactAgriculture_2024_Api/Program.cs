using CCImpactAgriculture_2024_Api.Data;
using CCImpactAgriculture_2024_Api.Models;
using CCImpactAgriculture_2024_Api.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<CCImpactAgricultureContext>(opt =>
    opt.UseMySQL(builder.Configuration.GetConnectionString("Climate_ChangeContext")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICCImpactAgricultureDbService, CCImpactAgricultureDbService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

using( var scoped = app.Services.CreateScope())
{
    var context = new CCImpactAgricultureContext (
        scoped.ServiceProvider.GetRequiredService<DbContextOptions<CCImpactAgricultureContext>>()
    );
    Dbinitilizer.Initilize(context);
}

app.UseAuthorization();

app.MapControllers();

app.Run();
