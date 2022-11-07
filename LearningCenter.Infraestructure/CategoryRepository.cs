using LearningCenter.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.Infraestructure;

public class CategoryRepository: ICategoryRepository
{
    
    //
    private LearningCentDB _learningCentDb;

    public CategoryRepository(LearningCentDB learningCentDb)
    {
        //esta variable ya esta totalmente ligada a nuestra base de datos
        _learningCentDb = learningCentDb;
    }
    
    public List<Category> getAll()
    {
        //Conectar a la BD
        //esta base de datos se va a conectar a ala tabla categories y
        //me va a listar_todo lo que tenga esta tabla
        //vamos a filtrar por nombre
        var filterByName = "category"; 
        //sentencia like aca es igual a Contains
        return _learningCentDb.Categories.Where(category =>category.IsActive == true && category.Name.Contains(filterByName))
            //incluimos tutoriales dentro de categories
            .Include(category => category.Tutorials)
            .ToList(); 
        //LINQ


        //var resul = from categorias in _learningCentDb.Categories
          //  join tutoriales in _learningCentDb.Tutorials on categorias.Id equals tutoriales.CategoryId
            //select tutoriales.Category;


        //new Tutorial().Category.Name;
    }

    public Category getCategoryById(int id)
    {
        //conectar a la BD o API, al file -->datos
        //ya no me devuelve un listado sino un solo objeto(por id(nunca se repite))
        return _learningCentDb.Categories.Include(category => category.Tutorials).SingleOrDefault(category => category.Id == id);
        //LINQ
    }

    public async Task<bool> create(Category category)
    {
        //Category category = new Category();
        //category.Name = name;
        //category.Description = "Description " + name;

        //aca va a empezar la transaccion
        _learningCentDb.Database.BeginTransactionAsync();

        //si cualquiera de los 2 transacciones falla va a ser un rollback se va a desaseer 

        try
        {
            _learningCentDb.Categories.AddAsync(category);
            _learningCentDb.SaveChangesAsync();

        }
        catch (Exception ex)
        {
            _learningCentDb.Database.RollbackTransactionAsync();
        }
        
       
        //si de las 2 transacciones se hace bien va a hacer un commit
        _learningCentDb.Database.CommitTransactionAsync();
        
        
        return true;
    }

    public bool Update(int id, string newName)
    {
        Category category = _learningCentDb.Categories.Find(id);
        category.Name = newName;
        
        _learningCentDb.Categories.Update(category);
        _learningCentDb.SaveChanges();

        return true;
    }

    public bool Delete(int id)
    {
        Category category = _learningCentDb.Categories.Find(id);
        
        //_learningCentDb.Categories.Remove(category);
        //_learningCentDb.SaveChanges();
        category.IsActive = false;
        category.DateUpdated = DateTime.Now;
        _learningCentDb.Categories.Update(category);
        _learningCentDb.SaveChanges();

        
        return true;
    }
}