using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ELearningSystem
{
    public partial class MainForm : Form
    {
        // =========================
        // GLOBAL VARIABLES
        // =========================
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private int currentCourseId = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        // =========================
        // DATABASE HELPER CLASS
        // =========================
        public class DatabaseHelper
        {
            private string connectionString = ConfigurationManager.ConnectionStrings["ELearningDB"].ConnectionString;

            // GET COURSES
            public DataTable GetCourses()
            {
                DataTable table = new DataTable();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query =
                        "SELECT CourseID, CourseCode, CourseName, Semester, Credits, Instructor, " +
                        "Department, CourseLevel, StartDate, EndDate, MaxStudents, " +
                        "IsActive, Prerequisites, LearningObjectives " +
                        "FROM Courses ORDER BY CourseCode";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    connection.Open();
                    adapter.Fill(table);

                }

                return table;
            }

            // INSERT COURSE
            public bool InsertCourse(Course course)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query =
                        "INSERT INTO Courses (CourseCode, CourseName, Semester, Credits, Instructor, " +
                        "Department, CourseLevel, StartDate, EndDate, MaxStudents, " +
                        "IsActive, Prerequisites, LearningObjectives) " +
                        "VALUES (@CourseCode, @CourseName, @Semester, @Credits, @Instructor, " +
                        "@Department, @CourseLevel, @StartDate, @EndDate, @MaxStudents, " +
                        "@IsActive, @Prerequisites, @LearningObjectives)";

                    SqlCommand command = new SqlCommand(query, connection);
                    AddParameters(command, course);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }

            // UPDATE COURSE
            public bool UpdateCourse(Course course)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query =
                        "UPDATE Courses SET " +
                        "CourseCode=@CourseCode, CourseName=@CourseName, Semester=@Semester, " +
                        "Credits=@Credits, Instructor=@Instructor," +
                        "Department=@Department, CourseLevel=@CourseLevel, StartDate=@StartDate, " +
                        "EndDate=@EndDate, MaxStudents=@MaxStudents, IsActive=@IsActive, " +
                        "Prerequisites=@Prerequisites, LearningObjectives=@LearningObjectives " +
                        "WHERE CourseID=@CourseID";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@CourseID", course.CourseID);
                    AddParameters(command, course);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }

            // DELETE COURSE
            public bool DeleteCourse(int courseId)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Courses WHERE CourseID=@CourseID";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", courseId);

                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }

            // PARAMETERS (SIMPLE)
            private void AddParameters(SqlCommand command, Course course)
            {
                command.Parameters.AddWithValue("@CourseCode", course.CourseCode);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@Semester", course.Semester);
                command.Parameters.AddWithValue("@Credits", course.Credits);
                command.Parameters.AddWithValue("@Instructor", course.Instructor);



                command.Parameters.AddWithValue("@Department",
                    course.Department ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@CourseLevel",
                    course.CourseLevel ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@StartDate",
                    course.StartDate ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@EndDate",
                    course.EndDate ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@MaxStudents",
                    course.MaxStudents ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@IsActive", course.IsActive);

                command.Parameters.AddWithValue("@Prerequisites",
                    course.Prerequisites ?? (object)DBNull.Value);

                command.Parameters.AddWithValue("@LearningObjectives",
                    course.LearningObjectives ?? (object)DBNull.Value);
            }
        }

        // =========================
        // LOAD COURSES INTO GRID
        // =========================
        private void LoadCourses()
        {
            dgvCourses.DataSource = dbHelper.GetCourses();
        }

        // =========================
        // GET COURSE OBJECT FROM FORM
        // =========================
        private Course GetCourseFromForm()
        {
            Course course = new Course();

            course.CourseID = currentCourseId;
            course.CourseCode = txtCourseCode.Text;
            course.CourseName = txtCourseName.Text;
            course.Semester = cmbSemester.Text;
            course.Credits = (int)nudCredits.Value;
            course.Instructor = txtInstructor.Text;

            course.Department = cmbDepartment.Text;
            course.CourseLevel = cmbCourseLevel.Text;

            course.StartDate = dtpStartDate.Value;
            course.EndDate = dtpEndDate.Value;

            course.MaxStudents = (int)nudMaxStudents.Value;
            course.IsActive = chkActive.Checked;

            course.Prerequisites = txtPrerequisites.Text;
            course.LearningObjectives = txtLearningObjectives.Text;

            return course;
        }

        // =========================
        // CLEAR FORM
        // =========================
        private void ClearForm()
        {
            currentCourseId = 0;

            txtCourseCode.Clear();
            txtCourseName.Clear();
            cmbSemester.SelectedIndex = -1;
            nudCredits.Value = 1;
            txtInstructor.Clear();

            cmbDepartment.SelectedIndex = -1;
            cmbCourseLevel.SelectedIndex = -1;

            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;

            nudMaxStudents.Value = 1;
            chkActive.Checked = true;

            txtPrerequisites.Clear();
            txtLearningObjectives.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // =========================
        // VALIDATE INPUT
        // =========================
        private bool ValidateInput()
        {
            if (txtCourseCode.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Course Code.");
                return false;
            }

            if (txtCourseName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Course Name.");
                return false;
            }

            if (cmbSemester.Text.Trim() == "")
            {
                MessageBox.Show("Please select Semester.");
                return false;
            }

            if (nudCredits.Value <= 0)
            {
                MessageBox.Show("Credits must be greater than 0.");
                return false;
            }

            return true;
        }

        // =========================
        // LOGOUT BUTTON
        // =========================
        private void logout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }


        // =========================
        // BUTTON: UPDATE
        // =========================
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            Course course = GetCourseFromForm();

            bool saved = dbHelper.InsertCourse(course);

            if (saved)
            {
                MessageBox.Show("Course saved successfully!");
                LoadCourses();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to save course.");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (currentCourseId == 0)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            Course course = GetCourseFromForm();

            bool updated = dbHelper.UpdateCourse(course);

            if (updated)
            {
                MessageBox.Show("Course updated successfully!");
                LoadCourses();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update course.");
            }
        }


        // =========================
        // BUTTON: DELETE
        // =========================
        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (currentCourseId == 0)
            {
                MessageBox.Show("Please select a course first.");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this course?",
                "Confirm Delete",
                MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                bool deleted = dbHelper.DeleteCourse(currentCourseId);

                if (deleted)
                {
                    MessageBox.Show("Course deleted successfully!");
                    LoadCourses();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete course.");
                }
            }
        }
        // =========================
        // BUTTON: CLEAR
        // =========================
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }


        // =========================
        // BUTTON: REFRESH
        // =========================

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadCourses();
        }

        // =========================
        // GRID SELECT EVENT
        // =========================
        private void dgvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCourses.SelectedRows[0];

                currentCourseId = Convert.ToInt32(row.Cells["CourseID"].Value);

                txtCourseCode.Text = row.Cells["CourseCode"].Value.ToString();
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
                cmbSemester.Text = row.Cells["Semester"].Value.ToString();
                nudCredits.Value = Convert.ToInt32(row.Cells["Credits"].Value);
                txtInstructor.Text = row.Cells["Instructor"].Value.ToString();

                cmbDepartment.Text = row.Cells["Department"].Value.ToString();
                cmbCourseLevel.Text = row.Cells["CourseLevel"].Value.ToString();

                if (row.Cells["StartDate"].Value != DBNull.Value)
                    dtpStartDate.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);

                if (row.Cells["EndDate"].Value != DBNull.Value)
                    dtpEndDate.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);

                if (row.Cells["MaxStudents"].Value != DBNull.Value)
                    nudMaxStudents.Value = Convert.ToInt32(row.Cells["MaxStudents"].Value);

                chkActive.Checked = Convert.ToBoolean(row.Cells["IsActive"].Value);

                txtPrerequisites.Text = row.Cells["Prerequisites"].Value.ToString();
                txtLearningObjectives.Text = row.Cells["LearningObjectives"].Value.ToString();

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        // =========================
        // FORM LOAD
        // =========================
        private void MainForm_Load_1(object sender, EventArgs e)
        {
            LoadCourses();
            ClearForm();
        }
    }
}
