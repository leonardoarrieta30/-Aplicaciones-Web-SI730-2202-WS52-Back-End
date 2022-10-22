namespace LearningCenter.Domain;

public class CategoryDomain : ICategoryDomain
{

    public List<string> getAll()
    {
        throw new NotImplementedException();
    }

    public string getCategoryById(int id)
    {
        return "body from Domain " +id.ToString();
    }

    public bool createCategory(string name)
    {
        throw new NotImplementedException();
    }
}