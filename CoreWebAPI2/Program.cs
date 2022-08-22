using CoreWebAPI2.Interface;
using CoreWebAPI2.Model;
using CoreWebAPI2.Data;
using CoreWebAPI2.Repository;
using CoreWebAPI2.Service;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var Configuration = builder.Configuration;
builder.Services.AddDbContext<ApplicationDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:TextDB2"]));
builder.Services.AddScoped<ITextRepository<Text>, TextRepository>();
builder.Services.AddScoped<TextService, TextService>();
builder.Services.AddControllers();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    dataContext.Database.Migrate();
}

app.UseCors(
  options => options.WithOrigins("*").AllowAnyMethod().AllowAnyHeader()
      );

app.UseAuthorization();

app.MapControllers();

app.Run();
