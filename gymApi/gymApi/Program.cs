using gymApi.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//dependancy injection to dataBase connection
builder.Services.AddDbContext<GYMDbContext>(option =>
option.UseSqlServer(
    builder.Configuration.GetConnectionString("GymConnectionString")
    ));

//dependancy injection to interfaces

#region interfaces
builder.Services.AddScoped<IMEMBER, MEMBER_ACTIONS>();

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

}


//app.UseCors("AllowOrigin");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
