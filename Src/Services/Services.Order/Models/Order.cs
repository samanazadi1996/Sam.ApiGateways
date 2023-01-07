using System;

namespace Services.Order.Models
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int id, int personId, long totalPrice)
        {
            Id = id;
            PersonId = personId;
            TotalPrice = totalPrice;
            OrderDate = DateTime.Now;
        }
        public int Id { get; set; }
        public int PersonId { get; set; }
        public DateTime OrderDate { get; set; }
        public long TotalPrice { get; set; }
    }
}
