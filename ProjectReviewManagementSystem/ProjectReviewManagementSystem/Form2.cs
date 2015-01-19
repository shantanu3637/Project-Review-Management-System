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
    public partial class Form2 : Form
    {
        string stu1_ID;
        string stu2_ID;
        string stu3_ID;
        string stu4_ID;
        String Ment_ID;
        public Form2(String Mentor_ID)
        {

            InitializeComponent();
            Ment_ID = Mentor_ID;
            Project_name(Mentor_ID);
            Project_Description(Mentor_ID);
            Department_name(Mentor_ID);
            Mentor1_name(Mentor_ID);
            Mentor2_name(Mentor_ID);
            Student1_name(Mentor_ID);
            Student2_name(Mentor_ID);
            Student3_name(Mentor_ID);
            Student4_name(Mentor_ID);

        }

        public void Project_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from project where project_id = (select project_id from mentor where mentor_id = '" + ID +"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    project_name.Text = reader.GetString(1);
                }
            }

            myConn.Close();
        }

        public void Project_Description(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from project where project_id = (select project_id from mentor where mentor_id = '" + ID + "')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    project_desp.Text = reader.GetString(3);
                }
            }

            myConn.Close();
        }

        public void Department_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from mentor where mentor_id = '" + ID + "'";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    dept_name.Text = reader.GetString(2);
                }
            }

            myConn.Close();
        }

        public void Mentor1_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from mentor where mentor_id = '" + ID + "'";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    mentor1.Text = reader.GetString(1);
                }
            }

            myConn.Close();
        }

        public void Mentor2_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from mentor where (project_id =(select project_id from mentor where mentor_id='"+ID+"') and mentor_id != '"+ID+"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    mentor2.Text = reader.GetString(1);
                }
            }

            myConn.Close();
        }

        public void Student1_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from student where project_id = (select project_id from mentor where mentor_id='" + ID + "')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud1.Text = reader.GetString(1);
                    stud1_ID.Text = reader.GetString(0);
                    stu1_ID = reader.GetString(0);

                }
            }

            myConn.Close();
        }

        public void Student2_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from student where project_id = (select project_id from mentor where mentor_id = '"+ID+"') and  (stud_id != '"+stu1_ID+"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud2.Text = reader.GetString(1);
                    stud2_ID.Text = reader.GetString(0);
                    stu2_ID = reader.GetString(0);
                }
            }

            myConn.Close();
        }

        public void Student3_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from student where project_id = (select project_id from mentor where mentor_id = '"+ID+"') and  (stud_id != '"+stu1_ID+"') and (stud_id != '"+stu2_ID+"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud3.Text = reader.GetString(1);
                    stud3_ID.Text = reader.GetString(0);
                    stu3_ID = reader.GetString(0);
                }
            }

            myConn.Close();
        }

        public void Student4_name(String ID)
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select * from student where project_id = (select project_id from mentor where mentor_id = '"+ID+"') and  (stud_id != '"+stu1_ID+"') and (stud_id != '"+stu2_ID+"') and (stud_id != '"+stu3_ID+"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud4.Text = reader.GetString(1);
                    stud4_ID.Text = reader.GetString(0);
                    stu4_ID = reader.GetString(0);
                }
            }

            myConn.Close();
        }

        private void mentor1_Click(object sender, EventArgs e)
        {

        }

        private void mentor2_Click(object sender, EventArgs e)
        {

        }

        private void project_name_Click(object sender, EventArgs e)
        {
            
        }

        private void stud1_Click(object sender, EventArgs e)
        {

        }

        private void stud1_ID_Click(object sender, EventArgs e)
        {

        }

        private void dept_name_Click(object sender, EventArgs e)
        {

        }

        private void stud1_ID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(stu1_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void stud2_ID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(stu2_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void stud3_ID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(stu3_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void stud4_ID_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(stu4_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1= new Form1();
            f1.ShowDialog();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
