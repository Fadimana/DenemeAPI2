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
builder.Services.AddScoped<IB�l�mRepository , B�l�mRepository > ();
builder.Services.AddScoped<IB�l�mBusinessServices,B�l�mBusinessServices> ();
builder.Services.AddScoped<IFak�lteRepository,Fak�lteRepository> ();
builder.Services.AddScoped<IFak�lteBusinessServices,Fak�lteBusinessServices> ();


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
