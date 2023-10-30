using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using DosaShop.DTO;
using DosaShop.data_set;
using DosaShop.data_set.OrderTableAdapters;
using static DosaShop.data_set.Order;
using DosaShop.user_form;

namespace DosaShop
{
    public partial class ProductForm : Form
    {
        private System.Windows.Forms.ListBox lbProducts;
        private List<Int32> chooseList= new List<Int32>();
        public ProductForm()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.product);

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            // Get the current user from the main form
            Login mainForm = (Login)Application.OpenForms["Login"];
            UserInfo currentUser = mainForm.CurrentUser;
            lblUsername.Text = currentUser.Username;
            lblUserID.Text = currentUser.Id.ToString();

            if (!currentUser.Role)
                this.btnProduct.Visible = false;
            this.productTableAdapter.Fill(this.product.Product);
            

        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //object objp = productChoosen.TrueValue;
            //String str = objp.ToString();


            var cartForm = new CartForm();
            cartForm.chooseList = chooseList;
            cartForm.Show();


        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 productId = (Int32)productDataGridView.Rows[e.RowIndex].Cells[1].Value;
            chooseList.Add(productId);
            
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManager productManager= new ProductManager();
            productManager.ShowDialog();
        }

        /*private void btnOrderHistory_Click(object sender, EventArgs e, data_set.Order order)
        {
            // Get the current user from the main form
            Login mainForm = (Login)Application.OpenForms["Login"];
            UserInfo currentUser = mainForm.CurrentUser;
            int userId = currentUser.Id;

            OrderTableAdapter orderTableAdapter= new OrderTableAdapter();
            DosaShop.data_set.Order orderDataset = new DosaShop.data_set.Order();
            OrderDataTable orderTable = orderDataset.Tables["Order"] as OrderDataTable;
            orderTableAdapter.Fill(orderTable,userId);
            int orderId = Convert.ToInt32(orderTable.Rows[0]["id"]);
            OrderHistory orderHistory= new OrderHistory();
            orderHistory.OrderID= orderId;
            orderHistory.ShowDialog();

        }*/

        private void btnOrderHistory_Click(object sender, EventArgs e)
        {
            // Get the current user from the main form
            Login mainForm = (Login)Application.OpenForms["Login"];
            UserInfo currentUser = mainForm.CurrentUser;
            int userId = currentUser.Id;

            OrderTableAdapter orderTableAdapter = new OrderTableAdapter();
            DosaShop.data_set.Order orderDataset = new DosaShop.data_set.Order();
            OrderDataTable orderTable = orderDataset.Tables["Order"] as OrderDataTable;
            int row = orderTableAdapter.Fill(orderTable, userId);
            List<Int32> orderIdList = new List<Int32>();
            for (int i = 0; i < row; i++)
            {
                int orderId = Convert.ToInt32(orderTable.Rows[i]["id"]);
                orderIdList.Add(orderId);
            }
            OrderHistory orderHistory = new OrderHistory();
            orderHistory.OrderIDList = orderIdList;
            orderHistory.ShowDialog();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            users_list_form users_List_Form = new users_list_form();
            users_List_Form.ShowDialog();
        }
    }
}
