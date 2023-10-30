using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DosaShop
{
    public partial class ProductManager : Form
    {
        public ProductManager()
        {
            InitializeComponent();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            this.productTableAdapter.Fill(this.product1.Product);
            this.lblTotal.Text = this.productTableAdapter.TotalProduct().ToString();
            this.label6.Text = DateTime.Now.ToString();
            //----------------------------------------
            this.panel3.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }



        private void enable_Save_Cancel()
        {
            this.btnNew.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            //-----------------------------
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
        }

        public void validateCRUD()
        {
            int rc = this.product1.Product.Rows.Count;
            if (rc == 0)
            {
                MessageBox.Show("Select your record to edit!");
                return;
            }
        }

        private void enable_Add_Edit_Delete()
        {
            this.btnNew.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            //-----------------------------
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            enable_Save_Cancel();
            this.panel3.Enabled = true;
            this.productDataGridView.Enabled = false;
            //--------------------------
            this.productBindingSource1.AddNew();
            //----------------------------------
            this.created_dateDateTimePicker.Text = DateTime.Now.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            enable_Save_Cancel();
            this.panel3.Enabled = true;
            validateCRUD();
            //-------------------------
            this.created_dateDateTimePicker.Text = DateTime.Now.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            enable_Save_Cancel();
            validateCRUD();
            //-----------------------------
            DialogResult result
                = MessageBox.Show("Do you want to delete the product: " + this.nameTextBox.Text, "Confirm", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.productBindingSource1.RemoveCurrent();
                MessageBox.Show("Deleted!");
                enable_Add_Edit_Delete();
            }
            else
            {
                btnCancel_Click(sender, e);
            }
            //------------------------------
            this.panel3.Enabled = false;
            this.productDataGridView.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            enable_Add_Edit_Delete();
            validateCRUD();
            //-----------------------
            try
            {
                this.productBindingSource1.EndEdit();
                int isUpdate = this.productTableAdapter.Update(product1.Product);
                if (isUpdate > 0)
                {
                    MessageBox.Show("Saved! Count: " + isUpdate.ToString());
                    this.lblTotal.Text = this.productTableAdapter.TotalProduct().ToString();
                    
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
                btnCancel_Click(sender, e);
                this.productDataGridView.Enabled = true;
                return;
            }

            //-----------------------------
            this.panel3.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            enable_Add_Edit_Delete();
            validateCRUD();
            //-------------------------------
            this.productBindingSource1.CancelEdit();
            this.product1.Product.RejectChanges();
            //-----------------------------
            this.panel3.Enabled = false;
            this.productDataGridView.Enabled = true;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog(this);
            string fn = this.openFileDialog1.FileName;
            if (fn == "openFileDialog1")
            {
                return;
            }
            this.image_linkPictureBox.Image = Image.FromFile(fn);
        }
    }
}
