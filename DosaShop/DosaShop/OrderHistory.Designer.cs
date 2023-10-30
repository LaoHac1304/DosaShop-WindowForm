namespace DosaShop
{
    partial class OrderHistory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderDetail = new DosaShop.data_set.OrderDetail();
            this.order_DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_DetailTableAdapter = new DosaShop.data_set.OrderDetailTableAdapters.Order_DetailTableAdapter();
            this.tableAdapterManager = new DosaShop.data_set.OrderDetailTableAdapters.TableAdapterManager();
            this.dgrvOrderHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // orderDetail
            // 
            this.orderDetail.DataSetName = "OrderDetail";
            this.orderDetail.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // order_DetailBindingSource
            // 
            this.order_DetailBindingSource.DataMember = "Order_Detail";
            this.order_DetailBindingSource.DataSource = this.orderDetail;
            // 
            // order_DetailTableAdapter
            // 
            this.order_DetailTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Order_DetailTableAdapter = this.order_DetailTableAdapter;
            this.tableAdapterManager.UpdateOrder = DosaShop.data_set.OrderDetailTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dgrvOrderHistory
            // 
            this.dgrvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvOrderHistory.Location = new System.Drawing.Point(109, 61);
            this.dgrvOrderHistory.Name = "dgrvOrderHistory";
            this.dgrvOrderHistory.RowHeadersWidth = 51;
            this.dgrvOrderHistory.RowTemplate.Height = 24;
            this.dgrvOrderHistory.Size = new System.Drawing.Size(551, 308);
            this.dgrvOrderHistory.TabIndex = 0;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgrvOrderHistory);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private data_set.OrderDetail orderDetail;
        private System.Windows.Forms.BindingSource order_DetailBindingSource;
        private data_set.OrderDetailTableAdapters.Order_DetailTableAdapter order_DetailTableAdapter;
        private data_set.OrderDetailTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgrvOrderHistory;
    }
}