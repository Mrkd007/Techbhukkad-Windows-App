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
using MySql.Data.MySqlClient;

namespace TB12
{
    public partial class Kitchen : Form
    {
        Login formk;
        string myConnection1 = "datasource=192.168.43.29;port=3306;username=techbhukkad;password=password";
        MySqlCommand myCmd1 = new MySqlCommand();
        private MySqlConnection myConn;
        private MySqlDataReader myDr;
        private string querry;
        private string r2, r3, temp1, temp2, temp3, temp4, DTime2;
        private int li1, li2, rowindex1, rowindex2;

        public Kitchen(Login form_k)
        {
            formk = form_k;
            InitializeComponent();
            connectionk();
            OnProcesses();
            connectionk1();
            load_Picture();
        }

        public void load_Picture()
        {
            formk.getUserName();
            label5.Text = formk.userId;
            textBox1.Text = formk.userName;
            myConn = new MySqlConnection(myConnection1);
            querry = "select * from techbhukkad.account where aid='" + label5.Text + "' ; ";
            MySqlCommand myCmd = new MySqlCommand(querry, myConn);
            MySqlDataAdapter myDa = new MySqlDataAdapter(myCmd);
            MySqlCommandBuilder myCbd = new MySqlCommandBuilder(myDa);
            DataSet ds = new DataSet();
            myDa.Fill(ds);
            myConn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["aimage"]);
            MemoryStream ms = new MemoryStream(ap);
            pictureBox5.Image = Image.FromStream(ms);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ktime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        public void connectionk()
        {
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "select distinct Cno from techbhukkad.main where Delivery='0' and Ready='1' order by Cno asc ; ";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                MySqlDataAdapter myDa = new MySqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                myDa.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = item["Cno"].ToString();
                    dataGridView2.Rows[n].Cells[1].Value = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
        }

        public void connectionk1()
        {
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "SELECT techbhukkad.item.Iname, techbhukkad.main.Qty, techbhukkad.main.Cno FROM techbhukkad.main INNER JOIN techbhukkad.item ON techbhukkad.main.Iid = techbhukkad.item.Iid WHERE techbhukkad.main.Ready = '0' ORDER BY Cno ASC;";
                MySqlCommand myCmd = new MySqlCommand(querry, myConn);
                MySqlDataAdapter myDa = new MySqlDataAdapter(myCmd);
                DataTable dt = new DataTable();
                myDa.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[1].Value = "Not Ready";
                    dataGridView1.Rows[n].Cells[0].Value = item["Cno"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = item["Iname"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = item["Qty"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Techbhukkad Alert");
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Update();
            dataGridView2.Refresh();
            connectionk();
            dataGridView1.Rows.Clear();
            dataGridView1.Update();
            dataGridView1.Refresh();
            connectionk1();
            OnProcesses();
        }

        public void OnProcesses()
        {
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "SELECT distinct Cno FROM techbhukkad.main WHERE Ready = '0' ORDER BY Cno ASC LIMIT 1 ; ";
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
            try
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "SELECT distinct Cno FROM techbhukkad.main WHERE Ready = '0' ORDER BY Cno DESC LIMIT 1 ; ";
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
            li2 = Convert.ToInt32(r3);
            if (li1 <= li2 && li1 !=0)
            {
                klabel8.Text = Convert.ToString(li1);
                li1++;
                if (li1 != li2 && li1 <= li2)
                {
                    klabel7.Text = Convert.ToString(li1);
                    li1++;
                }
                if (li1 != li2 && li1 <= li2)
                {
                    klabel6.Text = Convert.ToString(li1);
                    li1++;
                }
                if (li1 != li2 && li1 <= li2)
                {
                    klabel5.Text = Convert.ToString(li1);
                    li1++;
                }
                if (li1 != li2 && li1 <= li2)
                {
                    klabel4.Text = Convert.ToString(li1);
                    li1++;
                }
                if (li1 != li2 && li1 <= li2)
                {
                    klabel3.Text = Convert.ToString(li1);
                    li1++;
                }
            }
            else
                MessageBox.Show("All items are Ready");
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex2 = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowindex2];
            temp1 = row.Cells[0].Value.ToString();
            temp2 = row.Cells[1].Value.ToString();
        }

        public void update_Dvalue()
        {
            if (Convert.ToInt32(temp2) == 1)
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "UPDATE techbhukkad.main SET Delivery = '1', DTime = '" + DTime2 + "' WHERE Cno='" + temp1 + "' and Ready = '1' ";
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
            {
                MessageBox.Show("Can't Deliver please enter 1 to update Delivery Report",temp2);
            }
        }

        public void DateTime2()
        {
            DateTime today = DateTime.Today;
            DTime2 = DateTime.Now.ToString("HH:mm:ss", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            temp2 = "1";
            DateTime2();
            update_Dvalue();
            dataGridView2.Rows.Clear();
            dataGridView2.Update();
            dataGridView2.Refresh();
            connectionk();
            MessageBox.Show("BillNo. " + temp1 + " is Delivered. ","Techbhukkad Alert");
        }

        //to ready Items

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            update_Rvalue();
            dataGridView1.Rows.Clear();
            dataGridView1.Update();
            dataGridView1.Refresh();
            connectionk1();
            MessageBox.Show("Item " + temp4 + " is Ready. ", "Techbhukkad Alert");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex1 = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowindex1];
            temp3 = row.Cells[1].Value.ToString();
            temp4 = row.Cells[2].Value.ToString();
        }

        public void update_Rvalue()
        {
            if (temp3 == "Not Ready")
            {
                myConn = new MySqlConnection(myConnection1);
                querry = "UPDATE techbhukkad.main SET Ready = '1' WHERE Cno='" + klabel8.Text + "'and Iid=(SELECT Iid FROM techbhukkad.item WHERE Iname = '" + temp4 + "') ; ";
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
            {
                MessageBox.Show("Server Error", temp3);
            }
        }

    }
}
