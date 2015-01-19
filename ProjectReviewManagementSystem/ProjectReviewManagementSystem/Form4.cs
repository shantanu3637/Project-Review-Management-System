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
    public partial class Form4 : Form
    {
        String Stud_ID;
        String Ment_ID;
        public Form4(String Student_ID, String Mentor_ID)
        {
            
            InitializeComponent();
            Stud_ID = Student_ID;
            Ment_ID = Mentor_ID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(Stud_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(oral_marks.Text))
            {
                MessageBox.Show("Please Enter Oral Marks");
            }
            else if (String.IsNullOrEmpty(sessmarks.Text))
            {
                MessageBox.Show("Please Enter Sessional Marks");
            }
            else if (Convert.ToInt32(oral_marks.Text) > 100 || Convert.ToInt32(oral_marks.Text) < 0)
            {
                MessageBox.Show("Please Enter Oral Marks from 0 - 100");
            }
            else if (Convert.ToInt32(sessmarks.Text) > 100 || Convert.ToInt32(sessmarks.Text) < 0)
            {
                MessageBox.Show("Please Enter Sessional Marks from 0 - 100");
            }
            else
            {
                enter_data();
                update_studmarks();
                MessageBox.Show("Marks Added to Database");
                this.Hide();
                Form f3 = new Form3(Stud_ID, Ment_ID);
                f3.ShowDialog();
            }
        }

        public void enter_data()
        {
            String date = rdate.Value.ToString("dd/MM/yyyy");
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "insert into project_review (project_id,review_date,stud_id,review_oralmarks, review_sessionalmarks,mentor_id) values ((select project_id from mentor where mentor_id = '"+ Ment_ID +"'),'"+date+"','"+Stud_ID+"',"+this.oral_marks.Text+","+this.sessmarks.Text+",'"+Ment_ID+"');";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            NpgsqlDataReader reader = SQL_command.ExecuteReader();


            myConn.Close();

        }

        public void update_studmarks()
        {
            String date = rdate.Value.ToString("dd/MM/yyyy");
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "update student set stud_oralmarks = (select avg(review_oralmarks) from project_review where stud_id = '"+Stud_ID+"'), stud_sessionalmarks = (select avg(review_sessionalmarks) from project_review where stud_id = '"+Stud_ID+"') where stud_id = '"+Stud_ID+"'";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            NpgsqlDataReader reader = SQL_command.ExecuteReader();


            myConn.Close();

        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
