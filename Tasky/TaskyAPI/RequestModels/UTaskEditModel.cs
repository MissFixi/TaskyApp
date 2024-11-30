using System.ComponentModel.DataAnnotations;

namespace TaskyAPI.RequestModels;

public class UTaskEditModel
{
    [MaxLength(40)]
    public string Heading { get; set; }
    
    [Range(1,5)]
    public int Priority { get; set; }
    
    [MaxLength(100)]
    public string Description { get; set; }
    
    public Boolean IsPublic { get; set; }
}