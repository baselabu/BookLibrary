using System.ComponentModel.DataAnnotations;
namespace CRUD_Application.Models;

public class Books
{
    [Key]
    public int Bookid { get; set; } 
    
    [Required]
    public string? BookTitle { get; set; }

    [Required]
    public string? BookDescription { get; set; }
    
    [Required]
    public string? BookAuthor { get; set; }

}
