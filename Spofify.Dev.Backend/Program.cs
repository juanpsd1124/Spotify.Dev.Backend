
using Spotify.Dev.Backend.BL;
using Spotify.Dev.Backend.Utils;
using Swashbuckle.AspNetCore.SwaggerUI;

string allowSpecificOrigins = "_allowSpecificOrigins";

var builder = WebApplication.CreateBuilder(args);



IConfigurationSection originsSection = builder.Configuration.GetSection("Origins");
var origins = originsSection.GetChildren().ToArray().Select(c => c.Value).ToArray();

builder.Services.AddCors(options =>
{
    options.AddPolicy(allowSpecificOrigins, builder =>
    {
        builder
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .WithOrigins(origins);
    });
});


builder.Services.AddTransient<ISpotifyBL,SpotifyBL>();

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors(allowSpecificOrigins);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSwaggerUI(config =>
{
    config.SwaggerEndpoint("./v1/swagger.json", "Spotify WebAPI");
    config.RoutePrefix = "core/api/docs";
    config.DocExpansion(DocExpansion.None);
});

app.UseAuthorization();

app.MapControllers();

app.Run();
