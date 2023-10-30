using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosaShop.DTO
{
    public class OrderDetail
    {
        [Browsable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        
        public string Description { get; set; }
        public int TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
            set
            {

            }
        }
        [Browsable(false)]
        public int OrderId { get; set; }

        [Browsable(false)]
        public int ProductID { get; set; }

        public OrderDetail(int id, string name, int price, int quantity, string description, int orderId, int productID)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
            Description = description;
            OrderId = orderId;
            this.ProductID = productID;
        }
    }
}
