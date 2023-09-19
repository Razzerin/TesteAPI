using AeCTeste.Interfaces;
using AeCTeste.Mappings;
using AeCTeste.Rest;
using AeCTeste.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IClimaCidadeServices, CidadeService>();
builder.Services.AddSingleton<IBrasilAPI, BrasilApiRest>();
//builder.Services.AddSingleton<IClimaAeroServices, AeroportoService>();

builder.Services.AddAutoMapper(typeof(CidadeMapping));


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
