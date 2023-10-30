using DosaShop.data_set;
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
    public partial class OrderHistory : Form
    {
        
        public List<Int32> OrderIDList = new List<Int32>();
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void order_DetailBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_DetailBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.orderDetail);

        }

        

        private void OrderHistory_Load(object sender, EventArgs e)
        {

            data_set.OrderDetail combinedOrderDetail = new data_set.OrderDetail();
            foreach (Int32 orderId in OrderIDList)
            {
               
               this.order_DetailTableAdapter.Fill(orderDetail.Order_Detail, orderId);
               combinedOrderDetail.Merge(orderDetail.Order_Detail);
                
            }
            //this.order_DetailTableAdapter.FillBy(combinedOrderDetail.Order_Detail);
            dgrvOrderHistory.DataSource= combinedOrderDetail.Order_Detail;
            dgrvOrderHistory.AutoGenerateColumns = true;


        }
    }
}
