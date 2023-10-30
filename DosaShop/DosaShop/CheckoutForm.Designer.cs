namespace DosaShop
{
    partial class CheckoutForm
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
            this.dgrvOrderDetails = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.Total = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrvOrderDetails
            // 
            this.dgrvOrderDetails.AllowUserToAddRows = false;
            this.dgrvOrderDetails.AllowUserToDeleteRows = false;
            this.dgrvOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvOrderDetails.Location = new System.Drawing.Point(65, 72);
            this.dgrvOrderDetails.Name = "dgrvOrderDetails";
            this.dgrvOrderDetails.RowHeadersWidth = 51;
            this.dgrvOrderDetails.RowTemplate.Height = 24;
            this.dgrvOrderDetails.Size = new System.Drawing.Size(755, 325);
            this.dgrvOrderDetails.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(658, 423);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(162, 84);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm and checkout";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(826, 221);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(38, 16);
            this.Total.TabIndex = 4;
            this.Total.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(870, 219);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 22);
            this.txtTotal.TabIndex = 5;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 544);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.dgrvOrderDetails);
            this.Name = "CheckoutForm";
            this.Text = "CheckoutForm";
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrvOrderDetails;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox txtTotal;
    }
}