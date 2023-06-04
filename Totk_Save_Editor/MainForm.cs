using System;
using System.Diagnostics;
using System.Windows.Forms;
using TOTK_SaveGame_Editor.Data;
using TOTK_SaveGame_Editor.Items;
using TOTK_SaveGame_Editor.Save;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Totk_Save_Editor
{

    class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();

            this.Text = "The Editor of Save - Tears of The Koroks";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;

            save_path = File.ReadAllText(@"./totk_save_editor.ini");
            if (save_path != null) pathbox.Text = save_path;
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            groupBox3 = new GroupBox();
            logBox = new RichTextBox();
            groupBox1 = new GroupBox();
            locate = new Button();
            pathbox = new TextBox();
            groupBox2 = new GroupBox();
            read = new Button();
            saveall = new Button();
            save = new Button();
            pictureBox4 = new PictureBox();
            checkBox5 = new CheckBox();
            pictureBox0 = new PictureBox();
            checkBox4 = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBox3 = new CheckBox();
            pictureBox2 = new PictureBox();
            checkBox2 = new CheckBox();
            pictureBox3 = new PictureBox();
            checkBox1 = new CheckBox();
            pictureBox5 = new PictureBox();
            checkBox0 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            exit = new Button();
            home = new Button();
            bow = new Button();
            food = new Button();
            armor = new Button();
            horse = new Button();
            keyitem = new Button();
            material = new Button();
            others = new Button();
            shield = new Button();
            weapon = new Button();
            zonai = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.bg_black;
            groupBox3.Controls.Add(logBox);
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.ForeColor = Color.FromArgb(255, 192, 128);
            groupBox3.Location = new Point(3, 846);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(566, 145);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Runtime logs";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // logBox
            // 
            logBox.BackColor = Color.Black;
            logBox.BorderStyle = BorderStyle.None;
            logBox.Cursor = Cursors.Hand;
            logBox.ForeColor = Color.FromArgb(255, 192, 128);
            logBox.Location = new Point(5, 23);
            logBox.Name = "logBox";
            logBox.ReadOnly = true;
            logBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            logBox.Size = new Size(555, 115);
            logBox.TabIndex = 20;
            logBox_Write("Start or relocate your saves~");
            logBox.TextChanged += logBox_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.BackgroundImage = Properties.Resources.bg_black;
            groupBox1.Controls.Add(locate);
            groupBox1.Controls.Add(pathbox);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.FromArgb(255, 192, 128);
            groupBox1.Location = new Point(3, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 96);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Locate the save folder:";
            // 
            // locate
            // 
            locate.BackColor = Color.Transparent;
            locate.BackgroundImage = Properties.Resources.button;
            locate.BackgroundImageLayout = ImageLayout.Zoom;
            locate.Cursor = Cursors.Hand;
            locate.FlatStyle = FlatStyle.Flat;
            locate.ForeColor = Color.FromArgb(255, 192, 128);
            locate.Location = new Point(401, 36);
            locate.Name = "locate";
            locate.Size = new Size(117, 29);
            locate.TabIndex = 9;
            locate.Text = "Browse";
            locate.UseVisualStyleBackColor = false;
            locate.Click += locate_Click;
            // 
            // pathbox
            // 
            pathbox.BorderStyle = BorderStyle.FixedSingle;
            pathbox.Location = new Point(5, 38);
            pathbox.Name = "pathbox";
            pathbox.Size = new Size(389, 27);
            pathbox.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.bg_black;
            groupBox2.Controls.Add(read);
            groupBox2.Controls.Add(saveall);
            groupBox2.Controls.Add(save);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(pictureBox0);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(checkBox0);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(255, 192, 128);
            groupBox2.Location = new Point(3, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 443);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Save slots found(check to load)";
            // 
            // read
            // 
            read.BackColor = Color.Transparent;
            read.BackgroundImage = Properties.Resources.button;
            read.BackgroundImageLayout = ImageLayout.Zoom;
            read.Cursor = Cursors.Hand;
            read.FlatStyle = FlatStyle.Flat;
            read.ForeColor = Color.FromArgb(255, 192, 128);
            read.Location = new Point(9, 405);
            read.Name = "read";
            read.Size = new Size(140, 29);
            read.TabIndex = 30;
            read.Text = "Read";
            read.UseVisualStyleBackColor = false;
            read.Click += read_Click;
            // 
            // saveall
            // 
            saveall.BackColor = Color.Transparent;
            saveall.BackgroundImage = Properties.Resources.button;
            saveall.BackgroundImageLayout = ImageLayout.Zoom;
            saveall.Cursor = Cursors.Hand;
            saveall.FlatStyle = FlatStyle.Flat;
            saveall.ForeColor = Color.FromArgb(255, 192, 128);
            saveall.Location = new Point(407, 405);
            saveall.Name = "saveall";
            saveall.Size = new Size(117, 29);
            saveall.TabIndex = 29;
            saveall.Text = "Save all";
            saveall.UseVisualStyleBackColor = false;
            // 
            // save
            // 
            save.BackColor = Color.Transparent;
            save.BackgroundImage = Properties.Resources.button;
            save.BackgroundImageLayout = ImageLayout.Zoom;
            save.Cursor = Cursors.Hand;
            save.FlatStyle = FlatStyle.Flat;
            save.ForeColor = Color.FromArgb(255, 192, 128);
            save.Location = new Point(282, 405);
            save.Name = "save";
            save.Size = new Size(117, 29);
            save.TabIndex = 10;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.bg_black;
            pictureBox4.Image = Properties.Resources._blank;
            pictureBox4.Location = new Point(383, 166);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackgroundImage = Properties.Resources.bg_black;
            checkBox5.Enabled = false;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Location = new Point(281, 328);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(98, 25);
            checkBox5.TabIndex = 28;
            checkBox5.Text = "Slot_05";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // pictureBox0
            // 
            pictureBox0.BackgroundImage = Properties.Resources.bg_black;
            pictureBox0.BackgroundImageLayout = ImageLayout.None;
            pictureBox0.Image = Properties.Resources._blank;
            pictureBox0.Location = new Point(113, 45);
            pictureBox0.Name = "pictureBox0";
            pictureBox0.Size = new Size(140, 90);
            pictureBox0.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox0.TabIndex = 5;
            pictureBox0.TabStop = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackgroundImage = Properties.Resources.bg_black;
            checkBox4.Enabled = false;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(281, 204);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 25);
            checkBox4.TabIndex = 27;
            checkBox4.Text = "Slot_04";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bg_black;
            pictureBox1.Image = Properties.Resources._blank;
            pictureBox1.Location = new Point(113, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackgroundImage = Properties.Resources.bg_black;
            checkBox3.Enabled = false;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(281, 77);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 25);
            checkBox3.TabIndex = 26;
            checkBox3.Text = "Slot_03";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bg_black;
            pictureBox2.Image = Properties.Resources._blank;
            pictureBox2.Location = new Point(113, 293);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackgroundImage = Properties.Resources.bg_black;
            checkBox2.Enabled = false;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(15, 328);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 25);
            checkBox2.TabIndex = 25;
            checkBox2.Text = "Slot_02";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bg_black;
            pictureBox3.Image = Properties.Resources._blank;
            pictureBox3.Location = new Point(383, 45);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackgroundImage = Properties.Resources.bg_black;
            checkBox1.Enabled = false;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Location = new Point(15, 204);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(98, 25);
            checkBox1.TabIndex = 24;
            checkBox1.Text = "Slot_01";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bg_black;
            pictureBox5.Image = Properties.Resources._blank;
            pictureBox5.Location = new Point(383, 293);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(140, 90);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // checkBox0
            // 
            checkBox0.AutoSize = true;
            checkBox0.BackgroundImage = Properties.Resources.bg_black;
            checkBox0.Enabled = false;
            checkBox0.FlatStyle = FlatStyle.Flat;
            checkBox0.ForeColor = Color.FromArgb(255, 192, 128);
            checkBox0.Location = new Point(16, 77);
            checkBox0.Name = "checkBox0";
            checkBox0.Size = new Size(98, 25);
            checkBox0.TabIndex = 23;
            checkBox0.Text = "Slot_00";
            checkBox0.UseVisualStyleBackColor = true;
            checkBox0.CheckedChanged += checkBox0_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackgroundImage = Properties.Resources.bg_black;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(groupBox3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(582, 1000);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.title;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 286);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.BackgroundImage = Properties.Resources.exit;
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.FlatStyle = FlatStyle.Flat;
            exit.ForeColor = Color.Teal;
            exit.Location = new Point(1578, 12);
            exit.Name = "exit";
            exit.Size = new Size(60, 60);
            exit.TabIndex = 8;
            exit.UseVisualStyleBackColor = false;
            exit.Click += button2_Click;
            // 
            // home
            // 
            home.Image = Properties.Resources.home_d;
            home.Location = new Point(627, 12);
            home.Name = "home";
            home.Size = new Size(60, 60);
            home.TabIndex = 9;
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // bow
            // 
            bow.Image = Properties.Resources.Bows;
            bow.Location = new Point(785, 12);
            bow.Name = "bow";
            bow.Size = new Size(60, 60);
            bow.TabIndex = 10;
            bow.UseVisualStyleBackColor = true;
            // 
            // food
            // 
            food.Image = Properties.Resources.food;
            food.Location = new Point(1104, 12);
            food.Name = "food";
            food.Size = new Size(60, 60);
            food.TabIndex = 11;
            food.UseVisualStyleBackColor = true;
            // 
            // armor
            // 
            armor.Image = Properties.Resources.armors;
            armor.Location = new Point(706, 12);
            armor.Name = "armor";
            armor.Size = new Size(60, 60);
            armor.TabIndex = 12;
            armor.UseVisualStyleBackColor = true;
            armor.Click += armor_Click;
            // 
            // horse
            // 
            horse.Image = Properties.Resources.horses;
            horse.Location = new Point(1344, 12);
            horse.Name = "horse";
            horse.Size = new Size(60, 60);
            horse.TabIndex = 13;
            horse.UseVisualStyleBackColor = true;
            // 
            // keyitem
            // 
            keyitem.Image = Properties.Resources.ketitems;
            keyitem.Location = new Point(1265, 12);
            keyitem.Name = "keyitem";
            keyitem.Size = new Size(60, 60);
            keyitem.TabIndex = 14;
            keyitem.UseVisualStyleBackColor = true;
            // 
            // material
            // 
            material.Image = Properties.Resources.items;
            material.Location = new Point(1022, 12);
            material.Name = "material";
            material.Size = new Size(60, 60);
            material.TabIndex = 15;
            material.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            others.Image = Properties.Resources.others;
            others.Location = new Point(1422, 12);
            others.Name = "others";
            others.Size = new Size(60, 60);
            others.TabIndex = 16;
            others.UseVisualStyleBackColor = true;
            // 
            // shield
            // 
            shield.Image = Properties.Resources.shields;
            shield.Location = new Point(864, 12);
            shield.Name = "shield";
            shield.Size = new Size(60, 60);
            shield.TabIndex = 17;
            shield.UseVisualStyleBackColor = true;
            // 
            // weapon
            // 
            weapon.Image = Properties.Resources.Weapons;
            weapon.Location = new Point(942, 12);
            weapon.Name = "weapon";
            weapon.Size = new Size(60, 60);
            weapon.TabIndex = 18;
            weapon.UseVisualStyleBackColor = true;
            // 
            // zonai
            // 
            zonai.Image = Properties.Resources.zonais;
            zonai.Location = new Point(1184, 12);
            zonai.Name = "zonai";
            zonai.Size = new Size(60, 60);
            zonai.TabIndex = 19;
            zonai.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            BackgroundImage = Properties.Resources.bg_white;
            ClientSize = new Size(1650, 1000);
            Controls.Add(zonai);
            Controls.Add(weapon);
            Controls.Add(shield);
            Controls.Add(others);
            Controls.Add(material);
            Controls.Add(keyitem);
            Controls.Add(horse);
            Controls.Add(armor);
            Controls.Add(food);
            Controls.Add(bow);
            Controls.Add(home);
            Controls.Add(exit);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Modern No. 20", 11F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 600);
            Name = "MainForm";
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox0).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private Button exit;
        private Button home;
        private Button bow;
        private Button food;
        private Button armor;
        private Button horse;
        private Button keyitem;
        private Button material;
        private Button others;
        private Button shield;
        private Button weapon;
        private Button zonai;
        private Button save;
        private Button read;
        private Button saveall;
        private string save_path;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Button locate;
        private TextBox pathbox;
        private GroupBox groupBox2;
        private PictureBox pictureBox4;
        private CheckBox checkBox5;
        private PictureBox pictureBox0;
        private CheckBox checkBox4;
        private PictureBox pictureBox1;
        private CheckBox checkBox3;
        private PictureBox pictureBox2;
        private CheckBox checkBox2;
        private PictureBox pictureBox3;
        private CheckBox checkBox1;
        private PictureBox pictureBox5;
        private CheckBox checkBox0;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private RichTextBox logBox;
        private System.ComponentModel.IContainer components;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void locate_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please choose the root folder of slot_00, slot_01, etc.";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    return;
                }

            }
            else return;

            pathbox.Text = dialog.SelectedPath;

            File.WriteAllText(@"./totk_save_editor.ini", dialog.SelectedPath);
        }

        private void read_Click(object sender, EventArgs e)
        {

            TOTK_Caption _Caption;
            save_path = pathbox.Text;
            _Caption = new TOTK_Caption(save_path);

            if (_Caption.IsLoaded == true)
            {
                DateTime currentTime = new DateTime();
                currentTime = System.DateTime.Now;
                logBox.AppendText(currentTime.ToString("T") + " - all save files found\n");

                Stream caption_st0 = File.Open(save_path + "\\slot_00" + "\\caption.png", FileMode.Open);
                Stream caption_st1 = File.Open(save_path + "\\slot_01" + "\\caption.png", FileMode.Open);
                Stream caption_st2 = File.Open(save_path + "\\slot_02" + "\\caption.png", FileMode.Open);
                Stream caption_st3 = File.Open(save_path + "\\slot_03" + "\\caption.png", FileMode.Open);
                Stream caption_st4 = File.Open(save_path + "\\slot_04" + "\\caption.png", FileMode.Open);
                Stream caption_st5 = File.Open(save_path + "\\slot_05" + "\\caption.png", FileMode.Open);

                pictureBox0.Image = Image.FromStream(caption_st0);
                pictureBox1.Image = Image.FromStream(caption_st1);
                pictureBox2.Image = Image.FromStream(caption_st2);
                pictureBox3.Image = Image.FromStream(caption_st3);
                pictureBox4.Image = Image.FromStream(caption_st4);
                pictureBox5.Image = Image.FromStream(caption_st5);

                caption_st0.Close();
                caption_st1.Close();
                caption_st2.Close();
                caption_st3.Close();
                caption_st4.Close();
                caption_st5.Close();

                checkBox0.Enabled = true;
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;

                checkBox0.Checked = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;


            }
            else
            {
                DateTime currentTime = new DateTime();
                currentTime = System.DateTime.Now;
                logBox.AppendText(currentTime.ToString("T") + " - save files not found\n");
                pictureBox0.Image = Properties.Resources._blank;
                pictureBox1.Image = Properties.Resources._blank;
                pictureBox2.Image = Properties.Resources._blank;
                pictureBox3.Image = Properties.Resources._blank;
                pictureBox4.Image = Properties.Resources._blank;
                pictureBox5.Image = Properties.Resources._blank;

                checkBox0.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;

                checkBox0.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }



        }

        private void home_Click(object sender, EventArgs e)
        {

        }

        private void armor_Click(object sender, EventArgs e)
        {

        }

        private void logBox_Write(string log)
        {
            DateTime currentTime = new DateTime();
            currentTime = System.DateTime.Now;
            logBox.AppendText(currentTime.ToString("T") + " - " + log + "\n");
        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {
            logBox.SelectionStart = logBox.TextLength;
            // Scrolls the contents of the control to the current caret position.
            logBox.ScrollToCaret();
        }

        private void checkBox0_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox0.Checked)
            {
                logBox_Write("slot_00 selected");
                logBox_Write("slot_00 content loaded");

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                logBox_Write("slot_00 unselected");
                logBox_Write("slot_00 content unloaded");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                logBox_Write("slot_01 selected");
                logBox_Write("slot_01 content loaded");

                checkBox0.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                logBox_Write("slot_01 unselected");
                logBox_Write("slot_01 content unloaded");

            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                logBox_Write("slot_02 selected");
                logBox_Write("slot_02 content loaded");

                checkBox0.Checked = false;
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                logBox_Write("slot_02 unselected");
                logBox_Write("slot_02 content unloaded");

            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                logBox_Write("slot_03 selected");
                logBox_Write("slot_03 content loaded");

                checkBox0.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                logBox_Write("slot_03 unselected");
                logBox_Write("slot_03 content unloaded");

            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                logBox_Write("slot_04 selected");
                logBox_Write("slot_04 content loaded");

                checkBox0.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
            }
            else
            {
                logBox_Write("slot_04 unselected");
                logBox_Write("slot_04 content unloaded");

            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                logBox_Write("slot_05 selected");
                logBox_Write("slot_05 content loaded");

                checkBox0.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
                logBox_Write("slot_05 unselected");
                logBox_Write("slot_05 content unloaded");

            }
        }
    }
}


