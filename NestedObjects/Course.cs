using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Representation of Individual Courses
    /// </summary>
    class Course
    {
        /// <summary>
        /// The full title of the course.
        /// Ex: CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The course catalog official description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for
        /// passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The Insctructor that teaches the course
        /// </summary>
        public Instructor CourseInstructore { get; set; }

        /// <summary>
        /// All the students currently enrolled in the class
        /// </summary>
        public List<Student> Roster { get; set; }
    }
}
