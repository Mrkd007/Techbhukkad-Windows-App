using System;
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
    public partial class Login : Form
    {
        string userType;
        public string userName,userId,userName1;
        private string server,port,username ;
        string myConnection = "datasource=192.168.43.29;port=3306;username=techbhukkad;password=password";
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 10;

        }

        public void getUserName()
        {
            userId = this.textBox1.Text;
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                MySqlCommand SelctCommand = new MySqlCommand("select * from techbhukkad.account where aid='" + this.textBox1.Text + "' and apassword='" + this.textBox2.Text + "' ;", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelctCommand.ExecuteReader();
                while (myReader.Read())
                {
                    userName = myReader.GetString("aname");
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlDataAdapter myDA = new MySqlDataAdapter();
                MySqlCommand SelctCommand = new MySqlCommand("select * from techbhukkad.account where aid='" + this.textBox1.Text + "' and apassword='" + this.textBox2.Text + "' ;",myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelctCommand.ExecuteReader();
                int i = 0;
                while(myReader.Read())
                {
                    i++;
                    userType = myReader.GetString("atype");
                }
                while(myReader.Read())
                {
                    userName = myReader.GetString("aname");
                }
                myConn.Close();
                {
                    int j;

                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 200;

                    for (j = 0; j <= 200; j++)
                    {
                        progressBar1.Value = j;
                        Thread.Sleep(10);
                    }
                }
                if (i == 1)
                {
                    this.Hide();
                    if(userType == "admin")
                    {
                        CashCounter frm1 = new CashCounter(this);
                        frm1.Show();
                    }
                    else if (userType == "client")
                    {
                        Kitchen frm2 = new Kitchen(this);
                        frm2.Show();
                    }
                }
                else
                    label3.Text = "Invalid Credinals Try Again!";
                myConn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
