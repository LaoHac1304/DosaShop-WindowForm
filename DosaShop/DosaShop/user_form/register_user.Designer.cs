namespace DosaShop.user_form
{
    partial class register_user
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
            this.user_imgLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.display_nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roleLabel1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edit_butt = new System.Windows.Forms.Button();
            this.cancel_butt = new System.Windows.Forms.Button();
            this.save_butt = new System.Windows.Forms.Button();
            this.del_butt = new System.Windows.Forms.Button();
            this.new_butt = new System.Windows.Forms.Button();
            this.user_tblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_tbl = new DosaShop.data_set.user_tbl();
            this.user_tblTableAdapter = new DosaShop.data_set.user_tblTableAdapters.User_tblTableAdapter();
            this.tableAdapterManager = new DosaShop.data_set.user_tblTableAdapters.TableAdapterManager();
            this.user_imgTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.display_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.repeat_pass_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sel_id_lb = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user_tblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_imgLabel
            // 
            this.user_imgLabel.AutoSize = true;
            this.user_imgLabel.Location = new System.Drawing.Point(71, 292);
            this.user_imgLabel.Name = "user_imgLabel";
            this.user_imgLabel.Size = new System.Drawing.Size(61, 16);
            this.user_imgLabel.TabIndex = 16;
            this.user_imgLabel.Text = "user img:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(71, 234);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(48, 16);
            this.phoneLabel.TabIndex = 12;
            this.phoneLabel.Text = "phone:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(71, 206);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(43, 16);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "email:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(71, 178);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(60, 16);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "address:";
            // 
            // display_nameLabel
            // 
            this.display_nameLabel.AutoSize = true;
            this.display_nameLabel.Location = new System.Drawing.Point(71, 150);
            this.display_nameLabel.Name = "display_nameLabel";
            this.display_nameLabel.Size = new System.Drawing.Size(91, 16);
            this.display_nameLabel.TabIndex = 6;
            this.display_nameLabel.Text = "display name:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(71, 93);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(69, 16);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(71, 65);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(70, 16);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "username:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(71, 37);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 16);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "re-password:";
            // 
            // roleLabel1
            // 
            this.roleLabel1.AutoSize = true;
            this.roleLabel1.Location = new System.Drawing.Point(71, 264);
            this.roleLabel1.Name = "roleLabel1";
            this.roleLabel1.Size = new System.Drawing.Size(33, 16);
            this.roleLabel1.TabIndex = 22;
            this.roleLabel1.Text = "role:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.edit_butt);
            this.panel1.Controls.Add(this.cancel_butt);
            this.panel1.Controls.Add(this.save_butt);
            this.panel1.Controls.Add(this.del_butt);
            this.panel1.Controls.Add(this.new_butt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 87);
            this.panel1.TabIndex = 0;
            // 
            // edit_butt
            // 
            this.edit_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_butt.Image = global::DosaShop.Properties.Resources.edit_button;
            this.edit_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_butt.Location = new System.Drawing.Point(216, 22);
            this.edit_butt.Name = "edit_butt";
            this.edit_butt.Size = new System.Drawing.Size(103, 43);
            this.edit_butt.TabIndex = 4;
            this.edit_butt.Text = "Edit User";
            this.edit_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_butt.UseVisualStyleBackColor = true;
            this.edit_butt.Click += new System.EventHandler(this.edit_butt_Click);
            // 
            // cancel_butt
            // 
            this.cancel_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel_butt.Image = global::DosaShop.Properties.Resources.cancel_button;
            this.cancel_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancel_butt.Location = new System.Drawing.Point(674, 21);
            this.cancel_butt.Name = "cancel_butt";
            this.cancel_butt.Size = new System.Drawing.Size(103, 43);
            this.cancel_butt.TabIndex = 3;
            this.cancel_butt.Text = "Cancel";
            this.cancel_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancel_butt.UseVisualStyleBackColor = true;
            this.cancel_butt.Click += new System.EventHandler(this.cancel_butt_Click);
            // 
            // save_butt
            // 
            this.save_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_butt.Image = global::DosaShop.Properties.Resources.save_button;
            this.save_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_butt.Location = new System.Drawing.Point(533, 21);
            this.save_butt.Name = "save_butt";
            this.save_butt.Size = new System.Drawing.Size(103, 43);
            this.save_butt.TabIndex = 2;
            this.save_butt.Text = "Save";
            this.save_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.save_butt.UseVisualStyleBackColor = true;
            this.save_butt.Click += new System.EventHandler(this.save_butt_Click);
            // 
            // del_butt
            // 
            this.del_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_butt.Image = global::DosaShop.Properties.Resources.delete_button;
            this.del_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_butt.Location = new System.Drawing.Point(375, 21);
            this.del_butt.Name = "del_butt";
            this.del_butt.Size = new System.Drawing.Size(103, 43);
            this.del_butt.TabIndex = 1;
            this.del_butt.Text = "Delete";
            this.del_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.del_butt.UseVisualStyleBackColor = true;
            this.del_butt.Click += new System.EventHandler(this.del_butt_Click);
            // 
            // new_butt
            // 
            this.new_butt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_butt.Image = global::DosaShop.Properties.Resources.new_button;
            this.new_butt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_butt.Location = new System.Drawing.Point(21, 22);
            this.new_butt.Name = "new_butt";
            this.new_butt.Size = new System.Drawing.Size(144, 43);
            this.new_butt.TabIndex = 0;
            this.new_butt.Text = "New User";
            this.new_butt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.new_butt.UseVisualStyleBackColor = true;
            this.new_butt.Click += new System.EventHandler(this.new_butt_Click);
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
            // user_imgTextBox
            // 
            this.user_imgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "user_img", true));
            this.user_imgTextBox.Location = new System.Drawing.Point(168, 289);
            this.user_imgTextBox.Name = "user_imgTextBox";
            this.user_imgTextBox.Size = new System.Drawing.Size(332, 22);
            this.user_imgTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(168, 231);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(332, 22);
            this.phoneTextBox.TabIndex = 13;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(168, 203);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(332, 22);
            this.emailTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(168, 175);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(332, 22);
            this.addressTextBox.TabIndex = 9;
            // 
            // display_nameTextBox
            // 
            this.display_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "display_name", true));
            this.display_nameTextBox.Location = new System.Drawing.Point(168, 147);
            this.display_nameTextBox.Name = "display_nameTextBox";
            this.display_nameTextBox.Size = new System.Drawing.Size(332, 22);
            this.display_nameTextBox.TabIndex = 7;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(168, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(332, 22);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.passwordTextBox_Validating);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(168, 62);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(332, 22);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.usernameTextBox_Validating);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(168, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(332, 22);
            this.idTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.user_tblBindingSource, "image", true));
            this.pictureBox1.Location = new System.Drawing.Point(570, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 45);
            this.button1.TabIndex = 19;
            this.button1.Text = "Select User Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.roleLabel1);
            this.groupBox1.Controls.Add(this.roleTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.repeat_pass_tb);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.usernameLabel);
            this.groupBox1.Controls.Add(this.usernameTextBox);
            this.groupBox1.Controls.Add(this.passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(this.display_nameLabel);
            this.groupBox1.Controls.Add(this.display_nameTextBox);
            this.groupBox1.Controls.Add(this.addressLabel);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.phoneLabel);
            this.groupBox1.Controls.Add(this.phoneTextBox);
            this.groupBox1.Controls.Add(this.user_imgLabel);
            this.groupBox1.Controls.Add(this.user_imgTextBox);
            this.groupBox1.Location = new System.Drawing.Point(22, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 384);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "info";
            // 
            // roleTextBox
            // 
            this.roleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.user_tblBindingSource, "role", true));
            this.roleTextBox.Location = new System.Drawing.Point(168, 261);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            this.roleTextBox.Size = new System.Drawing.Size(332, 22);
            this.roleTextBox.TabIndex = 23;
            this.roleTextBox.Text = "0";
            // 
            // repeat_pass_tb
            // 
            this.repeat_pass_tb.Location = new System.Drawing.Point(168, 119);
            this.repeat_pass_tb.Name = "repeat_pass_tb";
            this.repeat_pass_tb.Size = new System.Drawing.Size(332, 22);
            this.repeat_pass_tb.TabIndex = 20;
            this.repeat_pass_tb.UseSystemPasswordChar = true;
            this.repeat_pass_tb.Validating += new System.ComponentModel.CancelEventHandler(this.repeat_pass_tb_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(783, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sel ID:";
            // 
            // sel_id_lb
            // 
            this.sel_id_lb.AutoSize = true;
            this.sel_id_lb.Location = new System.Drawing.Point(835, 138);
            this.sel_id_lb.Name = "sel_id_lb";
            this.sel_id_lb.Size = new System.Drawing.Size(14, 16);
            this.sel_id_lb.TabIndex = 3;
            this.sel_id_lb.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Images|*.JPG;*.BMP;*.PNG|JPG Files|*.JPG";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // register_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 488);
            this.Controls.Add(this.sel_id_lb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "register_user";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register User";
            this.Load += new System.EventHandler(this.register_user_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.user_tblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_tbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button edit_butt;
        private System.Windows.Forms.Button cancel_butt;
        private System.Windows.Forms.Button save_butt;
        private System.Windows.Forms.Button del_butt;
        private System.Windows.Forms.Button new_butt;
        private data_set.user_tbl user_tbl;
        private System.Windows.Forms.BindingSource user_tblBindingSource;
        private data_set.user_tblTableAdapters.User_tblTableAdapter user_tblTableAdapter;
        private data_set.user_tblTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox user_imgTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox display_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox repeat_pass_tb;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label sel_id_lb;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label user_imgLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label display_nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleLabel1;
    }
}