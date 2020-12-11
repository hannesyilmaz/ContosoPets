using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; } // even if we dont add this entity framework will create this as a shadow property

        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; } // Here the navigation property is pointing to the intersaction table (ProductOrder)
    }
}
