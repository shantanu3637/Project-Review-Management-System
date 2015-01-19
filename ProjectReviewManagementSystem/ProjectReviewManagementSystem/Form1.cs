using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace ProjectReviewManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password_text.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";
                NpgsqlConnection myConn = new NpgsqlConnection(myConnection);

                NpgsqlCommand SelectCommand = new NpgsqlCommand("select * from mentor where mentor_id ='" + this.Mentor_ID_text.Text + "' and mentor_password = '" + this.password_text.Text + "' ;", myConn);
               
                NpgsqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();

               
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }

              

                if (count == 1)
                {
                    this.Hide();
                    Form f2 = new Form2(Mentor_ID_text.Text);
                    f2.ShowDialog();
                
                  }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate Username exist.. Access Denied");
                }
                else
                    MessageBox.Show("Username and Password Incorrect... Please try again");
                myConn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
