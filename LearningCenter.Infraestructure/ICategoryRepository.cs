namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    List<Category> getAll();
    string getCategoryById(int id);

    bool create(string id);
}