using EnvironmentAPI;
using JwtAuthenticationManager;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<EShopDbContext>(option =>
{
    option.UseSqlServer(Environment.GetEnvironmentVariable("EnvMicro"));
    
    //option.UseSqlServer(builder.Configuration.GetConnectionString("EnvMicroDb"));
});
builder.Services.AddScoped<IRegionRepoAsync<Region>, RegionRepoAsync>();
builder.Services.AddCustomJwtAuthentication();  // Service extension Method


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// turn on authentication
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();