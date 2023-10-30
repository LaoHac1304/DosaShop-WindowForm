namespace DosaShop.user_form
{
    partial class users_list_form
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
            System.Windows.Forms.Label idLabel1;
            this.user_tblDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.sel_id_lbl = new System.Windows.Forms.Label();
            this.user_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_tbl = new DosaShop.data_set.user_tbl();
            this.user_tblTableAdapter = new DosaShop.data_set.user_tblTableAdapters.User_tblTableAdapter();
            this.tableAdapterManager = new DosaShop.data_set.user_tblTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewImageColumn();
            idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_tblDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tbl)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(1101, 30);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(21, 16);
            idLabel1.TabIndex = 4;
            idLabel1.Text = "id:";
            // 
            // user_tblDataGridView
            // 
            this.user_tblDataGridView.AllowUserToAddRows = false;
            this.user_tblDataGridView.AllowUserToDeleteRows = false;
            this.user_tblDataGridView.AutoGenerateColumns = false;
            this.user_tblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.user_tblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.user_tblDataGridView.DataSource = this.user_tblBindingSource;
            this.user_tblDataGridView.Location = new System.Drawing.Point(0, 30);
            this.user_tblDataGridView.Name = "user_tblDataGridView";
            this.user_tblDataGridView.ReadOnly = true;
            this.user_tblDataGridView.RowHeadersWidth = 51;
            this.user_tblDataGridView.RowTemplate.Height = 64;
            this.user_tblDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.user_tblDataGridView.Size = new System.Drawing.Size(1090, 357);
            this.user_tblDataGridView.TabIndex = 1;
            this.user_tblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.user_tblDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.Image = global::DosaShop.Properties.Resources.add_user;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add/Edit User";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sel_id_lbl
            // 
            this.sel_id_lbl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "id", true));
            this.sel_id_lbl.Location = new System.Drawing.Point(1128, 30);
            this.sel_id_lbl.Name = "sel_id_lbl";
            this.sel_id_lbl.Size = new System.Drawing.Size(100, 23);
            this.sel_id_lbl.TabIndex = 5;
            this.sel_id_lbl.Text = "0";
            // 
            // user_tblBindingSource
            // 
            this.user_tblBindingSource.DataMember = "User_tbl";
            this.user_tblBindingSource.DataSource = this.user_tbl;
            // 
            // user_tbl
            // 
            this.user_tbl.DataSetName = "user_tbl";
            this.user_tbl.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_tblTableAdapter
            // 
            this.user_tblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DosaShop.data_set.user_tblTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User_tblTableAdapter = this.user_tblTableAdapter;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "username";
            this.dataGridViewTextBoxColumn2.HeaderText = "Username";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "display_name";
            this.dataGridViewTextBoxColumn4.HeaderText = "Display Name";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "Phone Number";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "image";
            this.dataGridViewTextBoxColumn8.HeaderText = "Image";
            this.dataGridViewTextBoxColumn8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // users_list_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 645);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.sel_id_lbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_tblDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "users_list_form";
            this.ShowIcon = false;
            this.Text = "Users List Form";
            this.Load += new System.EventHandler(this.users_list_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_tblDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private data_set.user_tbl user_tbl;
        private System.Windows.Forms.BindingSource user_tblBindingSource;
        private data_set.user_tblTableAdapters.User_tblTableAdapter user_tblTableAdapter;
        private data_set.user_tblTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView user_tblDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label sel_id_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewTextBoxColumn8;
    }
}