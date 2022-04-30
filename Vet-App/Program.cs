using Microsoft.EntityFrameworkCore;
using Vet_App.Context;
using Vet_App.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvc();
builder.Services.AddDbContext<AnimalDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("VetDatabase")));

builder.Services.AddScoped<AnimalsService>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())

 scope.ServiceProvider.GetRequiredService<AnimalDatabaseContext>().Database.Migrate();

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
