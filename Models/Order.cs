using System.ComponentModel.DataAnnotations;

namespace CrashCourse.Models;

public class Order {

    [Key]
    public int Id { get; set; }
    public DateTime OrderPlaced { get; set; }
    public DateTime OrderFullfilled { get; set; }

    // Relation Stuff with the customer
    public int CustomerId { get; set; }
    public Customer Customer { get; set; } = null!;

    public ICollection<OrderDetails> OrderDetails { get; set; }

}
