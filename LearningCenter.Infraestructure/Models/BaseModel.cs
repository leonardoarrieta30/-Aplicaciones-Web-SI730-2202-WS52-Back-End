namespace LearningCenter.Infraestructure;

public abstract class BaseModel
{
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    //para eliminar a nivel logico:
    
    //porque en si en la actualidad ya no se elimina si no se hace un backup
    public bool IsActive { get; set; }
}