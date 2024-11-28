using System.ComponentModel.DataAnnotations;

namespace TaskyAPI.RequestModels;

public class UTaskEndModel
{
    /*[Required] 
    public int IdTask { get; set; }*/
    
    [Required]
    public DateTime EndDate { get; set; }
}