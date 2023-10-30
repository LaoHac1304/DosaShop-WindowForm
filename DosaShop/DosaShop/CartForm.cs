using DosaShop.data_set.productTableAdapters;
using DosaShop.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static DosaShop.data_set.product;

namespace DosaShop
{
    public partial class CartForm : Form
    {

        public List<Int32> chooseList = new List<Int32>();
        public CartForm()
        {
            InitializeComponent();
        }

        

        private void CartForm_Load(object sender, EventArgs e)
        {
            this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);

            
            ProductDataTable dataTable = new ProductDataTable();
            ProductTableAdapter adapter= new ProductTableAdapter();
            dataTable.BeginLoadData();
            adapter.FillByIdList(dataTable, chooseList);
            
            dataTable.EndLoadData();

            productDataGridView.DataSource = dataTable;  


        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            // name, price, description, quantity
            int i = 0;
            List<OrderDetail> orderDetails= new List<OrderDetail>();
            foreach (DataGridViewRow row in productDataGridView.Rows)
            {
                int id = Convert.ToInt32(productDataGridView.Rows[i].Cells[0].Value);
                string name = productDataGridView.Rows[i].Cells[1].Value.ToString();
                string description = productDataGridView.Rows[i].Cells[3].Value.ToString();
                int price = Convert.ToInt32(productDataGridView.Rows[i].Cells[2].Value);
                int quantity = Convert.ToInt32(productDataGridView.Rows[i].Cells[7].Value);
                i++;
                OrderDetail orderDetail = new OrderDetail(i, name, price, quantity, description,0,id);   
                orderDetails.Add(orderDetail);

            }
            CheckoutForm checkoutForm= new CheckoutForm();
            checkoutForm.orderDetails= orderDetails;
            checkoutForm.ShowDialog();
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
