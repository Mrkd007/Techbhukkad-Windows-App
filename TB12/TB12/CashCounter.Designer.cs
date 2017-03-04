namespace TB12
{
    partial class CashCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashCounter));
            this.Title1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Category = new System.Windows.Forms.Label();
            this.Item = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.Disscount = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.head2 = new System.Windows.Forms.Label();
            this.head1 = new System.Windows.Forms.Label();
            this.foot1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.ReadyList4 = new System.Windows.Forms.TextBox();
            this.readyShow = new System.Windows.Forms.Label();
            this.readyList1 = new System.Windows.Forms.Label();
            this.ReadyList2 = new System.Windows.Forms.Label();
            this.ReadyList3 = new System.Windows.Forms.TextBox();
            this.ProcessShow = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.CancelBox = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title1
            // 
            this.Title1.AutoSize = true;
            this.Title1.Font = new System.Drawing.Font("Engravers MT", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title1.ForeColor = System.Drawing.Color.Navy;
            this.Title1.Location = new System.Drawing.Point(526, 123);
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(388, 31);
            this.Title1.TabIndex = 1;
            this.Title1.Text = "Cash Counter App";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Meal_Items",
            "Drinks",
            "Snacks",
            "Others"});
            this.comboBox1.Location = new System.Drawing.Point(419, 187);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(323, 26);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(419, 228);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(323, 26);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(419, 270);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(323, 26);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.Navy;
            this.Category.Location = new System.Drawing.Point(217, 190);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(230, 20);
            this.Category.TabIndex = 7;
            this.Category.Text = "Item Category : ";
            this.Category.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.Navy;
            this.Item.Location = new System.Drawing.Point(269, 231);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(165, 20);
            this.Item.TabIndex = 7;
            this.Item.Text = "Item Name : ";
            this.Item.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.Navy;
            this.Quantity.Location = new System.Drawing.Point(278, 273);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(158, 20);
            this.Quantity.TabIndex = 7;
            this.Quantity.Text = "Quantity : ";
            this.Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Disscount
            // 
            this.Disscount.AutoSize = true;
            this.Disscount.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Disscount.ForeColor = System.Drawing.Color.Navy;
            this.Disscount.Location = new System.Drawing.Point(299, 310);
            this.Disscount.Name = "Disscount";
            this.Disscount.Size = new System.Drawing.Size(130, 20);
            this.Disscount.TabIndex = 7;
            this.Disscount.Text = "Coupon : ";
            this.Disscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkBox1.Location = new System.Drawing.Point(456, 311);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 26);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "No";
            this.checkBox1.UseCompatibleTextRendering = true;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AllowDrop = true;
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.Navy;
            this.checkBox2.Location = new System.Drawing.Point(553, 312);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 24);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Yes";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Font = new System.Drawing.Font("Engravers MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(253, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(856, 318);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Addbtn.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.Navy;
            this.Addbtn.Location = new System.Drawing.Point(700, 310);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(92, 28);
            this.Addbtn.TabIndex = 12;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(620, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 24);
            this.button1.TabIndex = 13;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // head2
            // 
            this.head2.AutoSize = true;
            this.head2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.head2.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head2.Location = new System.Drawing.Point(254, 373);
            this.head2.Name = "head2";
            this.head2.Size = new System.Drawing.Size(1011, 17);
            this.head2.TabIndex = 14;
            this.head2.Text = "                      ITEM NAEME                                QUANTITY         " +
    "      PRICE                  SUBTOTAL         ";
            // 
            // head1
            // 
            this.head1.AutoSize = true;
            this.head1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.head1.Font = new System.Drawing.Font("Engravers MT", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head1.Location = new System.Drawing.Point(592, 345);
            this.head1.Name = "head1";
            this.head1.Size = new System.Drawing.Size(266, 22);
            this.head1.TabIndex = 15;
            this.head1.Text = "Payment Details";
            // 
            // foot1
            // 
            this.foot1.AutoSize = true;
            this.foot1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.foot1.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foot1.Location = new System.Drawing.Point(254, 645);
            this.foot1.Name = "foot1";
            this.foot1.Size = new System.Drawing.Size(857, 20);
            this.foot1.TabIndex = 14;
            this.foot1.Text = "                                                                                 " +
    "               TOTAL :-                            ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1001, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Font = new System.Drawing.Font("Engravers MT", 69F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Navy;
            this.textBox3.Location = new System.Drawing.Point(865, 190);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(233, 106);
            this.textBox3.TabIndex = 19;
            this.textBox3.Text = "111";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(937, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bill No : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reset.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.Navy;
            this.Reset.Location = new System.Drawing.Point(812, 310);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(95, 29);
            this.Reset.TabIndex = 20;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // ReadyList4
            // 
            this.ReadyList4.BackColor = System.Drawing.SystemColors.Control;
            this.ReadyList4.Font = new System.Drawing.Font("Engravers MT", 67F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyList4.ForeColor = System.Drawing.Color.Navy;
            this.ReadyList4.Location = new System.Drawing.Point(4, 327);
            this.ReadyList4.Multiline = true;
            this.ReadyList4.Name = "ReadyList4";
            this.ReadyList4.ReadOnly = true;
            this.ReadyList4.Size = new System.Drawing.Size(193, 105);
            this.ReadyList4.TabIndex = 21;
            this.ReadyList4.Text = "____";
            this.ReadyList4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readyShow
            // 
            this.readyShow.AutoSize = true;
            this.readyShow.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyShow.ForeColor = System.Drawing.Color.Navy;
            this.readyShow.Location = new System.Drawing.Point(4, 118);
            this.readyShow.Name = "readyShow";
            this.readyShow.Size = new System.Drawing.Size(231, 17);
            this.readyShow.TabIndex = 22;
            this.readyShow.Text = "Ready To Deliver :";
            // 
            // readyList1
            // 
            this.readyList1.AutoSize = true;
            this.readyList1.Font = new System.Drawing.Font("Engravers MT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyList1.ForeColor = System.Drawing.Color.Blue;
            this.readyList1.Location = new System.Drawing.Point(76, 169);
            this.readyList1.Name = "readyList1";
            this.readyList1.Size = new System.Drawing.Size(36, 16);
            this.readyList1.TabIndex = 23;
            this.readyList1.Text = "____";
            // 
            // ReadyList2
            // 
            this.ReadyList2.AutoSize = true;
            this.ReadyList2.Font = new System.Drawing.Font("Engravers MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyList2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ReadyList2.Location = new System.Drawing.Point(71, 196);
            this.ReadyList2.Name = "ReadyList2";
            this.ReadyList2.Size = new System.Drawing.Size(50, 22);
            this.ReadyList2.TabIndex = 24;
            this.ReadyList2.Text = "____";
            // 
            // ReadyList3
            // 
            this.ReadyList3.BackColor = System.Drawing.SystemColors.Control;
            this.ReadyList3.Font = new System.Drawing.Font("Engravers MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadyList3.ForeColor = System.Drawing.Color.Navy;
            this.ReadyList3.Location = new System.Drawing.Point(52, 228);
            this.ReadyList3.Multiline = true;
            this.ReadyList3.Name = "ReadyList3";
            this.ReadyList3.ReadOnly = true;
            this.ReadyList3.Size = new System.Drawing.Size(73, 45);
            this.ReadyList3.TabIndex = 25;
            this.ReadyList3.Text = "____";
            this.ReadyList3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProcessShow
            // 
            this.ProcessShow.AutoSize = true;
            this.ProcessShow.Font = new System.Drawing.Font("Engravers MT", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessShow.ForeColor = System.Drawing.Color.Navy;
            this.ProcessShow.Location = new System.Drawing.Point(12, 297);
            this.ProcessShow.Name = "ProcessShow";
            this.ProcessShow.Size = new System.Drawing.Size(194, 22);
            this.ProcessShow.TabIndex = 26;
            this.ProcessShow.Text = "On Process :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Engravers MT", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Navy;
            this.time.Location = new System.Drawing.Point(14, 657);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(162, 34);
            this.time.TabIndex = 27;
            this.time.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(22, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Powered By :-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Engravers MT", 17F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(1139, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 31;
            this.label7.Text = "TB2K1701";
            // 
            // UserPicBox
            // 
            this.UserPicBox.Image = global::TB12.Properties.Resources.user_login;
            this.UserPicBox.Location = new System.Drawing.Point(1131, 170);
            this.UserPicBox.Name = "UserPicBox";
            this.UserPicBox.Size = new System.Drawing.Size(192, 185);
            this.UserPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserPicBox.TabIndex = 32;
            this.UserPicBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TB12.Properties.Resources.download;
            this.pictureBox4.Location = new System.Drawing.Point(10, 470);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(188, 181);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TB12.Properties.Resources.tb_img21;
            this.pictureBox1.InitialImage = global::TB12.Properties.Resources.tb_img21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1543, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TB12.Properties.Resources.Blog_Step_by_Step_Line_200;
            this.pictureBox3.InitialImage = global::TB12.Properties.Resources.Blog_Step_by_Step_Line_200;
            this.pictureBox3.Location = new System.Drawing.Point(1117, 93);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(13, 711);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TB12.Properties.Resources.Blog_Step_by_Step_Line_200;
            this.pictureBox2.InitialImage = global::TB12.Properties.Resources.Blog_Step_by_Step_Line_200;
            this.pictureBox2.Location = new System.Drawing.Point(206, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 711);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(1145, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(174, 25);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "wwwwwwwwwwwwwww";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Navy;
            this.textBox4.Location = new System.Drawing.Point(1145, 496);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(174, 75);
            this.textBox4.TabIndex = 34;
            this.textBox4.Text = "Enter the Bill No. to Cacel the Order";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox5.Font = new System.Drawing.Font("Engravers MT", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1122, 454);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(222, 36);
            this.textBox5.TabIndex = 35;
            this.textBox5.Text = "Canceling";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CancelBox
            // 
            this.CancelBox.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBox.Location = new System.Drawing.Point(1188, 564);
            this.CancelBox.Name = "CancelBox";
            this.CancelBox.Size = new System.Drawing.Size(99, 25);
            this.CancelBox.TabIndex = 36;
            this.CancelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Navy;
            this.button2.Location = new System.Drawing.Point(1188, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 30);
            this.button2.TabIndex = 37;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Navy;
            this.button3.Location = new System.Drawing.Point(1188, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 31);
            this.button3.TabIndex = 38;
            this.button3.Text = "LogOut";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(-213, 698);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1557, 10);
            this.progressBar1.TabIndex = 39;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(570, 312);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 24);
            this.textBox6.TabIndex = 40;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.Visible = false;
            // 
            // tlabel
            // 
            this.tlabel.AutoSize = true;
            this.tlabel.Font = new System.Drawing.Font("Engravers MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlabel.ForeColor = System.Drawing.Color.Navy;
            this.tlabel.Location = new System.Drawing.Point(217, 313);
            this.tlabel.Name = "tlabel";
            this.tlabel.Size = new System.Drawing.Size(380, 20);
            this.tlabel.TabIndex = 41;
            this.tlabel.Text = "Enter coupon used amount";
            this.tlabel.Visible = false;
            // 
            // CashCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1332, 696);
            this.Controls.Add(this.tlabel);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CancelBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.UserPicBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.time);
            this.Controls.Add(this.ProcessShow);
            this.Controls.Add(this.ReadyList3);
            this.Controls.Add(this.ReadyList2);
            this.Controls.Add(this.readyList1);
            this.Controls.Add(this.readyShow);
            this.Controls.Add(this.ReadyList4);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.head1);
            this.Controls.Add(this.foot1);
            this.Controls.Add(this.head2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Disscount);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Item);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Title1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1350, 743);
            this.MinimumSize = new System.Drawing.Size(1350, 743);
            this.Name = "CashCounter";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "TechBhukkad(Cash Counter)";
            ((System.ComponentModel.ISupportInitialize)(this.UserPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Category;
        private System.Windows.Forms.Label Item;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.Label Disscount;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label head2;
        private System.Windows.Forms.Label head1;
        private System.Windows.Forms.Label foot1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.TextBox ReadyList4;
        private System.Windows.Forms.Label readyShow;
        private System.Windows.Forms.Label readyList1;
        private System.Windows.Forms.Label ReadyList2;
        private System.Windows.Forms.TextBox ReadyList3;
        private System.Windows.Forms.Label ProcessShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox UserPicBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox CancelBox;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label tlabel;

    }
}