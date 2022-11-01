namespace LearningCenter.Infraestructure;

public interface ICategoryRepository
{
    List<Category> getAll();
    Category getCategoryById(int id);

    bool create(string id);
    bool Update(int id, string newName);

    bool Delete(int id);
}