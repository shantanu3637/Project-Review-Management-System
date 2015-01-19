namespace ProjectReviewManagementSystem
{
    partial class Form1
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
            this.Mentor_ID = new System.Windows.Forms.Label();
            this.Mentor_ID_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Mentor_ID
            // 
            this.Mentor_ID.AutoSize = true;
            this.Mentor_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mentor_ID.Location = new System.Drawing.Point(87, 59);
            this.Mentor_ID.Name = "Mentor_ID";
            this.Mentor_ID.Size = new System.Drawing.Size(82, 19);
            this.Mentor_ID.TabIndex = 0;
            this.Mentor_ID.Text = "Mentor ID";
            // 
            // Mentor_ID_text
            // 
            this.Mentor_ID_text.Location = new System.Drawing.Point(175, 58);
            this.Mentor_ID_text.Name = "Mentor_ID_text";
            this.Mentor_ID_text.Size = new System.Drawing.Size(100, 20);
            this.Mentor_ID_text.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(175, 100);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(100, 20);
            this.password_text.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(175, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mentor_ID_text);
            this.Controls.Add(this.Mentor_ID);
            this.Name = "Form1";
            this.Text = "Project Review Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mentor_ID;
        private System.Windows.Forms.TextBox Mentor_ID_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button button1;
    }
}

