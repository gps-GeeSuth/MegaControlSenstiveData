using JsonFlatFileDataStore;
using MegaControlSenstiveData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaControlSenstiveData
{
    public partial class Main : Form
    {
        bool ShowPassword = false;
        string AsyncPathFolder = string.Empty;

        string frmText = "Save Me Senstive";
        string cloudTo = "";
        public Main()
        {
            InitializeComponent();
        }

        private void btn_setting_Click(object sender, EventArgs e)
        {
            Setting frmsetting = new Setting();
            frmsetting.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = frmText;
            LoadProprties();
            PasswordSettingChanged();
            LoadPasswords();
        }

        private void PasswordSettingChanged()
        {
            if (ShowPassword)
            {
                txt_pass_pass.UseSystemPasswordChar = false;
                this.Text = frmText + " [Password Shows] |Cloud To " +cloudTo ;
            }
            else
            {
                txt_pass_pass.UseSystemPasswordChar = true;
                this.Text = frmText + " [Password Not Shows] |Cloud To " + cloudTo;
            }
        }

        private void LoadProprties()
        {
            ShowPassword= (bool)Properties.Settings.Default["ShowPassword"];
            AsyncPathFolder = Properties.Settings.Default["FolderPath"].ToString();
            cloudTo = AsyncPathFolder;
            if (string.IsNullOrEmpty(AsyncPathFolder))
            {
                MessageBox.Show("Please Choose Folder For Save there And restart App");
                btn_pass_new.Enabled = false;
            }
            chk_setting_show_passowrd.Checked = ShowPassword;
        }

        private void btn_saveSetting_Click(object sender, EventArgs e)
        {
            SaveProprties();
            PasswordSettingChanged();
        }

        private void SaveProprties()
        {
            Properties.Settings.Default["ShowPassword"] = chk_setting_show_passowrd.Checked;
            Properties.Settings.Default.Save();

            ShowPassword = chk_setting_show_passowrd.Checked;

            MessageBox.Show("Saved");
        }

        private void btn_pass_new_Click(object sender, EventArgs e)
        {
            ClearTexts();
            EnableToEdit(true);
        }

        private void ClearTexts()
        {
            txt_pass_url.Tag = 0;
            txt_pass_url.Text = "";
            txt_pass_pass.Text = "";
            txt_pass_email.Text = "";
        }

        private void EnableToEdit(bool v)
        {
            btn_pass_new.Enabled = !v;
            btn_pass_save.Enabled = v;
            pnl_pass.Enabled = v;
            btn_pass_edit.Enabled = !v;
            btn_pass_delete.Enabled = !v;

        }

        private async void btn_pass_save_Click(object sender, EventArgs e)
        {
            int id = (int)txt_pass_url.Tag;
            if (id == 0)
            {
                if (MessageBox.Show("Are you Sure to save" + Environment.NewLine + txt_pass_url.Text, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    bool re = await SaveToToPasswords(txt_pass_url.Text, txt_pass_email.Text, txt_pass_pass.Text);
                    if (re)
                    {
                        EnableToEdit(false);
                        btn_pass_new.Enabled = true;
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Are you Sure to Update" + Environment.NewLine + txt_pass_url.Text, "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    bool re = await UpdateToPasswords(id,txt_pass_url.Text, txt_pass_email.Text, txt_pass_pass.Text);
                    if (re)
                    {
                        EnableToEdit(false);
                        btn_pass_new.Enabled = true;
                    }
                }
            }
            LoadPasswords();
        }

        private async Task<bool> UpdateToPasswords(int id, string url, string username, string passowrd)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore(AsyncPathFolder + "/passwords.json");

            // Create new Password instance
            var pass = new Passwords { Id = id, Url = url, Username = username, Passowrd = passowrd, CreateDate = DateTime.Now.ToString() };

            // Get Passwords collection
            var collection = store.GetCollection<Passwords>();

            bool result = await collection.UpdateOneAsync(id,pass);

            return result;
        }

        private async Task<bool> SaveToToPasswords(string url, string username, string passowrd)
        {
            // Open database (create new if file doesn't exist)
            var store = new DataStore(AsyncPathFolder+"/passwords.json");

            // Create new Password instance
            var pass = new Passwords { Id = 1, Url = url, Username = username, Passowrd = passowrd, CreateDate = DateTime.Now.ToString() };
           
            // Get Passwords collection
            var collection = store.GetCollection<Passwords>();

            bool result= await collection.InsertOneAsync(pass);

            return result;
        }

        private void LoadPasswords(string search="")
        {
            tree_password.Nodes.Clear();

            // Open database (create new if file doesn't exist)
            var store = new DataStore(AsyncPathFolder + "/passwords.json");

            // Get Passwords collection
            var collection = store.GetCollection<Passwords>().AsQueryable()
                .Where(w=>w.Username.ToUpper().Contains(search.ToUpper())|| w.Url.ToUpper().Contains(search.ToUpper())).ToList();

            foreach (var item in collection)
            {
                var node =tree_password.Nodes.Add(item.Url);
                node.Tag = item.Id;
            }
        }

        private void tree_password_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                fillPassowrdById((int)tree_password.SelectedNode.Tag);
            }
            catch
            {
            }
        }

        private void fillPassowrdById(int id)
        {
            try
            {
                if (id != 0)
                {
                    // Open database (create new if file doesn't exist)
                    var store = new DataStore(AsyncPathFolder + "/passwords.json");

                    // Get Passwords collection
                    var collection = store.GetCollection<Passwords>();
                    var result = collection.AsQueryable().Where(e => e.Id == id).FirstOrDefault();
                    if (result != null)
                    {
                        txt_pass_url.Tag = result.Id;
                        txt_pass_url.Text = result.Url;
                        txt_pass_email.Text = result.Username;
                        txt_pass_pass.Text = result.Passowrd;
                        dateTimePicker1.Value = DateTime.Parse(result.CreateDate);
                        btn_pass_edit.Enabled = true;
                        btn_pass_delete.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyUrlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)tree_password.SelectedNode.Tag;
                if (id != 0)
                {
                    // Open database (create new if file doesn't exist)
                    var store = new DataStore(AsyncPathFolder + "/passwords.json");

                    // Get Passwords collection
                    var collection = store.GetCollection<Passwords>();
                    var result = collection.AsQueryable().Where(w=> w.Id == id).FirstOrDefault();
                    if (result != null)
                    {
                        Clipboard.SetText(result.Url);
                        MessageBox.Show("Coped");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyUserNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)tree_password.SelectedNode.Tag;
                if (id != 0)
                {
                    // Open database (create new if file doesn't exist)
                    var store = new DataStore(AsyncPathFolder + "/passwords.json");

                    // Get Passwords collection
                    var collection = store.GetCollection<Passwords>();
                    var result = collection.AsQueryable().Where(w => w.Id == id).FirstOrDefault();
                    if (result != null)
                    {
                        Clipboard.SetText(result.Username);
                        MessageBox.Show("Coped");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void copyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)tree_password.SelectedNode.Tag;
                if (id != 0)
                {
                    // Open database (create new if file doesn't exist)
                    var store = new DataStore(AsyncPathFolder + "/passwords.json");

                    // Get Passwords collection
                    var collection = store.GetCollection<Passwords>();
                    var result = collection.AsQueryable().Where(w => w.Id == id).FirstOrDefault();
                    if (result != null)
                    {
                        Clipboard.SetText(result.Passowrd);
                        MessageBox.Show("Coped");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_pass_edit_Click(object sender, EventArgs e)
        {
            EnableToEdit(true);
        }

        private void txt_pass_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchinPassword(txt_pass_search.Text);
            }
            catch
            {
            }
        }

        private void SearchinPassword(string txt)
        {
            LoadPasswords(txt);
        }

        private async void btn_pass_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure to Delete" + Environment.NewLine +txt_pass_url.Text, "Warining", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                int id = (int)tree_password.SelectedNode.Tag;
                if (id != 0)
                {
                    var store = new DataStore(AsyncPathFolder + "/passwords.json");
                    var collection = store.GetCollection<Passwords>();

                    bool x = await collection.DeleteOneAsync(id);
                    if (x)
                    {
                        MessageBox.Show("Deleted!");
                        LoadPasswords();
                        ClearTexts();
                    }
                }

            }
        }
    }
}
