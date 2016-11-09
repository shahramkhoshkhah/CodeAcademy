
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Code_Academy.Models
{
    public class Course
    {
        /// <summary>
        /// The primary key for courses
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        /// <summary>
        /// The title of the course
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Credits earned for the course
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// List of enrollments in the course
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
   