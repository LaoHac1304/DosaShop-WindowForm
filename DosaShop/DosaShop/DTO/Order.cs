using DosaShop.data_set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosaShop.DTO
{
    public class Order
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Total { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }


        public Order(int id, int userId, string customerName, DateTime orderDate, int total, string phoneNumber, string address)
        {
            Id = id;
            UserId = userId;
            CustomerName = customerName;
            OrderDate = orderDate;
            Total = total;
            PhoneNumber = phoneNumber;
            Address = address;
        }   
    }
}
