using System;
using System.Windows.Forms;
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
            pathbox.Text = save_path;
        }


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            saveFileDialog1 = new SaveFileDialog();
            imageList1 = new ImageList(components);
            groupBox3 = new GroupBox();
            groupBox1 = new GroupBox();
            locate = new Button();
            pathbox = new TextBox();
            groupBox2 = new GroupBox();
            read = new Button();
            saveall = new Button();
            save = new Button();
            pictureBox5 = new PictureBox();
            checkBox7 = new CheckBox();
            pictureBox1 = new PictureBox();
            checkBox6 = new CheckBox();
            pictureBox2 = new PictureBox();
            checkBox5 = new CheckBox();
            pictureBox3 = new PictureBox();
            checkBox4 = new CheckBox();
            pictureBox4 = new PictureBox();
            checkBox3 = new CheckBox();
            pictureBox6 = new PictureBox();
            checkBox2 = new CheckBox();
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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home.png");
            imageList1.Images.SetKeyName(1, "armors.png");
            imageList1.Images.SetKeyName(2, "Bows.png");
            imageList1.Images.SetKeyName(3, "shields.png");
            imageList1.Images.SetKeyName(4, "Weapons.png");
            imageList1.Images.SetKeyName(5, "items.png");
            imageList1.Images.SetKeyName(6, "food.png");
            imageList1.Images.SetKeyName(7, "zonais.png");
            imageList1.Images.SetKeyName(8, "ketitems.png");
            imageList1.Images.SetKeyName(9, "horses.png");
            imageList1.Images.SetKeyName(10, "others.png");
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.bg_black;
            groupBox3.FlatStyle = FlatStyle.Flat;
            groupBox3.ForeColor = Color.FromArgb(255, 192, 128);
            groupBox3.Location = new Point(3, 879);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(524, 106);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Runtime logs";
            groupBox3.Enter += groupBox3_Enter;
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
            groupBox1.Size = new Size(524, 96);
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
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(checkBox6);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(pictureBox3);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(pictureBox6);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(255, 192, 128);
            groupBox2.Location = new Point(3, 397);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 476);
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
            read.Location = new Point(9, 428);
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
            saveall.Location = new Point(391, 428);
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
            save.Location = new Point(266, 428);
            save.Name = "save";
            save.Size = new Size(117, 29);
            save.TabIndex = 10;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += button1_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.bg_black;
            pictureBox5.Image = Properties.Resources._blank;
            pictureBox5.Location = new Point(368, 183);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(140, 90);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackgroundImage = Properties.Resources.bg_black;
            checkBox7.FlatStyle = FlatStyle.Flat;
            checkBox7.Location = new Point(266, 347);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(98, 25);
            checkBox7.TabIndex = 28;
            checkBox7.Text = "Slot_05";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bg_black;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources._blank;
            pictureBox1.Location = new Point(103, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackgroundImage = Properties.Resources.bg_black;
            checkBox6.FlatStyle = FlatStyle.Flat;
            checkBox6.Location = new Point(266, 221);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(98, 25);
            checkBox6.TabIndex = 27;
            checkBox6.Text = "Slot_04";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.bg_black;
            pictureBox2.Image = Properties.Resources._blank;
            pictureBox2.Location = new Point(103, 183);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(140, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackgroundImage = Properties.Resources.bg_black;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Location = new Point(266, 95);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(98, 25);
            checkBox5.TabIndex = 26;
            checkBox5.Text = "Slot_03";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.bg_black;
            pictureBox3.Image = Properties.Resources._blank;
            pictureBox3.Location = new Point(103, 312);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(140, 90);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackgroundImage = Properties.Resources.bg_black;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(5, 347);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(98, 25);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "Slot_02";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.bg_black;
            pictureBox4.Image = Properties.Resources._blank;
            pictureBox4.Location = new Point(368, 63);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(140, 90);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackgroundImage = Properties.Resources.bg_black;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(5, 221);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(98, 25);
            checkBox3.TabIndex = 24;
            checkBox3.Text = "Slot_01";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = Properties.Resources.bg_black;
            pictureBox6.Image = Properties.Resources._blank;
            pictureBox6.Location = new Point(368, 312);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(140, 90);
            pictureBox6.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackgroundImage = Properties.Resources.bg_black;
            checkBox2.FlatStyle = FlatStyle.Flat;
            checkBox2.Location = new Point(6, 95);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(98, 25);
            checkBox2.TabIndex = 23;
            checkBox2.Text = "Slot_00";
            checkBox2.UseVisualStyleBackColor = true;
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
            flowLayoutPanel1.Size = new Size(536, 1000);
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
            panel1.Size = new Size(542, 286);
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
            // 
            // bow
            // 
            bow.Image = (Image)resources.GetObject("bow.Image");
            bow.Location = new Point(785, 12);
            bow.Name = "bow";
            bow.Size = new Size(60, 60);
            bow.TabIndex = 10;
            bow.UseVisualStyleBackColor = true;
            // 
            // food
            // 
            food.Image = (Image)resources.GetObject("food.Image");
            food.Location = new Point(1104, 12);
            food.Name = "food";
            food.Size = new Size(60, 60);
            food.TabIndex = 11;
            food.UseVisualStyleBackColor = true;
            // 
            // armor
            // 
            armor.Image = (Image)resources.GetObject("armor.Image");
            armor.Location = new Point(706, 12);
            armor.Name = "armor";
            armor.Size = new Size(60, 60);
            armor.TabIndex = 12;
            armor.UseVisualStyleBackColor = true;
            // 
            // horse
            // 
            horse.Image = (Image)resources.GetObject("horse.Image");
            horse.Location = new Point(1344, 12);
            horse.Name = "horse";
            horse.Size = new Size(60, 60);
            horse.TabIndex = 13;
            horse.UseVisualStyleBackColor = true;
            // 
            // keyitem
            // 
            keyitem.Image = (Image)resources.GetObject("keyitem.Image");
            keyitem.Location = new Point(1265, 12);
            keyitem.Name = "keyitem";
            keyitem.Size = new Size(60, 60);
            keyitem.TabIndex = 14;
            keyitem.UseVisualStyleBackColor = true;
            // 
            // material
            // 
            material.Image = (Image)resources.GetObject("material.Image");
            material.Location = new Point(1022, 12);
            material.Name = "material";
            material.Size = new Size(60, 60);
            material.TabIndex = 15;
            material.UseVisualStyleBackColor = true;
            // 
            // others
            // 
            others.Image = (Image)resources.GetObject("others.Image");
            others.Location = new Point(1422, 12);
            others.Name = "others";
            others.Size = new Size(60, 60);
            others.TabIndex = 16;
            others.UseVisualStyleBackColor = true;
            // 
            // shield
            // 
            shield.Image = (Image)resources.GetObject("shield.Image");
            shield.Location = new Point(864, 12);
            shield.Name = "shield";
            shield.Size = new Size(60, 60);
            shield.TabIndex = 17;
            shield.UseVisualStyleBackColor = true;
            // 
            // weapon
            // 
            weapon.Image = (Image)resources.GetObject("weapon.Image");
            weapon.Location = new Point(942, 12);
            weapon.Name = "weapon";
            weapon.Size = new Size(60, 60);
            weapon.TabIndex = 18;
            weapon.UseVisualStyleBackColor = true;
            // 
            // zonai
            // 
            zonai.Image = (Image)resources.GetObject("zonai.Image");
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private SaveFileDialog saveFileDialog1;
        private ImageList imageList1;
        private GroupBox groupBox3;
        private GroupBox groupBox1;
        private Button locate;
        private TextBox pathbox;
        private GroupBox groupBox2;
        private PictureBox pictureBox5;
        private CheckBox checkBox7;
        private PictureBox pictureBox1;
        private CheckBox checkBox6;
        private PictureBox pictureBox2;
        private CheckBox checkBox5;
        private PictureBox pictureBox3;
        private CheckBox checkBox4;
        private PictureBox pictureBox4;
        private CheckBox checkBox3;
        private PictureBox pictureBox6;
        private CheckBox checkBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
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
            //_SaveFile = new TOTK_SaveFile(FileDialog.FileName);
        }
    }
}


