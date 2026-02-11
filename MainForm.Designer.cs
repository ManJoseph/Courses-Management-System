namespace ELearningSystem
{
    partial class MainForm
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
            CourseDetails = new GroupBox();
            cmbSemester = new ComboBox();
            cmbCourseLevel = new ComboBox();
            cmbDepartment = new ComboBox();
            txtLearningObjectives = new TextBox();
            txtPrerequisites = new TextBox();
            chkActive = new CheckBox();
            nudMaxStudents = new NumericUpDown();
            dtpEndDate = new DateTimePicker();
            dtpStartDate = new DateTimePicker();
            nudCredits = new NumericUpDown();
            txtInstructor = new TextBox();
            txtCourseName = new TextBox();
            txtCourseCode = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvCourses = new DataGridView();
            label11 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnRefresh = new Button();
            lblRecordCount = new Label();
            logout = new Button();
            CourseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // CourseDetails
            // 
            CourseDetails.Controls.Add(cmbSemester);
            CourseDetails.Controls.Add(cmbCourseLevel);
            CourseDetails.Controls.Add(cmbDepartment);
            CourseDetails.Controls.Add(txtLearningObjectives);
            CourseDetails.Controls.Add(txtPrerequisites);
            CourseDetails.Controls.Add(chkActive);
            CourseDetails.Controls.Add(nudMaxStudents);
            CourseDetails.Controls.Add(dtpEndDate);
            CourseDetails.Controls.Add(dtpStartDate);
            CourseDetails.Controls.Add(nudCredits);
            CourseDetails.Controls.Add(txtInstructor);
            CourseDetails.Controls.Add(txtCourseName);
            CourseDetails.Controls.Add(txtCourseCode);
            CourseDetails.Controls.Add(label13);
            CourseDetails.Controls.Add(label12);
            CourseDetails.Controls.Add(label10);
            CourseDetails.Controls.Add(label9);
            CourseDetails.Controls.Add(label8);
            CourseDetails.Controls.Add(label7);
            CourseDetails.Controls.Add(label6);
            CourseDetails.Controls.Add(label5);
            CourseDetails.Controls.Add(label4);
            CourseDetails.Controls.Add(label3);
            CourseDetails.Controls.Add(label2);
            CourseDetails.Controls.Add(label1);
            CourseDetails.Location = new Point(704, 12);
            CourseDetails.Name = "CourseDetails";
            CourseDetails.Size = new Size(525, 586);
            CourseDetails.TabIndex = 1;
            CourseDetails.TabStop = false;
            CourseDetails.Text = "Course Details";
            // 
            // cmbSemester
            // 
            cmbSemester.FormattingEnabled = true;
            cmbSemester.Location = new Point(205, 122);
            cmbSemester.Name = "cmbSemester";
            cmbSemester.Size = new Size(284, 33);
            cmbSemester.TabIndex = 29;
            // 
            // cmbCourseLevel
            // 
            cmbCourseLevel.FormattingEnabled = true;
            cmbCourseLevel.Location = new Point(208, 278);
            cmbCourseLevel.Name = "cmbCourseLevel";
            cmbCourseLevel.Size = new Size(287, 33);
            cmbCourseLevel.TabIndex = 28;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(208, 238);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(287, 33);
            cmbDepartment.TabIndex = 27;
            // 
            // txtLearningObjectives
            // 
            txtLearningObjectives.Location = new Point(215, 540);
            txtLearningObjectives.Name = "txtLearningObjectives";
            txtLearningObjectives.Size = new Size(293, 31);
            txtLearningObjectives.TabIndex = 26;
            // 
            // txtPrerequisites
            // 
            txtPrerequisites.Location = new Point(215, 496);
            txtPrerequisites.Name = "txtPrerequisites";
            txtPrerequisites.Size = new Size(293, 31);
            txtPrerequisites.TabIndex = 25;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Location = new Point(28, 459);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(86, 29);
            chkActive.TabIndex = 24;
            chkActive.Text = "Active";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // nudMaxStudents
            // 
            nudMaxStudents.Location = new Point(209, 406);
            nudMaxStudents.Name = "nudMaxStudents";
            nudMaxStudents.Size = new Size(180, 31);
            nudMaxStudents.TabIndex = 23;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(208, 362);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(300, 31);
            dtpEndDate.TabIndex = 22;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(207, 316);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(300, 31);
            dtpStartDate.TabIndex = 21;
            // 
            // nudCredits
            // 
            nudCredits.Location = new Point(208, 161);
            nudCredits.Name = "nudCredits";
            nudCredits.Size = new Size(283, 31);
            nudCredits.TabIndex = 20;
            // 
            // txtInstructor
            // 
            txtInstructor.Location = new Point(207, 198);
            txtInstructor.Name = "txtInstructor";
            txtInstructor.Size = new Size(286, 31);
            txtInstructor.TabIndex = 17;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(205, 87);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(286, 31);
            txtCourseName.TabIndex = 14;
            // 
            // txtCourseCode
            // 
            txtCourseCode.Location = new Point(205, 49);
            txtCourseCode.Name = "txtCourseCode";
            txtCourseCode.Size = new Size(286, 31);
            txtCourseCode.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 543);
            label13.Name = "label13";
            label13.Size = new Size(166, 25);
            label13.TabIndex = 12;
            label13.Text = "Learning Objectives";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 500);
            label12.Name = "label12";
            label12.Size = new Size(116, 25);
            label12.TabIndex = 11;
            label12.Text = "Prerequisities";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 412);
            label10.Name = "label10";
            label10.Size = new Size(119, 25);
            label10.TabIndex = 9;
            label10.Text = "Max Students";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 367);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 8;
            label9.Text = "End Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 321);
            label8.Name = "label8";
            label8.Size = new Size(90, 25);
            label8.TabIndex = 7;
            label8.Text = "Start Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 286);
            label7.Name = "label7";
            label7.Size = new Size(51, 25);
            label7.TabIndex = 6;
            label7.Text = "Level";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 241);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 5;
            label6.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 204);
            label5.Name = "label5";
            label5.Size = new Size(88, 25);
            label5.TabIndex = 4;
            label5.Text = "Instructor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 167);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 3;
            label4.Text = "Credits";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 127);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Semester";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 25);
            label2.TabIndex = 1;
            label2.Text = "Course Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 0;
            label1.Text = "Course Code";
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(12, 45);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 62;
            dgvCourses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourses.Size = new Size(663, 302);
            dgvCourses.TabIndex = 2;
            dgvCourses.CellContentClick += dgvCourses_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 9);
            label11.Name = "label11";
            label11.Size = new Size(251, 32);
            label11.TabIndex = 3;
            label11.Text = "Course Management";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SeaGreen;
            btnSave.Location = new Point(346, 615);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 4;
            btnSave.Text = "✓ Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Location = new Point(491, 615);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "🖋️ Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Location = new Point(627, 615);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "🗑️ Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Location = new Point(764, 615);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 7;
            btnClear.Text = "\U0001f9f9 Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Gray;
            btnRefresh.Location = new Point(899, 615);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 34);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "🔃 Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // lblRecordCount
            // 
            lblRecordCount.AutoSize = true;
            lblRecordCount.Location = new Point(12, 624);
            lblRecordCount.Name = "lblRecordCount";
            lblRecordCount.Size = new Size(159, 25);
            lblRecordCount.TabIndex = 9;
            lblRecordCount.Text = "Courses registered";
            // 
            // logout
            // 
            logout.BackColor = Color.IndianRed;
            logout.Location = new Point(1114, 615);
            logout.Name = "logout";
            logout.Size = new Size(98, 34);
            logout.TabIndex = 10;
            logout.Text = "logout ⩥";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 661);
            Controls.Add(logout);
            Controls.Add(lblRecordCount);
            Controls.Add(btnRefresh);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(label11);
            Controls.Add(dgvCourses);
            Controls.Add(CourseDetails);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Course Management";
            Load += MainForm_Load_1;
            CourseDetails.ResumeLayout(false);
            CourseDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMaxStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox CourseDetails;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label13;
        private DataGridView dgvCourses;
        private NumericUpDown nudCredits;
        private TextBox txtInstructor;
        private TextBox txtCourseName;
        private TextBox txtCourseCode;
        private TextBox txtLearningObjectives;
        private TextBox txtPrerequisites;
        private CheckBox chkActive;
        private NumericUpDown nudMaxStudents;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label11;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnRefresh;
        private ComboBox cmbDepartment;
        private ComboBox cmbSemester;
        private ComboBox cmbCourseLevel;
        private Label lblRecordCount;
        private Button logout;
    }
}