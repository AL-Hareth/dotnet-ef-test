using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrashCourse.Models;

public class Product {

    [Key] // <- This is a primary key indicator
    public int Id { get; set; }
    [Required] // <- This means that even if this field is nullable it shouldm't go to the db as null
    public string? Name { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }

}
