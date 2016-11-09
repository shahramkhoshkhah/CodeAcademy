using System;
using System.Collections.Generic;

namespace Code_Academy.Models
{
    public class Student
    {
        /// <summary>
        ///  the primary key column of the database table for ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// The  properties for LastName
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// The  properties for FirstMidName
        /// </summary>
        public string FirstMidName { get; set; }
        /// <summary>
        /// the Date student was Enroll
        /// </summary>
            public DateTime EnrollmentDate { get; set; }
        /// <summary>
        /// The navigation property for Enrollments
        /// </summary>
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        }
   }
