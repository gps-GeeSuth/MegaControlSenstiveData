using MegaControlSenstiveData.Properties;
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
    public partial class Setting : Form
    {
        

        public Setting()
        {
            InitializeComponent();
        }

        private void txt_path_MouseClick(object sender, MouseEventArgs e)
        {
            selectFolder();
        }

        private void selectFolder()
        {
            using (var sFolder = new FolderBrowserDialog())
            {
                sFolder.Description = "Select That Folder Async Automaticly by Any Service for Clouding ";
                if (sFolder.ShowDialog() == DialogResult.OK)
                {
                    txt_path.Text = sFolder.SelectedPath;
                }

            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            selectFolder();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Please Sure That Folder is Async On ready?" + Environment.NewLine+ txt_path.Text,"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (SaveToProprties(txt_path.Text))
                    Application.Restart();
            }
        }

        private bool SaveToProprties(string path)
        {
            try
            {
                //FolderPath
                Properties.Settings.Default["FolderPath"] = path;
                Properties.Settings.Default.Save();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            LoadProprties();
        }

        private void LoadProprties()
        {
            try
            {
                string path = Properties.Settings.Default["FolderPath"].ToString();
                txt_path.Text = path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
        }
    }
}
