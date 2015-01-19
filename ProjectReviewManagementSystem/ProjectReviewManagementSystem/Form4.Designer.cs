namespace ProjectReviewManagementSystem
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sessmarks = new System.Windows.Forms.TextBox();
            this.oral_marks = new System.Windows.Forms.TextBox();
            this.rdate = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(21, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 59);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Review Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Oral Marks :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(232, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sessional Marks :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // sessmarks
            // 
            this.sessmarks.Location = new System.Drawing.Point(403, 227);
            this.sessmarks.Name = "sessmarks";
            this.sessmarks.Size = new System.Drawing.Size(200, 20);
            this.sessmarks.TabIndex = 5;
            // 
            // oral_marks
            // 
            this.oral_marks.Location = new System.Drawing.Point(403, 179);
            this.oral_marks.Name = "oral_marks";
            this.oral_marks.Size = new System.Drawing.Size(200, 20);
            this.oral_marks.TabIndex = 6;
            // 
            // rdate
            // 
            this.rdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdate.Location = new System.Drawing.Point(403, 128);
            this.rdate.Name = "rdate";
            this.rdate.Size = new System.Drawing.Size(200, 20);
            this.rdate.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(468, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "SUBMIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 40);
            this.label4.TabIndex = 9;
            this.label4.Text = "New Project Review";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 422);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdate);
            this.Controls.Add(this.oral_marks);
            this.Controls.Add(this.sessmarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form4";
            this.Text = "Project Review Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sessmarks;
        private System.Windows.Forms.TextBox oral_marks;
        private System.Windows.Forms.DateTimePicker rdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}