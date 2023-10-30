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
    public partial class users_list_form : Form
    {
        public users_list_form()
        {
            InitializeComponent();
        }

        private void users_list_form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'user_tbl.User_tbl' table. You can move, or remove it, as needed.
            this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DosaShop.user_form.register_user frm = new register_user();
            int i;
            int.TryParse(this.sel_id_lbl.Text, out i);
            frm.sel_id_lb.Text = i.ToString();
            frm.ShowDialog();
            frm.Dispose();

            this.user_tblTableAdapter.Fill(this.user_tbl.User_tbl);
        }

        private void user_tblDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}