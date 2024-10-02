<<<<<<< HEAD
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Data.SeedData;
=======
using Infrastructure.Data;
>>>>>>> 3fe0503b934348a15443e9d28ffa5fc22584c40e
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
<<<<<<< HEAD
builder.Services.AddScoped<IProductRepository, ProductRepository>();
=======

>>>>>>> 3fe0503b934348a15443e9d28ffa5fc22584c40e

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

<<<<<<< HEAD
try
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<StoreContext>();
    await context.Database.MigrateAsync();
    await StoreContextSeed.SeedAsync(context);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
    throw;
}

=======
>>>>>>> 3fe0503b934348a15443e9d28ffa5fc22584c40e
app.Run();
