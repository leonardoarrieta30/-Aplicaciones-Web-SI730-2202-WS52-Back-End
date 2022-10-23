namespace LearningCenter.Infraestructure;

public abstract class BaseModel
{
    public DateTime DateCreated { get; set; }
    public DateTime DateUpdated { get; set; }
    //para eliminar a nivel logico:
    public bool IsActive { get; set; }
}