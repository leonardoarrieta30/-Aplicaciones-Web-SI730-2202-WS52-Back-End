using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public interface ICategoryDomain
{
    List<Category> getAll();
    string getCategoryById(int id);
    Boolean createCategory(string name);
    Boolean updateCategory(string name);
    Boolean deleteCategory(int id);
}