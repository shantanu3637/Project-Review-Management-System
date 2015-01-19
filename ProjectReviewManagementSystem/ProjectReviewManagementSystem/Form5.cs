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
    public partial class Form5 : Form
    {
        String Stud_ID;
        String Ment_ID;
        public Form5(String Student_ID, String Mentor_ID)
        {
            InitializeComponent();
            Stud_ID = Student_ID;
            Ment_ID = Mentor_ID;
            Student_info(Student_ID);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(Stud_ID, Ment_ID);
            f3.ShowDialog();
        }

        public void Student_info(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from student where stud_id = '" + ID + "'";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud_name.Text = reader.GetString(1);
                    stud_rno.Text = reader.GetString(0);
                    stud_email.Text = reader.GetString(2);
                    stud_no.Text = reader.GetString(10);
                    stud_add.Text = reader.GetString(3);
                }
            }

            myConn.Close();
        }

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
