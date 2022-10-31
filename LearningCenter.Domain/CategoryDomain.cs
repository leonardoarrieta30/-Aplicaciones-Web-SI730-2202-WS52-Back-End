using LearningCenter.Infraestructure;

namespace LearningCenter.Domain;

public class CategoryDomain : ICategoryDomain
{
    private ICategoryRepository _categoryRepository;
    
    public CategoryDomain(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public List<Category> getAll()
    {
        return _categoryRepository.getAll();
    }

    public Category getCategoryById(int id)
    {
        return _categoryRepository.getCategoryById(id);
    }

    public bool createCategory(string name)
    {
        return _categoryRepository.create(name);
    }

    public bool updateCategory(int id, string name)
    {
        return _categoryRepository.Update(id,name);
    }

    public bool deleteCategory(int id)
    {
        throw new NotImplementedException();
    }
}