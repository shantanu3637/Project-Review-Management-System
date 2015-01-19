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
    public partial class Form6 : Form
    {
        String Ment_ID;
        String Stud_ID;
        public Form6(String Mentor_ID, String Student_ID)
        {
            
            InitializeComponent();
            Ment_ID = Mentor_ID;
            Stud_ID = Student_ID;
            update_data();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void update_data()
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";
           
            string query1 = "select * from student where stud_id = '"+Stud_ID+"'";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            using (NpgsqlDataReader reader = SQL_command.ExecuteReader())
            {
                bool success = reader.Read();
                if (success)
                {
                    stud_name.Text = reader.GetString(1);
                    student_id.Text = reader.GetString(0);
                    stud_oral.Text = Convert.ToString(reader.GetInt32(8));
                    stud_sess.Text = Convert.ToString(reader.GetInt32(9));

                }
            }

            myConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(Stud_ID , Ment_ID);
            f3.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
