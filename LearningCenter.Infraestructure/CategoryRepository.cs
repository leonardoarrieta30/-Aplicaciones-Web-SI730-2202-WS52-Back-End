using LearningCenter.Infraestructure.Context;

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
        return _learningCentDb.Categories.ToList();

        //new Tutorial().Category.Name;
    }

    public string getCategoryById(int id)
    {
        throw new NotImplementedException();
    }

    public bool create(string id)
    {
        throw new NotImplementedException();
    }
}