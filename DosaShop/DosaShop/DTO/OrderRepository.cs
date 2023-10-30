using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosaShop.DTO
{
    public class OrderRepository
    {
        private String connectionString = "Data Source=LAOHAC\\LAOHAC;Initial Catalog=Dosa_Store;User ID=sa;Password=12345;";
        
        public OrderRepository() { }
        public OrderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public int InsertOrder(Order order)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                //SqlCommand command = new SqlCommand("INSERT INTO [Order] (user_id, Order_date, Total) VALUES (@userId, @orderDate, @total); SELECT SCOPE_IDENTITY();", connection);
                SqlCommand command = new SqlCommand("INSERT INTO [Order] (Order_date, Total, user_id, name, phone, address) VALUES (@orderDate, @total, @userid, @name, @phone, @address); SELECT SCOPE_IDENTITY();", connection);

                //command.Parameters.AddWithValue("@userId", order.UserId);
                command.Parameters.AddWithValue("@orderDate", order.OrderDate);
                command.Parameters.AddWithValue("@total", order.Total);
                command.Parameters.AddWithValue("@userid", order.UserId);
                command.Parameters.AddWithValue("@name", order.CustomerName);
                command.Parameters.AddWithValue("@phone", order.PhoneNumber);
                command.Parameters.AddWithValue("@address", order.Address);
                return Convert.ToInt32(command.ExecuteScalar());
            }
        }
        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Order_Detail (order_id, product_id, price, quantity, name) VALUES (@orderId, @productId, @price, @quantity, @name); SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@orderId", orderDetail.OrderId);
                command.Parameters.AddWithValue("@productId", orderDetail.ProductID);
                command.Parameters.AddWithValue("@price", orderDetail.Price);
                command.Parameters.AddWithValue("@quantity", orderDetail.Quantity);
                command.Parameters.AddWithValue("@name", orderDetail.Name);
                command.ExecuteNonQuery();
            }
        }
    }
}
