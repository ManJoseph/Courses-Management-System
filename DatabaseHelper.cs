using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ELearningSystem
{
    public class DatabaseHelper
    {
        private string connectionString;

        public DatabaseHelper()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ELearningDB"].ConnectionString;
        }

        // 1. Method to get all courses
        public DataTable GetCourses()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT CourseID, CourseCode, CourseName, Semester, Credits, Instructor, 
                                Description, Department, CourseLevel, StartDate, EndDate, MaxStudents, 
                                IsActive, Prerequisites, LearningObjectives
                                FROM Courses ORDER BY CourseCode";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }

        // 2. Method to insert a new course
        public bool InsertCourse(Course course)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO Courses 
                                (CourseCode, CourseName, Semester, Credits, Instructor, 
                                Department, CourseLevel, StartDate, EndDate, MaxStudents, IsActive, 
                                Prerequisites, LearningObjectives)
                                VALUES 
                                (@CourseCode, @CourseName, @Semester, @Credits, @Instructor,
                                @Department, @CourseLevel, @StartDate, @EndDate, @MaxStudents, @IsActive,
                                @Prerequisites, @LearningObjectives)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    AddCourseParameters(cmd, course);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 3. Method to update an existing course
        public bool UpdateCourse(Course course)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Courses SET 
                                CourseCode = @CourseCode,
                                CourseName = @CourseName,
                                Semester = @Semester,
                                Credits = @Credits,
                                Instructor = @Instructor,
                                Department = @Department,
                                CourseLevel = @CourseLevel,
                                StartDate = @StartDate,
                                EndDate = @EndDate,
                                MaxStudents = @MaxStudents,
                                IsActive = @IsActive,
                                Prerequisites = @Prerequisites,
                                LearningObjectives = @LearningObjectives,
                                ModifiedDate = GETDATE()
                                WHERE CourseID = @CourseID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", course.CourseID);
                    AddCourseParameters(cmd, course);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 4. Method to delete a course
        public bool DeleteCourse(int courseId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Courses WHERE CourseID = @CourseID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        // 5. Method to check if course code is unique
        public bool IsCourseCodeUnique(string courseCode, int excludeCourseId = 0)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Courses WHERE CourseCode = @CourseCode AND CourseID != @ExcludeCourseId";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseCode", courseCode);
                    cmd.Parameters.AddWithValue("@ExcludeCourseId", excludeCourseId);
                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count == 0; // Returns true if unique (no other course has this code)
                }
            }
        }

        // 6. Method to get a single course by ID
        public Course GetCourseById(int courseId)
        {
            Course course = null;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM Courses WHERE CourseID = @CourseID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", courseId);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            course = new Course
                            {
                                CourseID = Convert.ToInt32(reader["CourseID"]),
                                CourseCode = reader["CourseCode"].ToString(),
                                CourseName = reader["CourseName"].ToString(),
                                Semester = reader["Semester"].ToString(),
                                Credits = Convert.ToInt32(reader["Credits"]),
                                Instructor = reader["Instructor"].ToString(),
                                Department = reader["Department"].ToString(),
                                CourseLevel = reader["CourseLevel"].ToString(),
                                StartDate = reader["StartDate"] != DBNull.Value ? Convert.ToDateTime(reader["StartDate"]) : (DateTime?)null,
                                EndDate = reader["EndDate"] != DBNull.Value ? Convert.ToDateTime(reader["EndDate"]) : (DateTime?)null,
                                MaxStudents = reader["MaxStudents"] != DBNull.Value ? Convert.ToInt32(reader["MaxStudents"]) : (int?)null,
                                IsActive = Convert.ToBoolean(reader["IsActive"]),
                                Prerequisites = reader["Prerequisites"].ToString(),
                                LearningObjectives = reader["LearningObjectives"].ToString(),
                            };
                        }
                    }
                }
            }
            return course;
        }

        // 7. Helper method to add parameters (used by InsertCourse and UpdateCourse)
        private void AddCourseParameters(SqlCommand cmd, Course course)
        {
            cmd.Parameters.AddWithValue("@CourseCode", course.CourseCode);
            cmd.Parameters.AddWithValue("@CourseName", course.CourseName);
            cmd.Parameters.AddWithValue("@Semester", course.Semester);
            cmd.Parameters.AddWithValue("@Credits", course.Credits);
            cmd.Parameters.AddWithValue("@Instructor", course.Instructor);

            // Handle nullable string
            cmd.Parameters.AddWithValue("@Department",
                string.IsNullOrEmpty(course.Department) ? (object)DBNull.Value : course.Department);
            cmd.Parameters.AddWithValue("@CourseLevel",
                string.IsNullOrEmpty(course.CourseLevel) ? (object)DBNull.Value : course.CourseLevel);

            // Handle nullable dates
            cmd.Parameters.AddWithValue("@StartDate",
                course.StartDate.HasValue ? (object)course.StartDate.Value : DBNull.Value);
            cmd.Parameters.AddWithValue("@EndDate",
                course.EndDate.HasValue ? (object)course.EndDate.Value : DBNull.Value);

            // Handle nullable int
            cmd.Parameters.AddWithValue("@MaxStudents",
                course.MaxStudents.HasValue ? (object)course.MaxStudents.Value : DBNull.Value);

            cmd.Parameters.AddWithValue("@IsActive", course.IsActive);

            // Handle remaining nullable strings
            cmd.Parameters.AddWithValue("@Prerequisites",
                string.IsNullOrEmpty(course.Prerequisites) ? (object)DBNull.Value : course.Prerequisites);
            cmd.Parameters.AddWithValue("@LearningObjectives",
                string.IsNullOrEmpty(course.LearningObjectives) ? (object)DBNull.Value : course.LearningObjectives);
        }
    }
}