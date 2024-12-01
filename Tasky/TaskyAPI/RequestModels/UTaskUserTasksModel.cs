using System.ComponentModel.DataAnnotations;

namespace TaskyAPI.RequestModels;

public class UTaskUserTasksModel
{
    public int IdTask { get; set; }
    
    public string Heading { get; set; }
    
    public int Priority { get; set; }
    
    public string Description { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public Boolean IsPublic { get; set; }
    
    
}