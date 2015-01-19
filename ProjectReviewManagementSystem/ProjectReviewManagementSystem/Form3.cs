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
    public partial class Form3 : Form
    {
        String Ment_ID;
        String Stud_ID;
        public Form3(String Student_ID, String Mentor_ID)
        {
            InitializeComponent();
            Ment_ID = Mentor_ID;
            Stud_ID = Student_ID;
            Student_name(Student_ID);
            stud_ID.Text = Student_ID;
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f4 = new Form4(Stud_ID, Ment_ID);
            f4.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            this.Hide();
            Form f2 = new Form2(Ment_ID);
            f2.ShowDialog();
        }

        public void Student_name(String ID)
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
                }
            }

            myConn.Close();
        }

        private void contact_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f5 = new Form5(Stud_ID, Ment_ID);
            f5.ShowDialog();
        }

        private void marks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f6 = new Form6(Ment_ID, Stud_ID);
            f6.ShowDialog();
        }

        private void review_all_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f7 = new Form7(Stud_ID, Ment_ID);
            f7.ShowDialog();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
