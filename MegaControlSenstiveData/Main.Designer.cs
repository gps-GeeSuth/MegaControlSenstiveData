
namespace MegaControlSenstiveData
{
    partial class Main
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
            this.btn_setting = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tree_password = new System.Windows.Forms.TreeView();
            this.pnl_pass = new System.Windows.Forms.Panel();
            this.btn_pass_new = new System.Windows.Forms.Button();
            this.btn_pass_save = new System.Windows.Forms.Button();
            this.btn_pass_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass_url = new System.Windows.Forms.TextBox();
            this.chk_setting_show_passowrd = new System.Windows.Forms.CheckBox();
            this.txt_pass_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pass_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_saveSetting = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyUrlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_pass_edit = new System.Windows.Forms.Button();
            this.txt_pass_search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnl_pass.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_setting
            // 
            this.btn_setting.Location = new System.Drawing.Point(31, 17);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(802, 28);
            this.btn_setting.TabIndex = 0;
            this.btn_setting.Text = "Select Path";
            this.btn_setting.UseVisualStyleBackColor = true;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 392);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_pass_search);
            this.tabPage1.Controls.Add(this.btn_pass_edit);
            this.tabPage1.Controls.Add(this.btn_pass_delete);
            this.tabPage1.Controls.Add(this.btn_pass_save);
            this.tabPage1.Controls.Add(this.btn_pass_new);
            this.tabPage1.Controls.Add(this.pnl_pass);
            this.tabPage1.Controls.Add(this.tree_password);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 363);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Passwords";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btn_saveSetting);
            this.tabPage3.Controls.Add(this.chk_setting_show_passowrd);
            this.tabPage3.Controls.Add(this.btn_setting);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(862, 363);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tree_password
            // 
            this.tree_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree_password.ContextMenuStrip = this.contextMenuStrip1;
            this.tree_password.Location = new System.Drawing.Point(8, 40);
            this.tree_password.Name = "tree_password";
            this.tree_password.Size = new System.Drawing.Size(277, 315);
            this.tree_password.TabIndex = 0;
            this.tree_password.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_password_AfterSelect);
            // 
            // pnl_pass
            // 
            this.pnl_pass.Controls.Add(this.label4);
            this.pnl_pass.Controls.Add(this.dateTimePicker1);
            this.pnl_pass.Controls.Add(this.txt_pass_pass);
            this.pnl_pass.Controls.Add(this.label3);
            this.pnl_pass.Controls.Add(this.txt_pass_email);
            this.pnl_pass.Controls.Add(this.label2);
            this.pnl_pass.Controls.Add(this.txt_pass_url);
            this.pnl_pass.Controls.Add(this.label1);
            this.pnl_pass.Enabled = false;
            this.pnl_pass.Location = new System.Drawing.Point(291, 6);
            this.pnl_pass.Name = "pnl_pass";
            this.pnl_pass.Size = new System.Drawing.Size(563, 318);
            this.pnl_pass.TabIndex = 1;
            // 
            // btn_pass_new
            // 
            this.btn_pass_new.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pass_new.Location = new System.Drawing.Point(752, 328);
            this.btn_pass_new.Name = "btn_pass_new";
            this.btn_pass_new.Size = new System.Drawing.Size(102, 30);
            this.btn_pass_new.TabIndex = 2;
            this.btn_pass_new.Text = "New";
            this.btn_pass_new.UseVisualStyleBackColor = true;
            this.btn_pass_new.Click += new System.EventHandler(this.btn_pass_new_Click);
            // 
            // btn_pass_save
            // 
            this.btn_pass_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pass_save.Enabled = false;
            this.btn_pass_save.Location = new System.Drawing.Point(644, 328);
            this.btn_pass_save.Name = "btn_pass_save";
            this.btn_pass_save.Size = new System.Drawing.Size(102, 30);
            this.btn_pass_save.TabIndex = 3;
            this.btn_pass_save.Text = "Save";
            this.btn_pass_save.UseVisualStyleBackColor = true;
            this.btn_pass_save.Click += new System.EventHandler(this.btn_pass_save_Click);
            // 
            // btn_pass_delete
            // 
            this.btn_pass_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pass_delete.Enabled = false;
            this.btn_pass_delete.Location = new System.Drawing.Point(291, 328);
            this.btn_pass_delete.Name = "btn_pass_delete";
            this.btn_pass_delete.Size = new System.Drawing.Size(102, 30);
            this.btn_pass_delete.TabIndex = 4;
            this.btn_pass_delete.Text = "Delete";
            this.btn_pass_delete.UseVisualStyleBackColor = true;
            this.btn_pass_delete.Click += new System.EventHandler(this.btn_pass_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url Or Title:";
            // 
            // txt_pass_url
            // 
            this.txt_pass_url.Location = new System.Drawing.Point(170, 76);
            this.txt_pass_url.Multiline = true;
            this.txt_pass_url.Name = "txt_pass_url";
            this.txt_pass_url.Size = new System.Drawing.Size(348, 57);
            this.txt_pass_url.TabIndex = 1;
            // 
            // chk_setting_show_passowrd
            // 
            this.chk_setting_show_passowrd.AutoSize = true;
            this.chk_setting_show_passowrd.Location = new System.Drawing.Point(31, 81);
            this.chk_setting_show_passowrd.Name = "chk_setting_show_passowrd";
            this.chk_setting_show_passowrd.Size = new System.Drawing.Size(128, 20);
            this.chk_setting_show_passowrd.TabIndex = 1;
            this.chk_setting_show_passowrd.Text = "Show Passowrds ";
            this.chk_setting_show_passowrd.UseVisualStyleBackColor = true;
            // 
            // txt_pass_email
            // 
            this.txt_pass_email.Location = new System.Drawing.Point(170, 139);
            this.txt_pass_email.Name = "txt_pass_email";
            this.txt_pass_email.Size = new System.Drawing.Size(348, 23);
            this.txt_pass_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "UserName Or Email:";
            // 
            // txt_pass_pass
            // 
            this.txt_pass_pass.Location = new System.Drawing.Point(170, 168);
            this.txt_pass_pass.Name = "txt_pass_pass";
            this.txt_pass_pass.Size = new System.Drawing.Size(348, 23);
            this.txt_pass_pass.TabIndex = 5;
            this.txt_pass_pass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password :";
            // 
            // btn_saveSetting
            // 
            this.btn_saveSetting.Location = new System.Drawing.Point(31, 313);
            this.btn_saveSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_saveSetting.Name = "btn_saveSetting";
            this.btn_saveSetting.Size = new System.Drawing.Size(802, 28);
            this.btn_saveSetting.TabIndex = 2;
            this.btn_saveSetting.Text = "Save";
            this.btn_saveSetting.UseVisualStyleBackColor = true;
            this.btn_saveSetting.Click += new System.EventHandler(this.btn_saveSetting_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy hh:mm:ss";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(348, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUrlToolStripMenuItem,
            this.copyUserNameToolStripMenuItem,
            this.copyPasswordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            // 
            // copyUrlToolStripMenuItem
            // 
            this.copyUrlToolStripMenuItem.Name = "copyUrlToolStripMenuItem";
            this.copyUrlToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copyUrlToolStripMenuItem.Text = "Copy Url";
            this.copyUrlToolStripMenuItem.Click += new System.EventHandler(this.copyUrlToolStripMenuItem_Click);
            // 
            // copyUserNameToolStripMenuItem
            // 
            this.copyUserNameToolStripMenuItem.Name = "copyUserNameToolStripMenuItem";
            this.copyUserNameToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copyUserNameToolStripMenuItem.Text = "Copy UserName";
            this.copyUserNameToolStripMenuItem.Click += new System.EventHandler(this.copyUserNameToolStripMenuItem_Click);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy Password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // btn_pass_edit
            // 
            this.btn_pass_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_pass_edit.Enabled = false;
            this.btn_pass_edit.Location = new System.Drawing.Point(396, 328);
            this.btn_pass_edit.Name = "btn_pass_edit";
            this.btn_pass_edit.Size = new System.Drawing.Size(102, 30);
            this.btn_pass_edit.TabIndex = 5;
            this.btn_pass_edit.Text = "Edit";
            this.btn_pass_edit.UseVisualStyleBackColor = true;
            this.btn_pass_edit.Click += new System.EventHandler(this.btn_pass_edit_Click);
            // 
            // txt_pass_search
            // 
            this.txt_pass_search.Location = new System.Drawing.Point(8, 11);
            this.txt_pass_search.Name = "txt_pass_search";
            this.txt_pass_search.Size = new System.Drawing.Size(277, 23);
            this.txt_pass_search.TabIndex = 7;
            this.txt_pass_search.TextChanged += new System.EventHandler(this.txt_pass_search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Create Time :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 392);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save Me Senstive";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnl_pass.ResumeLayout(false);
            this.pnl_pass.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_setting;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TreeView tree_password;
        private System.Windows.Forms.Button btn_pass_new;
        private System.Windows.Forms.Panel pnl_pass;
        private System.Windows.Forms.Button btn_pass_delete;
        private System.Windows.Forms.Button btn_pass_save;
        private System.Windows.Forms.TextBox txt_pass_url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_setting_show_passowrd;
        private System.Windows.Forms.TextBox txt_pass_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_pass_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_saveSetting;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyUrlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyUserNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyPasswordToolStripMenuItem;
        private System.Windows.Forms.Button btn_pass_edit;
        private System.Windows.Forms.TextBox txt_pass_search;
        private System.Windows.Forms.Label label4;
    }
}

