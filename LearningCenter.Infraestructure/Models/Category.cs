namespace LearningCenter.Infraestructure;


public class Category :BaseModel
{
    public int Id { get; set; }
    public string Name { get; set; }

    public string Description { get; set; }
    
    public int? Quantity { get; set; }
    
    
    //ejemplo.- categoria programacion me deberian salir todos los tutoriales de programacion asignados
    //mecanica-> todos los tutoriasles de mecanica
    
    public List<Tutorial>? Tutorials { get; set; }
    
    
}