namespace 惯性矩求解器
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Windows.Forms;

    public class Form1 : Form
    {
        private IContainer components = null;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label5;
        private TextBox textBoxd;
        private RichTextBox richTextBox1;
        private Button button1;
        private TextBox textBoxDD;
        private Label label6;
        private TextBox textBoxb;
        private Label label7;
        private TextBox textBoxL;
        private Label label8;
        private TextBox textBoxh;
        private Label label9;
        private TextBox textBoxt;
        private Label label10;
        private TextBox textBoxtw;
        private Label label11;
        private TextBox textBoxw;
        private Label label12;
        private Label label1;
        private Label label3;
        private Label label13;
        private Label label14;
        private Panel panel1;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            double num2;
            string[] strArray;
            if (this.comboBox1.SelectedItem.ToString().Trim() == "圆形")
            {
                try
                {
                    num = double.Parse(this.textBoxd.Text.Trim());
                    num2 = ((((3.14159 * num) * num) * num) * num) / 64.0;
                    strArray = new string[] { "圆形：\nd = ", num.ToString(), " (mm) \n\nI = ", num2.ToString(), " (mm4)" };
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据格式错误！请重新填写");
                }
            }
            else if (this.comboBox1.SelectedItem.ToString().Trim() == "圆环")
            {
                try
                {
                    num = double.Parse(this.textBoxd.Text.Trim());
                    double num3 = double.Parse(this.textBoxDD.Text.Trim());
                    if (num3 <= num)
                      MessageBox.Show("输入数据错误！请重新填写");
                    num2 = (((((3.14159 * num3) * num3) * num3) * num3) * (1.0 - ((((num / num3) * (num / num3)) * (num / num3)) * (num / num3)))) / 64.0;
                    strArray = new string[] { "圆环：\nd = ", num.ToString(), " (mm) \nD = ", num3.ToString(), " (mm) \n\nI = ", num2.ToString(), " (mm4)" };
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据错误！请重新填写");
                }
            }
            else if(this.comboBox1.SelectedItem.ToString().Trim() == "矩形")
            {
                double num4;
                try
                {
                    num4 = double.Parse(this.textBoxb.Text.Trim());
                    double num5 = double.Parse(this.textBoxL.Text.Trim());
                    num2 = (((num4 * num5) * num5) * num5) / 12.0;
                    strArray = new string[] { "矩形：\nb = ", num4.ToString(), " (mm) \nL = ", num5.ToString(), " (mm) \n\nI = ", num2.ToString(), " (mm4)" };
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据错误！请重新填写");
                }
            }
            else if(this.comboBox1.SelectedItem.ToString().Trim() == "三角形")
            {
                double num6;
                double num4;
                try
                {
                    num4 = double.Parse(this.textBoxb.Text.Trim());
                    num6 = double.Parse(this.textBoxh.Text.Trim());
                    num2 = (((num4 * num6) * num6) * num6) / 36.0;
                    strArray = new string[] { "三角形：\nb = ", num4.ToString(), " (mm) \nh = ", num6.ToString(), " (mm) \n\nI = ", num2.ToString(), " (mm4)" };
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据错误！请重新填写");
                }
            }
            else if(this.comboBox1.SelectedItem.ToString().Trim() == "工字型")
            {
                double num7; 
                double num4;
                double num6;   
                try        
                {
                    num4 = double.Parse(this.textBoxb.Text.Trim());
                    num7 = double.Parse(this.textBoxt.Text.Trim());
                    double num8 = double.Parse(this.textBoxtw.Text.Trim());
                    num6 = double.Parse(this.textBoxh.Text.Trim());
                    num2 = (num4 * num7) * (num7 + num6) * (num7 + num6) / 2.0 + num8 * num6* num6 * num6 / 16.0;
                    strArray = new string[] { "工字型：\nb = ", num4.ToString(), " (mm) \nt = ", num7.ToString(), " (mm) \ntw = ", num8.ToString(), " (mm) \nh = ", num6.ToString(), " (mm) \n\nI = " , num2.ToString(), " (mm4)"};
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据错误！请重新填写");
                }
            }
            else if (this.comboBox1.SelectedItem.ToString().Trim() == "T字型")
            {   double num7; 
                double num4;
                double num6; 
                try
                {
                    num4 = double.Parse(this.textBoxb.Text.Trim());
                    num7 = double.Parse(this.textBoxt.Text.Trim());
                    double num9 = double.Parse(this.textBoxw.Text.Trim());
                    num6 = double.Parse(this.textBoxh.Text.Trim());
                    num2 = ((((((num7 + num6) * (num7 + num6)) * (num7 + num6)) * num9) / 12.0) - (((((num9 - num4) * num6) * num6) * num6) / 12.0)) - (((((((num7 + num6) * num9) * num7) / 2.0) + (((num4 * num6) * num6) / 2.0)) * (((((num7 + num6) * num9) * num7) / 2.0) + (((num4 * num6) * num6) / 2.0))) / (4.0 * ((num9 * num7) + (num4 * num6))));
                    strArray = new string[] { "T字型：\nb = ", num4.ToString(), " (mm) \nt = ", num7.ToString(), " (mm) \nw = ", num9.ToString(), " (mm) \nh = ", num6.ToString(), " (mm) \n\nI = " , num2.ToString(), " (mm4)" };
                    this.richTextBox1.Text = string.Concat(strArray);
                }
                catch
                {
                    MessageBox.Show("输入数据错误！请重新填写");
                }
            }
                    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem.ToString().Trim() == "圆形")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.1.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxd.Visible = true;
            }
            if (this.comboBox1.SelectedItem.ToString().Trim() == "圆环")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.2.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxd.Visible = true;
                this.textBoxDD.Visible = true;
            }
            if (this.comboBox1.SelectedItem.ToString().Trim() == "矩形")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.3.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxb.Visible = true;
                this.textBoxL.Visible = true;
            }
            if (this.comboBox1.SelectedItem.ToString().Trim() == "三角形")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.4.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxh.Visible = true;
                this.textBoxb.Visible = true;
            }
            if (this.comboBox1.SelectedItem.ToString().Trim() == "工字型")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.5.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxb.Visible = true;
                this.textBoxt.Visible = true;
                this.textBoxh.Visible = true;
                this.textBoxtw.Visible = true;
            }
            if (this.comboBox1.SelectedItem.ToString().Trim() == "T字型")
            {
                this.pictureBox1.Image = Image.FromFile(@"south\1.6.jpg");
                this.textBoxd.Visible = false;
                this.textBoxb.Visible = false;
                this.textBoxDD.Visible = false;
                this.textBoxh.Visible = false;
                this.textBoxL.Visible = false;
                this.textBoxt.Visible = false;
                this.textBoxtw.Visible = false;
                this.textBoxw.Visible = false;
                this.textBoxt.Visible = true;
                this.textBoxw.Visible = true;
                this.textBoxh.Visible = true;
                this.textBoxb.Visible = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (!(!disposing || ReferenceEquals(this.components, null)))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(Form1));
            this.label2 = new Label();
            this.label4 = new Label();
            this.pictureBox1 = new PictureBox();
            this.comboBox1 = new ComboBox();
            this.label5 = new Label();
            this.textBoxd = new TextBox();
            this.richTextBox1 = new RichTextBox();
            this.button1 = new Button();
            this.textBoxDD = new TextBox();
            this.label6 = new Label();
            this.textBoxb = new TextBox();
            this.label7 = new Label();
            this.textBoxL = new TextBox();
            this.label8 = new Label();
            this.textBoxh = new TextBox();
            this.label9 = new Label();
            this.textBoxt = new TextBox();
            this.label10 = new Label();
            this.textBoxtw = new TextBox();
            this.label11 = new Label();
            this.textBoxw = new TextBox();
            this.label12 = new Label();
            this.label1 = new Label();
            this.label3 = new Label();
            this.label13 = new Label();
            this.label14 = new Label();
            this.panel1 = new Panel();
            ((ISupportInitialize) this.pictureBox1).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.label2.AutoSize = true;
            this.label2.Font = new Font("仿宋_GB2312", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label2.ForeColor = Color.White;
            this.label2.Location = new Point(0x12, 0x12);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0xb7, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "常用截面惯性矩求解器";
            this.label4.AutoSize = true;
            this.label4.Font = new Font("仿宋_GB2312", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label4.ForeColor = Color.White;
            this.label4.Location = new Point(0x280, 0x12);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x1af, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "182011024易耀祖";
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = Cursors.Hand;
            this.pictureBox1.ImageLocation = "https://tse3-mm.cn.bing.net/th/id/OIP-C.HQqD-jmu603mELCXKjnYtQAAAA?pid=ImgDet&rs=1";
            this.pictureBox1.Location = new Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new Size(0x10c, 330);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
            this.comboBox1.BackColor = Color.White;
            this.comboBox1.FlatStyle = FlatStyle.Flat;
            this.comboBox1.Font = new Font("仿宋_GB2312", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.comboBox1.ForeColor = SystemColors.InfoText;
            this.comboBox1.FormattingEnabled = true;
            object[] items = new object[] { "圆形", "圆环", "矩形", "三角形", "工字型", "T字型" };
            this.comboBox1.Items.AddRange(items);
            this.comboBox1.Location = new Point(0x1a8, 0x21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(0x8e, 0x18);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new EventHandler(this.comboBox1_SelectedIndexChanged);
            this.label5.AutoSize = true;
            this.label5.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label5.Location = new Point(0x165, 0x60);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x40, 0x10);
            this.label5.TabIndex = 6;
            this.label5.Text = "d(mm)：";
            this.textBoxd.BackColor = Color.White;
            this.textBoxd.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxd.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxd.ForeColor = SystemColors.InfoText;
            this.textBoxd.Location = new Point(0x1a8, 0x5f);
            this.textBoxd.Name = "textBoxd";
            this.textBoxd.Size = new Size(0x8e, 0x18);
            this.textBoxd.TabIndex = 7;
            this.richTextBox1.BackColor = Color.White;
            this.richTextBox1.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.richTextBox1.ForeColor = SystemColors.InfoText;
            this.richTextBox1.Location = new Point(0x265, 0x45);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(0xd9, 0x112);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            this.button1.ForeColor = Color.Red;
            this.button1.Location = new Point(0x265, 0x20);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0xd9, 0x1f);
            this.button1.TabIndex = 9;
            this.button1.Text = "计　算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.textBoxDD.BackColor = Color.Gainsboro;
            this.textBoxDD.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxDD.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxDD.ForeColor = SystemColors.InfoText;
            this.textBoxDD.Location = new Point(0x1a8, 0x7f);
            this.textBoxDD.Name = "textBoxDD";
            this.textBoxDD.Size = new Size(0x8e, 0x18);
            this.textBoxDD.TabIndex = 11;
            this.label6.AutoSize = true;
            this.label6.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label6.Location = new Point(0x165, 0x80);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x40, 0x10);
            this.label6.TabIndex = 10;
            this.label6.Text = "D(mm)：";
            this.textBoxb.BackColor = Color.White;
            this.textBoxb.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxb.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxb.ForeColor = SystemColors.InfoText;
            this.textBoxb.Location = new Point(0x1a8, 0x9f);
            this.textBoxb.Name = "textBoxb";
            this.textBoxb.Size = new Size(0x8e, 0x18);
            this.textBoxb.TabIndex = 13;
            this.label7.AutoSize = true;
            this.label7.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label7.Location = new Point(0x165, 160);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x40, 0x10);
            this.label7.TabIndex = 12;
            this.label7.Text = "b(mm)：";
            this.textBoxL.BackColor = Color.White;
            this.textBoxL.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxL.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxL.ForeColor = SystemColors.InfoText;
            this.textBoxL.Location = new Point(0x1a8, 0xbf);
            this.textBoxL.Name = "textBoxL";
            this.textBoxL.Size = new Size(0x8e, 0x18);
            this.textBoxL.TabIndex = 15;
            this.label8.AutoSize = true;
            this.label8.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label8.Location = new Point(0x165, 0xc0);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x40, 0x10);
            this.label8.TabIndex = 14;
            this.label8.Text = "L(mm)：";
            this.textBoxh.BackColor = Color.White;
            this.textBoxh.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxh.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxh.ForeColor = SystemColors.InfoText;
            this.textBoxh.Location = new Point(0x1a8, 0xdf);
            this.textBoxh.Name = "textBoxh";
            this.textBoxh.Size = new Size(0x8e, 0x18);
            this.textBoxh.TabIndex = 0x11;
            this.label9.AutoSize = true;
            this.label9.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label9.Location = new Point(0x165, 0xe0);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x40, 0x10);
            this.label9.TabIndex = 0x10;
            this.label9.Text = "h(mm)：";
            this.textBoxt.BackColor = Color.White;
            this.textBoxt.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxt.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxt.ForeColor = SystemColors.InfoText;
            this.textBoxt.Location = new Point(0x1a8, 0xff);
            this.textBoxt.Name = "textBoxt";
            this.textBoxt.Size = new Size(0x8e, 0x18);
            this.textBoxt.TabIndex = 0x13;
            this.label10.AutoSize = true;
            this.label10.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label10.Location = new Point(0x165, 0x100);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x40, 0x10);
            this.label10.TabIndex = 0x12;
            this.label10.Text = "t(mm)：";
            this.textBoxtw.BackColor = Color.White;
            this.textBoxtw.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxtw.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxtw.ForeColor = SystemColors.InfoText;
            this.textBoxtw.Location = new Point(0x1a8, 0x11f);
            this.textBoxtw.Name = "textBoxtw";
            this.textBoxtw.Size = new Size(0x8e, 0x18);
            this.textBoxtw.TabIndex = 0x15;
            this.label11.AutoSize = true;
            this.label11.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label11.Location = new Point(0x155, 0x120);
            this.label11.Name = "label11";
            this.label11.Size = new Size(80, 0x10);
            this.label11.TabIndex = 20;
            this.label11.Text = "ｔw(mm)：";
            this.textBoxw.BackColor = Color.White;
            this.textBoxw.BorderStyle = BorderStyle.FixedSingle;
            this.textBoxw.Font = new Font("宋体", 11f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.textBoxw.ForeColor = SystemColors.InfoText;
            this.textBoxw.Location = new Point(0x1a8, 0x13f);
            this.textBoxw.Name = "textBoxw";
            this.textBoxw.Size = new Size(0x8e, 0x18);
            this.textBoxw.TabIndex = 0x17;
            this.label12.AutoSize = true;
            this.label12.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label12.Location = new Point(0x165, 320);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x40, 0x10);
            this.label12.TabIndex = 0x16;
            this.label12.Text = "w(mm)：";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("宋体", 12f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.label1.Location = new Point(0x13d, 0x26);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x68, 0x10);
            this.label1.TabIndex = 0x18;
            this.label1.Text = "截面形状：";
            this.label3.AutoSize = true;
            this.label3.ForeColor = Color.White;
            this.label3.Location = new Point(0x13d, 13);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x85, 14);
            this.label3.TabIndex = 0x19;
            this.label3.Text = "第一步，选择截面形状：";
            this.label13.AutoSize = true;
            this.label13.ForeColor = Color.White;
            this.label13.Location = new Point(0x13d, 0x45);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x85, 14);
            this.label13.TabIndex = 0x1a;
            this.label13.Text = "第二步，填写数据：";
            this.label14.AutoSize = true;
            this.label14.ForeColor = Color.White;
            this.label14.Location = new Point(610, 13);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x69, 14);
            this.label14.TabIndex = 0x1b;
            this.label14.Text = "第三步，计算：";
            this.panel1.BackColor = Color.Black;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new Point(-10, 0x169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(0x373, 0x4d);
            this.panel1.TabIndex = 0x1c;
            base.AutoScaleDimensions = new SizeF(7f, 13f);
            base.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.Black;
            base.ClientSize = new Size(0x356, 0x1a0);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.label14);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.textBoxw);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.textBoxtw);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.textBoxt);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.textBoxh);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.textBoxL);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.textBoxb);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.textBoxDD);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.richTextBox1);
            base.Controls.Add(this.textBoxd);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.comboBox1);
            base.Controls.Add(this.pictureBox1);
            this.Font = new Font("仿宋_GB2312", 10f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.ForeColor = Color.White;
            base.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            base.Name = "Form1";
            this.Text = "惯性矩求解器";
            ((ISupportInitialize) this.pictureBox1).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://skyciv.com/zh/free-moment-of-inertia-calculator/");
        }
    }
}

