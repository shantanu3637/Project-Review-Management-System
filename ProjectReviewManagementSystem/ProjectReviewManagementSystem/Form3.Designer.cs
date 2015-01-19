namespace ProjectReviewManagementSystem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.stud_name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.stud_ID = new System.Windows.Forms.Label();
            this.review = new System.Windows.Forms.Button();
            this.marks = new System.Windows.Forms.Button();
            this.contact = new System.Windows.Forms.Button();
            this.review_all = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name : ";
            // 
            // stud_name
            // 
            this.stud_name.AutoSize = true;
            this.stud_name.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_name.Location = new System.Drawing.Point(319, 22);
            this.stud_name.Name = "stud_name";
            this.stud_name.Size = new System.Drawing.Size(56, 23);
            this.stud_name.TabIndex = 2;
            this.stud_name.Text = "name";
            this.stud_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student ID : ";
            // 
            // stud_ID
            // 
            this.stud_ID.AutoSize = true;
            this.stud_ID.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_ID.Location = new System.Drawing.Point(285, 57);
            this.stud_ID.Name = "stud_ID";
            this.stud_ID.Size = new System.Drawing.Size(31, 23);
            this.stud_ID.TabIndex = 4;
            this.stud_ID.Text = "ID";
            // 
            // review
            // 
            this.review.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review.Location = new System.Drawing.Point(169, 144);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(197, 45);
            this.review.TabIndex = 5;
            this.review.Text = "Add Review";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.button2_Click);
            // 
            // marks
            // 
            this.marks.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marks.Location = new System.Drawing.Point(169, 241);
            this.marks.Name = "marks";
            this.marks.Size = new System.Drawing.Size(197, 45);
            this.marks.TabIndex = 6;
            this.marks.Text = "Average Marks";
            this.marks.UseVisualStyleBackColor = true;
            this.marks.Click += new System.EventHandler(this.marks_Click);
            // 
            // contact
            // 
            this.contact.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(429, 146);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(197, 45);
            this.contact.TabIndex = 7;
            this.contact.Text = "Contact Info";
            this.contact.UseVisualStyleBackColor = true;
            this.contact.Click += new System.EventHandler(this.contact_Click);
            // 
            // review_all
            // 
            this.review_all.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.review_all.Location = new System.Drawing.Point(429, 241);
            this.review_all.Name = "review_all";
            this.review_all.Size = new System.Drawing.Size(197, 45);
            this.review_all.TabIndex = 8;
            this.review_all.Text = "All Reviews";
            this.review_all.UseVisualStyleBackColor = true;
            this.review_all.Click += new System.EventHandler(this.review_all_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(22, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 59);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.review_all);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.marks);
            this.Controls.Add(this.review);
            this.Controls.Add(this.stud_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stud_name);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Project Review Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stud_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label stud_ID;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button marks;
        private System.Windows.Forms.Button contact;
        private System.Windows.Forms.Button review_all;
        private System.Windows.Forms.Button button1;
    }
}