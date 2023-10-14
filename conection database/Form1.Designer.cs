namespace conection_database
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.FName_Lname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FLName = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.SignUp = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // FName_Lname
            // 
            this.FName_Lname.BackColor = System.Drawing.Color.Transparent;
            this.FName_Lname.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FName_Lname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FName_Lname.Location = new System.Drawing.Point(108, 34);
            this.FName_Lname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FName_Lname.Name = "FName_Lname";
            this.FName_Lname.Size = new System.Drawing.Size(379, 42);
            this.FName_Lname.TabIndex = 0;
            this.FName_Lname.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(108, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // FLName
            // 
            this.FLName.BackColor = System.Drawing.Color.MistyRose;
            this.FLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FLName.Font = new System.Drawing.Font("Rockwell Condensed", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLName.ForeColor = System.Drawing.Color.Brown;
            this.FLName.Location = new System.Drawing.Point(341, 34);
            this.FLName.Margin = new System.Windows.Forms.Padding(4);
            this.FLName.Multiline = true;
            this.FLName.Name = "FLName";
            this.FLName.Size = new System.Drawing.Size(199, 41);
            this.FLName.TabIndex = 3;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.MistyRose;
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.Font = new System.Drawing.Font("Rockwell Condensed", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Brown;
            this.Email.Location = new System.Drawing.Point(341, 117);
            this.Email.Margin = new System.Windows.Forms.Padding(4);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(199, 41);
            this.Email.TabIndex = 4;
            // 
            // SignUp
            // 
            this.SignUp.BackColor = System.Drawing.Color.RosyBrown;
            this.SignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SignUp.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.Black;
            this.SignUp.Location = new System.Drawing.Point(33, 445);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(154, 59);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Sign up";
            this.SignUp.UseVisualStyleBackColor = false;
            this.SignUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.BackColor = System.Drawing.Color.MistyRose;
            this.ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ID.Font = new System.Drawing.Font("Rockwell Condensed", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.Color.Brown;
            this.ID.Location = new System.Drawing.Point(341, 198);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Multiline = true;
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(199, 41);
            this.ID.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(108, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.RosyBrown;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Next.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.Black;
            this.Next.Location = new System.Drawing.Point(206, 445);
            this.Next.Margin = new System.Windows.Forms.Padding(4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(154, 59);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 533);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.FLName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FName_Lname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Ticket Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label FName_Lname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FLName;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button SignUp;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Next;
    }
}

