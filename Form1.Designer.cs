namespace Temporary_Files
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_files_text_box = new System.Windows.Forms.RichTextBox();
            this.home_panel = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.home_btn = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.Result_btn = new System.Windows.Forms.Button();
            this.about_btn = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.home_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.home_btn.SuspendLayout();
            this.about_btn.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 70);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "TEMP";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 95);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 19);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "%TEMP%";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete_files_text_box
            // 
            this.delete_files_text_box.Location = new System.Drawing.Point(182, 6);
            this.delete_files_text_box.Name = "delete_files_text_box";
            this.delete_files_text_box.Size = new System.Drawing.Size(200, 166);
            this.delete_files_text_box.TabIndex = 4;
            this.delete_files_text_box.Text = "";
            this.delete_files_text_box.TextChanged += new System.EventHandler(this.delete_files_text_box_TextChanged);
            // 
            // home_panel
            // 
            this.home_panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.home_panel.Controls.Add(this.tabControl1);
            this.home_panel.Location = new System.Drawing.Point(12, 12);
            this.home_panel.Name = "home_panel";
            this.home_panel.Size = new System.Drawing.Size(408, 211);
            this.home_panel.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.home_btn);
            this.tabControl1.Controls.Add(this.about_btn);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(396, 205);
            this.tabControl1.TabIndex = 0;
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.DarkGray;
            this.home_btn.Controls.Add(this.label1);
            this.home_btn.Controls.Add(this.search_btn);
            this.home_btn.Controls.Add(this.username_textbox);
            this.home_btn.Controls.Add(this.Result_btn);
            this.home_btn.Controls.Add(this.delete_files_text_box);
            this.home_btn.Controls.Add(this.checkBox1);
            this.home_btn.Controls.Add(this.button1);
            this.home_btn.Controls.Add(this.checkBox2);
            this.home_btn.Location = new System.Drawing.Point(4, 24);
            this.home_btn.Name = "home_btn";
            this.home_btn.Padding = new System.Windows.Forms.Padding(3);
            this.home_btn.Size = new System.Drawing.Size(388, 177);
            this.home_btn.TabIndex = 0;
            this.home_btn.Text = "Home";
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "PC Username";
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(87, 35);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(77, 6);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(99, 23);
            this.username_textbox.TabIndex = 6;
            // 
            // Result_btn
            // 
            this.Result_btn.Location = new System.Drawing.Point(87, 134);
            this.Result_btn.Name = "Result_btn";
            this.Result_btn.Size = new System.Drawing.Size(75, 23);
            this.Result_btn.TabIndex = 5;
            this.Result_btn.Text = "Result";
            this.Result_btn.UseVisualStyleBackColor = true;
            this.Result_btn.Click += new System.EventHandler(this.Result_btn_Click);
            // 
            // about_btn
            // 
            this.about_btn.Controls.Add(this.richTextBox1);
            this.about_btn.Location = new System.Drawing.Point(4, 24);
            this.about_btn.Name = "about_btn";
            this.about_btn.Padding = new System.Windows.Forms.Padding(3);
            this.about_btn.Size = new System.Drawing.Size(388, 177);
            this.about_btn.TabIndex = 1;
            this.about_btn.Text = "About";
            this.about_btn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(6, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(376, 165);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "My name is Henthoiba also known as Hitman.\nThis program will help to clear Temp a" +
    "nd %Temp% Folder.\nI am just a rookie programmer who loves coding.\nHope you have " +
    "a nice day and good night.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 235);
            this.Controls.Add(this.home_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Temp Deleter";
            this.home_panel.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.home_btn.ResumeLayout(false);
            this.home_btn.PerformLayout();
            this.about_btn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox delete_files_text_box;
        private Panel home_panel;
        private TabControl tabControl1;
        private TabPage home_btn;
        private TabPage about_btn;
        private ContextMenuStrip contextMenuStrip1;
        private Button Result_btn;
        private TextBox username_textbox;
        private Button search_btn;
        private Label label1;
    }
}