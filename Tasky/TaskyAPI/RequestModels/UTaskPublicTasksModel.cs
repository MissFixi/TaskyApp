using TaskyAPI.Models;

namespace TaskyAPI.RequestModels;

public class UTaskPublicTasksModel
{
    public int IdTask { get; set; }
    
    public string Heading { get; set; }
    
    public int Priority { get; set; }
    
    public string Description { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }

    /*public string FirstName { get; set; }
    
    public string LastName { get; set; }*/
}