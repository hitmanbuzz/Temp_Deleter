namespace Temporary_Files
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string get_username = SystemInformation.UserName;
            DirectoryInfo temp1_path = new DirectoryInfo("C:\\Windows\\Temp");
            DirectoryInfo temp2_path = new DirectoryInfo($"C:\\Users\\{get_username}\\AppData\\Local\\Temp");
            if (checkBox1.Checked)
            {
                foreach (FileInfo file in temp1_path.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        
                    }
                }
                foreach (DirectoryInfo dir in temp1_path.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        
                    }
                }
                MessageBox.Show("Possible Files and Folders have been deleted from Temp Folder");
            }

            if (checkBox2.Checked)
            {
                foreach (FileInfo file in temp2_path.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        
                    }
                }
                foreach (DirectoryInfo dir in temp2_path.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {
                        
                    }
                }
                MessageBox.Show("Possible Files and Folders have been deleted from %Temp% Folder");
            }
        }
        private void home_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_files_text_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Result_btn_Click(object sender, EventArgs e)
        {
            string get_username = SystemInformation.UserName;
            DirectoryInfo temp1_path = new DirectoryInfo("C:\\Windows\\Temp");
            DirectoryInfo temp2_path = new DirectoryInfo($"C:\\Users\\{get_username}\\AppData\\Local\\Temp");

            if (checkBox1.Checked)
            {
                foreach (FileInfo file in temp1_path.GetFiles())
                {
                    try
                    {
                        delete_files_text_box.Text = file.Name;
                    }
                    catch
                    {
                        delete_files_text_box.Text = "No File found to delete in Temp folder";
                    }
                }
                foreach (DirectoryInfo dir in temp1_path.GetDirectories())
                {
                    try
                    {
                        delete_files_text_box.Text = dir.Name;
                    }
                    catch
                    {
                        delete_files_text_box.Text = "No Folder found to delete in Temp folder";
                    }
                }
            }

            if (checkBox2.Checked)
            {
                foreach (FileInfo file in temp2_path.GetFiles())
                {
                    try
                    {
                        delete_files_text_box.Text = file.Name;
                        
                    }
                    catch
                    {
                        delete_files_text_box.Text = "No File found to delete in %Temp% folder";
                    }
                }
                foreach (DirectoryInfo dir in temp2_path.GetDirectories())
                {
                    try
                    {
                        delete_files_text_box.Text = dir.Name;
                        
                    }
                    catch
                    {
                        delete_files_text_box.Text = "No Folder found to delete in %Temp% folder";
                    }
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string get_username = SystemInformation.UserName;
            username_textbox.Text = get_username;
        }

        private void home_btn_Click_1(object sender, EventArgs e)
        {

        }
    }
}