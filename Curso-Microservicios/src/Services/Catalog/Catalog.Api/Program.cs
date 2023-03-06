using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers;
using CatalogServiceQueries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();   
builder.Services.AddDbContext<ApplicationDbContext>(opts =>
{
    opts.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ,
    x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Catalog")
    );
});
//builder.Services.AddMediatR(typeof("Catalog.Service.EventHandlers").Assembly);
builder.Services.AddMediatR(Assembly.Load("Catalog.Service.EventHandlers"));
builder.Services.AddTransient<IProductQueryService, ProductQueryService>();




var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context =scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    context.Database.Migrate();
}


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
