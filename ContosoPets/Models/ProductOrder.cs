using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Models
{
    public class ProductOrder // This intersection table facilitates many to many relationships (since it has navigation properties for both Order and Product (at the bottom))
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; } // this represent foreign key relationships and arent strictly required
        public int OrderId { get; set; } // this represent foreign key relationships and arent strictly required

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
