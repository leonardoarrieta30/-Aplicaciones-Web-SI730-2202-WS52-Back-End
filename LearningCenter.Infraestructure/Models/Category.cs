namespace LearningCenter.Infraestructure;


public class Category :BaseModel
{
    public int Id { get; set; }
    public int Name { get; set; }

    private List<Tutorial> Tutorials { get; set; }
    
    
}