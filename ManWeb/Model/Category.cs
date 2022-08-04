
using System.ComponentModel.DataAnnotations;

namespace ManWeb.Model;
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = null!;
    
    public int DisplayOrder { get; set; }
}