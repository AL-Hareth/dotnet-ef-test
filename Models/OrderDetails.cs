using System.ComponentModel.DataAnnotations;

namespace CrashCourse.Models;

public class OrderDetails {

    [Key]
    public int Id { get; set; }
    public int Quantity { get; set; }

    // Relations
    public int ProductId { get; set; }
    public int OrderId { get; set; }

    public Order Order { get; set; } = null!;
    public Product Product { get; set; } = null!;

}
