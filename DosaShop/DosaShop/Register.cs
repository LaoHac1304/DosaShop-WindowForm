using DosaShop.data_set;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void user_tblBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.user_tblBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.user_tbl);

        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_tbl.User_tbl' table. You can move, or remove it, as needed.
            this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);
            this.user_tblBindingSource.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.user_tblBindingSource.EndEdit();
                int isUpdate = this.user_tblTableAdapter.Update(user_tbl.User_tbl);
                if (isUpdate > 0)
                {
                    MessageBox.Show("Saved! Count: " + isUpdate.ToString());
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nothing is updated!");
                    return;
                }
            }
            catch (NoNullAllowedException)
            {
                MessageBox.Show("Please finish the field input!");
                return;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}