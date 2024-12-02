using TaskyAPI.Models;

namespace TaskyAPI.RequestModels;

public class UTaskSubordinatesModel
{
    public int IdUser { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<UTask>? UTasks { get; set; }
}