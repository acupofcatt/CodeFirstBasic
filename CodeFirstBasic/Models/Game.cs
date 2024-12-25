using System.ComponentModel.DataAnnotations;

namespace CodeFirstBasic.Models;

public class Game
{
    [Key]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public string Platform { get; set; }
    
    [Range (1.0, 10.0)]
    public decimal Rating { get; set; }
}