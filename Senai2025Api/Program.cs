using System.Reflection;
using AutoMapper;
using Senai2025Api.Contexts;
using Senai2025Api.Interfaces.Repositorios;
using Senai2025Api.Interfaces.Servicos;
using Senai2025Api.Repositorios;
using Senai2025Api.Servicos;
using FluentValidation;
using FluentValidation.AspNetCore;
using Senai2025Api.Validators;
using Senai2025Api.DTos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
    //.AddFluentValidation(fv =>
    //{
    //    fv.RegisterValidatorsFromAssemblyContaining<EscolaValidator>();
    //});
    
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<SenaiContext>();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IEscolaRepository, EscolaRepository>();
builder.Services.AddScoped<IEscolaService, EscolaService>();

MapperConfiguration mapperConfiguration = new(mapperConfig => { mapperConfig.AddMaps(new[] { "Senai2025Api" }); });
builder.Services.AddSingleton(mapperConfiguration.CreateMapper());

//builder.Services.AddValidatorsFromAssemblyContaining<EscolaValidator>();    


//builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddScoped<IValidator<EscolaDTo>, EscolaValidator>();
//builder.Services.AddValidatorsFromAssembly(Assembly.Load("Senai2025Api"));

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
