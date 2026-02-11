using System;

namespace ELearningSystem
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string Semester { get; set; }
        public int Credits { get; set; }
        public string Instructor { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
        public string CourseLevel { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? MaxStudents { get; set; }
        public bool IsActive { get; set; } = true;
        public string Prerequisites { get; set; }
        public string LearningObjectives { get; set; }
    }
}