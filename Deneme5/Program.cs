using Business.Layer.Contrete;
using Business.Layer.Interface;
using DataAccess.Layer;
using DataAccess.Layer.Contrete;
using DataAccess.Layer.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<OkulDb>();
builder.Services.AddScoped<IBölümRepository , BölümRepository > ();
builder.Services.AddScoped<IBölümBusinessServices,BölümBusinessServices> ();
builder.Services.AddScoped<IFakülteRepository,FakülteRepository> ();
builder.Services.AddScoped<IFakülteBusinessServices,FakülteBusinessServices> ();


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
