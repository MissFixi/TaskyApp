using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskyAPI.Models;

public class UTask
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int IdTask { get; set; }
    
    [Required]
    [MaxLength(40)]
    public string Heading { get; set; }
    
    [Required]
    [Range(1,5)]
    public int Priority { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Description { get; set; }
    
    [Required]
    public DateTime StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    [Required]
    public int IdUser { get; set; }
    
    [ForeignKey(nameof(IdUser))]
    public User TaskUser { get; set; }
    
    
}