using DosaShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosaShop
{
    public partial class CheckoutForm : Form
    {

        public List<OrderDetail> orderDetails = new List<OrderDetail>();

        private int total;
        public CheckoutForm()
        {
            InitializeComponent();
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            total = 0;
            foreach (var orderDetail in orderDetails)
            {
                total += orderDetail.TotalPrice;
            }
            txtTotal.Text = total.ToString();
            dgrvOrderDetails.DataSource = orderDetails;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment completed successfully");
            this.Hide();
            Login mainForm = (Login)Application.OpenForms["Login"];

            // Get the current user from the main form
            UserInfo currentUser = mainForm.CurrentUser;
            int userId = 0;
            if (currentUser != null) 
            {
                userId = currentUser.Id;    
            }
            Order order = new Order(0,userId,currentUser.Username,DateTime.Now,total,currentUser.Phone,currentUser.Address);
            OrderRepository orderRepository = new OrderRepository();
            int orderId = orderRepository.InsertOrder(order);
            foreach (var orderDetail in orderDetails)
            {
                orderDetail.OrderId = orderId;
                orderRepository.InsertOrderDetail(orderDetail);
            }
            ProductForm productForm= new ProductForm();
            productForm.ShowDialog();
        }
    }
}
