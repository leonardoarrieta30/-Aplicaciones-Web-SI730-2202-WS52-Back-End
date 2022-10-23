namespace LearningCenter.Infraestructure;

public class CategoryRepository: ICategoryRepository
{
    public IEnumerable<string> getAll()
    {
        //Conectar a la BD
        return new string[] { "value 1 repository", "value 2 repository" };
        
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