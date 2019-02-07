using System;
using System.Collections.Generic;

namespace Timetable_Generator_4000x
{
    class Course
    {
        public string courseName;
        public Room room;

        public int numberOfStudents;

        public Professor professor;

        public TimeBlock timeblock;

        public string courseContent;

        public List<Equipment> equiptmentForCourse;

        public List<CourseOfStudy> courseOfStudies;

    

    }
}