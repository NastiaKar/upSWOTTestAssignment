using System.Reflection;
using USTest.BLL.Profiles;
using USTest.BLL.Services;
using USTest.BLL.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(CharacterProfile)));
builder.Services.AddScoped<ICharacterService, CharacterService>();
builder.Services.AddScoped<ILocationService, LocationService>();
builder.Services.AddScoped<IEpisodeService, EpisodeService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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