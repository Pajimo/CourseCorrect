namespace CourseCorrect.Views
{
    partial class mainClientDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.clientProfileInfoBox = new System.Windows.Forms.ListBox();
            this.clientAppointmentBox = new System.Windows.Forms.ListBox();
            this.clientVideoCoursesBox = new System.Windows.Forms.ListBox();
            this.clientPracticalCoursesBox = new System.Windows.Forms.ListBox();
            this.btn_clientProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to your dashboard";
            // 
            // clientProfileInfoBox
            // 
            this.clientProfileInfoBox.FormattingEnabled = true;
            this.clientProfileInfoBox.ItemHeight = 15;
            this.clientProfileInfoBox.Location = new System.Drawing.Point(12, 71);
            this.clientProfileInfoBox.Name = "clientProfileInfoBox";
            this.clientProfileInfoBox.Size = new System.Drawing.Size(228, 139);
            this.clientProfileInfoBox.TabIndex = 1;
            // 
            // clientAppointmentBox
            // 
            this.clientAppointmentBox.FormattingEnabled = true;
            this.clientAppointmentBox.ItemHeight = 15;
            this.clientAppointmentBox.Location = new System.Drawing.Point(261, 71);
            this.clientAppointmentBox.Name = "clientAppointmentBox";
            this.clientAppointmentBox.Size = new System.Drawing.Size(527, 139);
            this.clientAppointmentBox.TabIndex = 2;
            // 
            // clientVideoCoursesBox
            // 
            this.clientVideoCoursesBox.FormattingEnabled = true;
            this.clientVideoCoursesBox.ItemHeight = 15;
            this.clientVideoCoursesBox.Location = new System.Drawing.Point(12, 234);
            this.clientVideoCoursesBox.Name = "clientVideoCoursesBox";
            this.clientVideoCoursesBox.Size = new System.Drawing.Size(776, 139);
            this.clientVideoCoursesBox.TabIndex = 3;
            // 
            // clientPracticalCoursesBox
            // 
            this.clientPracticalCoursesBox.FormattingEnabled = true;
            this.clientPracticalCoursesBox.ItemHeight = 15;
            this.clientPracticalCoursesBox.Location = new System.Drawing.Point(12, 403);
            this.clientPracticalCoursesBox.Name = "clientPracticalCoursesBox";
            this.clientPracticalCoursesBox.Size = new System.Drawing.Size(776, 139);
            this.clientPracticalCoursesBox.TabIndex = 3;
            // 
            // btn_clientProfile
            // 
            this.btn_clientProfile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clientProfile.Location = new System.Drawing.Point(701, 36);
            this.btn_clientProfile.Name = "btn_clientProfile";
            this.btn_clientProfile.Size = new System.Drawing.Size(87, 26);
            this.btn_clientProfile.TabIndex = 5;
            this.btn_clientProfile.Text = "Profile";
            this.btn_clientProfile.UseVisualStyleBackColor = true;
            // 
            // mainClientDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.btn_clientProfile);
            this.Controls.Add(this.clientPracticalCoursesBox);
            this.Controls.Add(this.clientVideoCoursesBox);
            this.Controls.Add(this.clientProfileInfoBox);
            this.Controls.Add(this.clientAppointmentBox);
            this.Controls.Add(this.label1);
            this.Name = "mainClientDashboard";
            this.Text = "mainClientDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox clientProfileInfoBox;
        private System.Windows.Forms.ListBox clientAppointmentBox;
        private System.Windows.Forms.ListBox clientVideoCoursesBox;
        private System.Windows.Forms.ListBox clientPracticalCoursesBox;
        private System.Windows.Forms.Button btn_clientProfile;
    }
}