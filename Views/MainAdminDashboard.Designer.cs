namespace CourseCorrect.Views
{
    partial class MainAdminDashboard
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
            this.adminAppointmentsBox = new System.Windows.Forms.ListBox();
            this.adminPracticalSessionsBox = new System.Windows.Forms.ListBox();
            this.adminTutorAvailabilty = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.creditManagerBox = new System.Windows.Forms.ListBox();
            this.adminNewCourseBox = new System.Windows.Forms.ListBox();
            this.adminCourseOverviewBox = new System.Windows.Forms.ListBox();
            this.waitingListManagerBox = new System.Windows.Forms.ListBox();
            this.btn_adminProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminAppointmentsBox
            // 
            this.adminAppointmentsBox.FormattingEnabled = true;
            this.adminAppointmentsBox.ItemHeight = 15;
            this.adminAppointmentsBox.Location = new System.Drawing.Point(12, 253);
            this.adminAppointmentsBox.Name = "adminAppointmentsBox";
            this.adminAppointmentsBox.Size = new System.Drawing.Size(776, 139);
            this.adminAppointmentsBox.TabIndex = 3;
            // 
            // adminPracticalSessionsBox
            // 
            this.adminPracticalSessionsBox.FormattingEnabled = true;
            this.adminPracticalSessionsBox.ItemHeight = 15;
            this.adminPracticalSessionsBox.Location = new System.Drawing.Point(12, 90);
            this.adminPracticalSessionsBox.Name = "adminPracticalSessionsBox";
            this.adminPracticalSessionsBox.Size = new System.Drawing.Size(776, 139);
            this.adminPracticalSessionsBox.TabIndex = 3;
            // 
            // adminTutorAvailabilty
            // 
            this.adminTutorAvailabilty.FormattingEnabled = true;
            this.adminTutorAvailabilty.ItemHeight = 15;
            this.adminTutorAvailabilty.Location = new System.Drawing.Point(12, 581);
            this.adminTutorAvailabilty.Name = "adminTutorAvailabilty";
            this.adminTutorAvailabilty.Size = new System.Drawing.Size(776, 139);
            this.adminTutorAvailabilty.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your dashboard";
            // 
            // creditManagerBox
            // 
            this.creditManagerBox.FormattingEnabled = true;
            this.creditManagerBox.ItemHeight = 15;
            this.creditManagerBox.Location = new System.Drawing.Point(12, 418);
            this.creditManagerBox.Name = "creditManagerBox";
            this.creditManagerBox.Size = new System.Drawing.Size(163, 139);
            this.creditManagerBox.TabIndex = 4;
            // 
            // adminNewCourseBox
            // 
            this.adminNewCourseBox.FormattingEnabled = true;
            this.adminNewCourseBox.ItemHeight = 15;
            this.adminNewCourseBox.Location = new System.Drawing.Point(214, 418);
            this.adminNewCourseBox.Name = "adminNewCourseBox";
            this.adminNewCourseBox.Size = new System.Drawing.Size(163, 139);
            this.adminNewCourseBox.TabIndex = 4;
            // 
            // adminCourseOverviewBox
            // 
            this.adminCourseOverviewBox.FormattingEnabled = true;
            this.adminCourseOverviewBox.ItemHeight = 15;
            this.adminCourseOverviewBox.Location = new System.Drawing.Point(421, 418);
            this.adminCourseOverviewBox.Name = "adminCourseOverviewBox";
            this.adminCourseOverviewBox.Size = new System.Drawing.Size(163, 139);
            this.adminCourseOverviewBox.TabIndex = 4;
            // 
            // waitingListManagerBox
            // 
            this.waitingListManagerBox.FormattingEnabled = true;
            this.waitingListManagerBox.ItemHeight = 15;
            this.waitingListManagerBox.Location = new System.Drawing.Point(625, 418);
            this.waitingListManagerBox.Name = "waitingListManagerBox";
            this.waitingListManagerBox.Size = new System.Drawing.Size(163, 139);
            this.waitingListManagerBox.TabIndex = 4;
            // 
            // btn_adminProfile
            // 
            this.btn_adminProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adminProfile.Location = new System.Drawing.Point(12, 28);
            this.btn_adminProfile.Name = "btn_adminProfile";
            this.btn_adminProfile.Size = new System.Drawing.Size(87, 26);
            this.btn_adminProfile.TabIndex = 5;
            this.btn_adminProfile.Text = "Profile";
            this.btn_adminProfile.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(701, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adminProfile);
            this.Controls.Add(this.adminNewCourseBox);
            this.Controls.Add(this.adminCourseOverviewBox);
            this.Controls.Add(this.waitingListManagerBox);
            this.Controls.Add(this.creditManagerBox);
            this.Controls.Add(this.adminTutorAvailabilty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adminAppointmentsBox);
            this.Controls.Add(this.adminPracticalSessionsBox);
            this.Name = "MainAdminDashboard";
            this.Text = "MainAdminDashboard";
            this.Load += new System.EventHandler(this.MainAdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox adminAppointmentsBox;
        private System.Windows.Forms.ListBox adminPracticalSessionsBox;
        private System.Windows.Forms.ListBox adminTutorAvailabilty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox creditManagerBox;
        private System.Windows.Forms.ListBox adminNewCourseBox;
        private System.Windows.Forms.ListBox adminCourseOverviewBox;
        private System.Windows.Forms.ListBox waitingListManagerBox;
        private System.Windows.Forms.Button btn_adminProfile;
        private System.Windows.Forms.Button button1;
    }
}