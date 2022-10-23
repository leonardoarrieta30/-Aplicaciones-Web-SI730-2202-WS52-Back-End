namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    IEnumerable<string> getAll();
    string getCategoryById(int id);

    bool create(string id);
}