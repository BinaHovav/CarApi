using CarApi.Data;
using CarApi.Services; 
using Microsoft.EntityFrameworkCore;
using CarApi.Models; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("CarDatabase")); 
builder.Services.AddScoped<ICarService, CarService>(); 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();

    if (!context.Cars.Any()) 
    {
        context.Cars.AddRange(
            new Car { Vendor = "Toyota", Power = 150, Price = 20000 },
            new Car { Vendor = "Honda", Power = 180, Price = 22000 },
            new Car { Vendor = "Ford", Power = 160, Price = 21000 },
            new Car { Vendor = "Chevrolet", Power = 200, Price = 25000 }
        );
        context.SaveChanges();
    }

}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
