

namespace Code_Academy.Models
{
    /// <summary>
    /// Enum for grades
    /// </summary>
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        /// <summary>
        /// the primery key for EnrollmentID
        /// </summary>
        public int EnrollmentID { get; set; }
        /// <summary>
        /// The foreign key for CourseID 
        /// </summary>
        public int CourseID { get; set; }
        /// <summary>
        /// The foreign key for StudentID 
        /// </summary>
        public int StudentID { get; set; }
        /// <summary>
        /// The enum  property for Grade
        /// </summary>
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}