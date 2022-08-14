using Aula2NDD.Infra;
using Aula2NDD.Services;
using Aula2NDD.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//unico apra aplicacao toda
//usado esse getrequiered.. para pegar a logica que ja foi escrita sendo assim nao precisa reescreves
builder.Services.AddScoped <ServicoSMS>((service) => new ServicoSMS(service.GetRequiredService<LogAcao>()));

builder.Services.AddScoped<LogAcao>((s) => new LogAcao("\"C:\\Logs\\Logs.txt"));

// injecao de repositorio
builder.Services.AddScoped<TipoClienteRepository>();
builder.Services.AddScoped<ClienteRepository>();

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

