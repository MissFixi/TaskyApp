using System.ComponentModel.DataAnnotations;

namespace TaskyAPI.RequestModels;

public class UTaskStatisticsModel
{
    /*public int Month { get; set; }
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int TasksCount { get; set; }*/
    public int Month { get; set; }
    public int IdUser { get; set; }
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public int TasksCount { get; set; }
}