using LearningCenter.Domain;
using LearningCenter.Infraestructure;
using LearningCenter.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//con esto cada ves que llame a la interface Icategorydomain internamente lo va a instanciar
//Dependency Injection
builder.Services.AddScoped<ICategoryDomain,CategoryDomain>();
builder.Services.AddScoped<ICategoryRepository,CategoryRepository>();

//conexion a mySQL
//leemos la cadena de conexion(read to appsettings.json)
var connectionString = builder.Configuration.GetConnectionString("learningCenterConnection");
//version de mysql que estamos usando
var serverVersion = new MySqlServerVersion(new Version(8, 0, 30));

builder.Services.AddDbContext<LearningCentDB>(
    //instalamos el driver pomelo.entityframeworkcore.mysql 
    //para poder conectarnos con la base de datos y manejarlo con entitny framework y la bd
    dbContextOptions => dbContextOptions.UseMySql(connectionString, serverVersion));


//esto levanta la aplicacion
var app = builder.Build();

//validamos si nuestra base de datos esta creada o no
using (var scope = app.Services.CreateScope())
using (var context = scope.ServiceProvider.GetService<LearningCentDB>()) {
    //validamos si nuestras tablas esta creada o no, y si no entonces lo crea
    context.Database.EnsureCreated();
}


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