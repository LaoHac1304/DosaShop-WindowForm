using DosaShop.data_set.productTableAdapters;
using DosaShop.data_set.user_tblTableAdapters;
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
    public partial class Login : Form
    {
        public UserInfo CurrentUser { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void user_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.user_tbl);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_tbl.User_tbl' table. You can move, or remove it, as needed.
            this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);

        }

        private void user_tblBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (authenticated(username, password))
            {
               
                MessageBox.Show("sucessful");
                DosaShop.data_set.user_tbl.User_tblDataTable user_tblDataTable = new data_set.user_tbl.User_tblDataTable();
                User_tblTableAdapter adapter = new User_tblTableAdapter();
                user_tblDataTable.BeginLoadData();
                adapter.FillByUsername(user_tblDataTable, username);
                user_tblDataTable.EndLoadData();

                var id = Convert.ToInt32(user_tblDataTable.Rows[0]["id"]);
                var usernamee = user_tblDataTable.Rows[0]["username"];
                var passwordd = user_tblDataTable.Rows[0]["password"];
                var display_name = user_tblDataTable.Rows[0]["display_name"].ToString();
                var address = user_tblDataTable.Rows[0]["address"].ToString();
                var email = user_tblDataTable.Rows[0]["email"].ToString();
                var phone = user_tblDataTable.Rows[0]["phone"].ToString();
                bool role = false;
                if (user_tblDataTable.Rows[0]["role"] != DBNull.Value && user_tblDataTable.Rows[0]["role"] != null)
                    role = (bool) user_tblDataTable.Rows[0]["role"];
                //var user_img = user_tblDataTable.Rows[0]["user_img"].ToString();
                var user_img = "";
                UserInfo user = new UserInfo(id, username, email, password, phone, address, display_name, role, user_img);
                
                Login app = (Login)Application.OpenForms["Login"];
                app.CurrentUser = user;
                this.Hide();
                ProductForm productForm= new ProductForm();
                productForm.ShowDialog();

            } else
            {
                MessageBox.Show("failed");
            }
        }
        private Boolean  authenticated(String username, String password)
        {
            Int32 resultRow;
            resultRow = this.user_tblTableAdapter.Authenticated(this.user_tbl.User_tbl, username, password);
            if (resultRow > 0)
            {
                return true;
            }
            return false;
        }

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
    }
}
