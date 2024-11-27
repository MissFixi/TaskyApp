using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyAPI.Models;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdUser { get; set; }
    
    [Required]
    [MaxLength(35)] 
    public string FirstName { get; set; }
    
    [Required]
    [MaxLength(40)]
    public string LastName { get; set; }
    public int? IdManager { get; set; }
    
    [ForeignKey(nameof(IdManager))]
    public User IdManagerId { get; set; }
    
    public ICollection<UTask> UTasks { get; set; }
}