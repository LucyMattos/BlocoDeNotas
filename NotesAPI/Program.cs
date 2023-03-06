using Microsoft.EntityFrameworkCore;
using NotesAPI.Configuration;
using NotesAPI.Data.Context;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
//builder.Services.AddDbContext<NotesContext>(options =>
//{
//    options.EnableSensitiveDataLogging(true);
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
//}, ServiceLifetime.Transient);

builder.Services.AddDIServices();
builder.Services.AddAutoMapper(typeof(ProfileConfiguration));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
