using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;

namespace TB12
{
    public partial class CashCounter : Form
    {
        Login form1;
        string myConnection1 = "datasource=192.168.43.29;port=3306;username=techbhukkad;password=password";
        MySqlCommand myCmd1 = new MySqlCommand();

        private MySqlConnection myConn;
        private MySqlDataReader myDr;
        private string querry, linechanger, temp1="";
        int i = 1, j = 0, count = 0 ,li1,li2,li3;
        private double diss, sum = 0, total, coupon = 0, CouponCash = 0;
        private string iName1,iName2,r1,r2,r3;
        private string start = "<Selct Option>";
        public string Cno1, Cno2, Iid1, Qty1, CTime1, Ready1, Delivery1, DTime1, TDate1, aname1, userId1;

        public CashCounter(Login form_1)
        {
            form1 = form_1;
            InitializeComponent();
            comboBox1.Text = start;
            comboBox2.Text = start;
            comboBox3.Text = start;
            billno();
            load_Picture();
            OnProcesses();
            combo1();
        }

        public void combo1()
        {
            comboBox1.Items.Clear();
            comboBox1.Refresh();
            comboBox2.Items.Clear();
            comboBox2.Refresh();
            comboBox3.Items.Clear();
            comboBox3.Refresh();
            myConn = new MySqlConnection(myConnection1);
            querry = "select distinct Icat from techbhukkad.item ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            try
            {
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                comboBox1.Text = start;
                while (myDr.Read())
                {
                    iName1 = myDr.GetString("Icat");
                    comboBox1.Items.Add(iName1);
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
            myConn.Close();
        }

        public void load_Picture()
        {
            form1.getUserName();
            label7.Text = form1.userId;
            textBox2.Text = form1.userName;
            myConn = new MySqlConnection(myConnection1);
            querry = "select * from techbhukkad.account where aid='" + label7.Text + "' ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            MySqlDataAdapter myDa = new MySqlDataAdapter(myCmd);
            MySqlCommandBuilder myCbd = new MySqlCommandBuilder(myDa);
            DataSet ds = new DataSet();
            myDa.Fill(ds);
            myConn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["aimage"]);
            MemoryStream ms = new MemoryStream(ap);
            UserPicBox.Image = Image.FromStream(ms);
            UserPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            UserPicBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Refresh();
            comboBox3.Items.Clear();
            comboBox3.Refresh();
            myConn = new MySqlConnection(myConnection1);
            querry = "select * from techbhukkad.item where Icat='" + comboBox1.Text + "' ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            try
            {
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                comboBox2.Text = start;
                    while (myDr.Read())
                    {
                        iName1 = myDr.GetString("Iname");
                        comboBox2.Items.Add(iName1);
                    }
                    myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Refresh();
            if(comboBox2.Text != null)
            {
                    while (i < 20)
                    {
                        comboBox3.Items.Add(Convert.ToString(i));
                        i++;
                    }
            }
            myConn = new MySqlConnection(myConnection1);
            querry = "select * from techbhukkad.item where Iname='" + comboBox2.Text + "' ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            myConn.Open();
            myDr = myCmd.ExecuteReader();
            while (myDr.Read())
            {
                iName2 = myDr.GetString("Iprice");
            }
            while (myDr.Read())
            {
                Iid1 = myDr.GetString("Iid");
            }
            myConn.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox2.Text == start && comboBox3.Text == start)
                {
                    MessageBox.Show("Please Select Item First.");
                    comboBox3.Text = start;
                }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                    coupon = 1;
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    Disscount.Visible = false;
                    tlabel.Visible = true;
                    textBox6.Visible = true;
            }
        }

        public void updater()
        {
            comboBox1.Text = start;
            comboBox2.Text = start;
            comboBox3.Text = start;
            checkBox2.CheckState = CheckState.Unchecked;
            checkBox1.Visible = true;
            checkBox2.Visible = true;
            Disscount.Visible = true;
        }
        public void calculator()
        {
            sum = Convert.ToInt32(comboBox3.Text) * Convert.ToInt32(iName2);
            total = total + sum;
        }
        public void billno()
        {
            myConn = new MySqlConnection(myConnection1);
            querry = "SELECT Cno FROM techbhukkad.main ORDER BY Cno DESC LIMIT 1; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            MySqlDataReader myDr;
            try
            {
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                while (myDr.Read())
                {
                    Cno1 = myDr.GetString("Cno");
                    Cno1 = Convert.ToString(Convert.ToUInt32(Cno1)+1);
                    textBox3.Text = Cno1;

                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
        }
        public void getIdno1()
        {
            myConn = new MySqlConnection(myConnection1);
            querry = "select * from techbhukkad.item where Iname='" + comboBox2.Text + "' ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            myConn.Open();
            myDr = myCmd.ExecuteReader();
            while (myDr.Read())
            {
                Iid1 = myDr.GetString("Iid");
            }
            myConn.Close();
        }
        public void DateTime1()
        {
            DateTime today = DateTime.Today;
            TDate1 = DateTime.Now.ToString("yyyy-MM-dd");
            CTime1 = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }
        public void getUserDetails()
        {
            form1.getUserName();
            aname1 = form1.userName;
            userId1 = form1.userId;
        }
        public void Adding_item()
        {
            if (Convert.ToUInt32(comboBox3.Text) > 0 && Convert.ToUInt32(comboBox3.Text) < 21)
            {
                DateTime1();
                getUserDetails();
                getIdno1();
                Qty1 = comboBox3.Text;
                Ready1 = "0";
                Delivery1 = "0";
                myConn = new MySqlConnection(myConnection1);
                querry = "INSERT INTO techbhukkad.main(Cno, Iid, Qty, CTime, Ready, Delivery, TDate, aname, CouponCheck) VALUES ('" + Cno1 + "','" + Iid1 + "','" + Qty1 + "','" + CTime1 + "','" + Ready1 + "','" + Delivery1 + "','" + TDate1 + "','" + aname1 + "','" + coupon + "') ; ";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                MySqlDataReader myDr;
                try
                {
                    myConn.Open();
                    myDr = myCmd.ExecuteReader();
                    while (myDr.Read())
                    { }
                    myConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Techbhukkad Alert");
                }
            }
            else
                MessageBox.Show("Sorry Quantity must be within 1-20", "Techbhukkad Alert");
        }
        public void printing()
        {
            count++;
            string itemstore = comboBox2.Text, l, space;
            l = itemstore.Length.ToString();
            double disscount2 = (double)Convert.ToInt32(l) * 2.5;
            int l1 = (int)disscount2;
            if (Convert.ToInt32(l) < 14)
            {
                itemstore = itemstore + "\t";
            }
            else
                itemstore = itemstore + "\t\t";
            l = iName2.Length.ToString();
            if (Convert.ToInt32(l) == 1)
                iName2 = iName2 + "     ";
            if (Convert.ToInt32(l) == 2)
                iName2 = iName2 + "  ";
            iName2 = iName2 + "                              ";
            l = comboBox3.Text.Length.ToString();
            if (Convert.ToInt32(l) == 1)
                comboBox3.Text = comboBox3.Text + "  ";
            comboBox3.Text = "        " + comboBox3.Text + "                               ";
            l = textBox1.Text.Length.ToString();
            if (Convert.ToInt32(l) == 1)
                textBox1.Text = textBox1.Text + "   ";
            if (count == 1)
                space = "\r\n\r\n\r\n\r\n\r\n                ";
            else
                space = "                 ";

            linechanger = space + " " + count + ". " + itemstore + "\t" + comboBox3.Text + "" + iName2 + "        " + sum + "/-\r\n\r\n";
            temp1 = temp1 + linechanger;
            label2.Text = Convert.ToString(total) + "/-";
            textBox1.Text = temp1;
        }
        
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == start)
            {
                MessageBox.Show("Please Enter Valid Credinals", "Techbhukkad Alert");
            }
            else if (checkBox2.CheckState == CheckState.Checked )
            {
                if (textBox6.Text == start)
                    MessageBox.Show("Please Enter Valid Credinals", "Techbhukkad Alert");
                else
                {
                    if (diss > 100)
                        MessageBox.Show("Please Eneter Valid Disscount Details(0-100)", "Techbhukkad Alert");
                    else
                    {
                        calculator();
                        Adding_item();
                        printing();
                        updater();
                        
                    }

                }
            }
            else
            {
                if (diss > 100)
                    MessageBox.Show("Please Eneter Valid Disscount Details(0-100)", "Techbhukkad Alert");
                else
                {
                    calculator();
                    Adding_item();
                    printing();
                    updater();
                }

            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                tlabel.Visible = true;
                textBox6.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                Disscount.Visible = false;
            }
        }

        public void Reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            temp1 = "";
            label2.Text = "";
            count = 0;
            sum = 0;
            total = 0;
            diss = 0;
            myConn = new MySqlConnection(myConnection1);
            int y=20;
            while (y > 0)
            {
                querry = "DELETE FROM techbhukkad.main WHERE Cno ='" + textBox3.Text + "' ; ";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                while (myDr.Read())
                { }
                myConn.Close();
                y--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            combo1();
            if (linechanger == null)
            {
                MessageBox.Show("Please Add some items first","Techbhukkad Alert");
            }
            else
            {
                billno();
                try
                {
                    CouponCash = Convert.ToInt32(textBox6.Text);
                }
                catch
                { }
                updateBill();
                textBox1.Text = "";
                temp1 = "";
                label2.Text = "";
                count = 0;
                sum = 0;
                total = 0;
                diss = 0;
                tlabel.Visible = false;
                textBox6.Visible = false;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                Disscount.Visible = true;
                textBox6.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        public void OnProcesses()
        {
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "SELECT * FROM techbhukkad.main WHERE Ready = '1' ORDER BY Cno DESC LIMIT 1 ; ";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                while (myDr.Read())
                {
                    r2 = myDr.GetString("Cno");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
            li1 = Convert.ToInt32(r2);
            li2 = Convert.ToInt32(textBox3.Text);
            readyList1.Text = Convert.ToString(li1-2);
            ReadyList2.Text = Convert.ToString(li1-1);
            ReadyList3.Text = Convert.ToString(li1);
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "SELECT * FROM techbhukkad.main WHERE Ready = '0' ORDER BY Cno ASC LIMIT 1 ; ";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                while (myDr.Read())
                {
                    r3 = myDr.GetString("Cno");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
            li3 = Convert.ToInt32(r3);
            if(li1<li2 && r3 != null)
                ReadyList4.Text = r3;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            OnProcesses();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CancelBox.Text == textBox3.Text)
                MessageBox.Show("This billNo. does not Exist.");
            else
            {
                try
                {
                    j = Convert.ToInt32(CancelBox.Text);
                    int i = Convert.ToInt32(textBox3.Text);
                    if (j > 110 && j < 1000 && j <= i)
                    {
                        try
                        {
                            myConn = new MySqlConnection(myConnection1);
                            querry = "select * from techbhukkad.main where Cno='" + CancelBox.Text + "' ; ";
                            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                            myConn.Open();
                            myDr = myCmd.ExecuteReader();
                            while (myDr.Read())
                            {
                                r1 = myDr.GetString("Ready");
                            }
                            myConn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Techbhukkad Alert");
                        }
                        if (Convert.ToInt32(r1) == 0)
                        {
                            int z = 20;
                            while (z > 0)
                            {
                                try
                                {
                                    querry = "DELETE FROM techbhukkad.main WHERE Cno ='" + CancelBox.Text + "' ; ";
                                    MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                                    myConn.Open();
                                    myDr = myCmd.ExecuteReader();
                                    while (myDr.Read())
                                    { }
                                    myConn.Close();
                                    z--;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message, "Techbhukkad Alert");
                                }
                            }
                            querry = "DELETE FROM techbhukkad.billing WHERE Cno ='" + CancelBox.Text + "' ; ";
                            MySqlCommand myCmd1 = new MySqlCommand(querry, myConn);
                            myConn.Open();
                            myDr = myCmd1.ExecuteReader();
                            while (myDr.Read())
                            { }
                            myConn.Close();
                        }
                        else
                        {
                            MessageBox.Show("Item can not be Canceled. Since it is Ready", "Techbhukkad Alert");
                        }
                    }
                    else
                        MessageBox.Show("BillNo. does not Exist.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a value to Cancel", "Techbhukkad Alert");
                }
            }
            OnProcesses();
            CancelBox.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(10);
            }
            Login formm = new Login();
            formm.Show();
            Close();
        }

        public void updateBill()
        {
            myConn = new MySqlConnection(myConnection1);
            querry = "INSERT INTO techbhukkad.billing(Cno, amount, Coupon, CouponCash) VALUES ('" + textBox3.Text + "','" + total + "','" + coupon + "','" + CouponCash + "') ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            MySqlDataReader myDr;
            try
            {
                myConn.Open();
                myDr = myCmd.ExecuteReader();
                while (myDr.Read())
                { }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
            coupon = 0;
            CouponCash = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}