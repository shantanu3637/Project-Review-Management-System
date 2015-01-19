namespace ProjectReviewManagementSystem
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stud_name = new System.Windows.Forms.Label();
            this.student_id = new System.Windows.Forms.Label();
            this.stud_oral = new System.Windows.Forms.Label();
            this.stud_sess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 58);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Average Oral Marks :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(138, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Sessional Marks : ";
            // 
            // stud_name
            // 
            this.stud_name.AutoSize = true;
            this.stud_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_name.Location = new System.Drawing.Point(282, 106);
            this.stud_name.Name = "stud_name";
            this.stud_name.Size = new System.Drawing.Size(70, 25);
            this.stud_name.TabIndex = 5;
            this.stud_name.Text = "label5";
            // 
            // student_id
            // 
            this.student_id.AutoSize = true;
            this.student_id.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id.Location = new System.Drawing.Point(252, 148);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(61, 23);
            this.student_id.TabIndex = 6;
            this.student_id.Text = "label6";
            // 
            // stud_oral
            // 
            this.stud_oral.AutoSize = true;
            this.stud_oral.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_oral.Location = new System.Drawing.Point(337, 186);
            this.stud_oral.Name = "stud_oral";
            this.stud_oral.Size = new System.Drawing.Size(61, 23);
            this.stud_oral.TabIndex = 7;
            this.stud_oral.Text = "label7";
            // 
            // stud_sess
            // 
            this.stud_sess.AutoSize = true;
            this.stud_sess.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_sess.Location = new System.Drawing.Point(381, 227);
            this.stud_sess.Name = "stud_sess";
            this.stud_sess.Size = new System.Drawing.Size(61, 23);
            this.stud_sess.TabIndex = 8;
            this.stud_sess.Text = "label8";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 424);
            this.Controls.Add(this.stud_sess);
            this.Controls.Add(this.stud_oral);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.stud_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form6";
            this.Text = "Project Review Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label stud_name;
        private System.Windows.Forms.Label student_id;
        private System.Windows.Forms.Label stud_oral;
        private System.Windows.Forms.Label stud_sess;
    }
}