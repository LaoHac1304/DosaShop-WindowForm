using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosaShop.user_form
{
    public partial class register_user : Form
    {
        public register_user()
        {
            InitializeComponent();
        }

        private void register_user_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_tbl.User_tbl' table. You can move, or remove it, as needed.
            // this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);
            int i;
            int.TryParse(this.sel_id_lb.Text, out i);
            this.user_tblTableAdapter.FillBy_id(this.user_tbl.User_tbl, i);
            //-------------------------------------------------------------------------------------------
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;

            this.groupBox1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void enable_disable_new_edit_del_butt()
        {
            this.new_butt.Enabled = false;
            this.edit_butt.Enabled = false;
            this.del_butt.Enabled = false;

            this.save_butt.Enabled = true;
            this.cancel_butt.Enabled = true;

            this.groupBox1.Enabled = true;
        }

        private void new_butt_Click(object sender, EventArgs e)
        {
            enable_disable_new_edit_del_butt();
            this.user_tblBindingSource.AddNew();
        }

        private void edit_butt_Click(object sender, EventArgs e)
        {
            int i;
            i = this.user_tbl.User_tbl.Rows.Count;
            if (i == 0)
            {
                MessageBox.Show("Select what you want to edit!");
                return;
            }

            enable_disable_new_edit_del_butt();

        }

        private void del_butt_Click(object sender, EventArgs e)
        {
            int i;
            i = this.user_tbl.User_tbl.Rows.Count;
            if (i == 0)
            {
                MessageBox.Show("Select what you want to delete!");
                return;
            }

            enable_disable_new_edit_del_butt();

            this.groupBox1.Enabled = false;
            this.user_tblBindingSource.RemoveCurrent();
        }

        private void save_butt_Click(object sender, EventArgs e)
        {

            enable_disable_save_cancel_butt();


            this.user_tblBindingSource.EndEdit();

            int i;
            i = this.user_tblTableAdapter.Update(this.user_tbl.User_tbl);
            if (i > 0)
            {
                fillby_data();
                MessageBox.Show("Saved!");
            }
            else
            {
                MessageBox.Show("Nothing saved!");
            }
        }
        void fillby_data()
        {
            int i;
            int.TryParse(this.idTextBox.Text, out i);
            this.user_tblTableAdapter.FillBy_id(this.user_tbl.User_tbl, i);
        }
        private void cancel_butt_Click(object sender, EventArgs e)
        {
            enable_disable_save_cancel_butt();
            this.user_tblBindingSource.CancelEdit();
            this.user_tbl.User_tbl.RejectChanges();
        }

        void enable_disable_save_cancel_butt()
        {
            this.new_butt.Enabled = true;
            this.edit_butt.Enabled = true;
            this.del_butt.Enabled = true;
            this.save_butt.Enabled = false;
            this.cancel_butt.Enabled = false;

            this.groupBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string si;
            si = this.openFileDialog1.FileName;
            if (si == "openFileDialog1")
            {
                return;
            }

            this.pictureBox1.Image = Image.FromFile(si);
        }

        private void usernameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(usernameTextBox.Text))
            {
                e.Cancel = true;
                usernameTextBox.Focus();
                errorProvider1.SetError(usernameTextBox, "cant blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(usernameTextBox, null);
            }
        }

        private void passwordTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                e.Cancel = true;
                passwordTextBox.Focus();
                errorProvider1.SetError(passwordTextBox, "Password is required.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(passwordTextBox, null);
            }
        }

        private void repeat_pass_tb_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(repeat_pass_tb.Text))
            {
                e.Cancel = true;
                repeat_pass_tb.Focus();
                errorProvider1.SetError(repeat_pass_tb, "Repeat Password is required.");
            }
            else if (!string.Equals(passwordTextBox.Text, repeat_pass_tb.Text))
            {
                e.Cancel = true;
                repeat_pass_tb.Focus();
                errorProvider1.SetError(repeat_pass_tb, "Passwords do not match.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(repeat_pass_tb, null);
            }
        }
    }
}
