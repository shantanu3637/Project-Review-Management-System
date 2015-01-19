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
    public partial class Form7 : Form
    {
        String Stud_ID;
        String Ment_ID;
        public Form7(String Student_ID, String Mentor_ID)
        {
            InitializeComponent();
            Stud_ID = Student_ID;
            Ment_ID = Mentor_ID;
            fill_data();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void fill_data()
        {
            string myConnection = "Server=localhost; Port=5432; User ID=postgres; Password=password; Database=PRMS";

            string query1 = "select project_id,review_date,stud_id,review_oralmarks,review_sessionalmarks from project_review where project_id = (select project_id from mentor where mentor_id = '"+Ment_ID+"')";
            NpgsqlConnection myConn = new NpgsqlConnection(myConnection);
            myConn.Open();
            NpgsqlCommand SQL_command = new NpgsqlCommand(query1, myConn);
            try
            {
                NpgsqlDataAdapter da = new NpgsqlDataAdapter();
                da.SelectCommand = SQL_command;
                DataTable dbdataset = new DataTable();
                da.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                da.Update(dbdataset);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Form3(Stud_ID, Ment_ID);
            f3.ShowDialog();
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
