using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure.Context;

//el db context nos da entity framework 
//y hace referencia a la base de datos
public class LearningCentDB : DbContext 
{
     //el dbset hace referencia a las tablas y crea las tablas
     public DbSet<Category> Categories { get; set; }
     public DbSet<Tutorial> Tutorials { get; set; }
     public DbSet<User> Users { get; set; }

     //vamos a sobreescribir un metodo de entity framework
     //esto se crea para poder manipular algunas cosas y tener
     //un mejor control de como crea nuestra tabla
     protected override void OnModelCreating(ModelBuilder builder) //model builder son clases propias del entityframework
     {
          //aca estamos haciendo fluent api
          //aca se define como se va a crear nuestras tablas
          //el  objeto lo vamos a relacionar copn una tabla llamada "Categories"
          builder.Entity<Category>().ToTable("Categories");
          //haskey-> clave primaria
          //El parametro o la propiedad Id va a ser mi clave primaria
          builder.Entity<Category>().HasKey(p => p.Id);
          //ValueGeneratedOnAdd.- el valor sea generado cuando inserto
          //el id que sea obligatorio
          builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
          //el campo name es obligatorio
          //va a tener una longitud maxima de 60 caracteres
          builder.Entity<Category>().Property(c => c.Name).IsRequired().HasMaxLength(60);
          //hasdefaultvalue.- va a tener un valor por defecto y se va a crear con la fecha de ahora(Automatica)
          builder.Entity<Category>().Property(c => c.DateCreated).IsRequired().HasDefaultValue(DateTime.Now);
          //siempre va a ser true
          //que se cree como true
          //que no se elimine al crear
          builder.Entity<Category>().Property(c => c.IsActive).IsRequired().HasDefaultValue(true);
          
          
          
          builder.Entity<Tutorial>().ToTable("Tutorials");
          builder.Entity<Tutorial>().HasKey(p => p.Id);

          builder.Entity<User>().ToTable("Users");
          builder.Entity<User>().HasKey(p => p.Id);

     }

    
     
}