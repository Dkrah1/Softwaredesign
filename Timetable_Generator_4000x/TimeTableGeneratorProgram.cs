using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Timetable_Generator_4000x
{
    class TimeTableGeneratorProgram
    {
        static List<Day> week;
        static List<Course> courses;
        static List<Professor> professors;

        static List<CourseOfStudy> courseOfStudies;
        static List<Room> rooms;

        static void Main(string[] args)
        {
            LoadJsonRooms();
            foreach (Room room in rooms)
            {
                Console.WriteLine(room.roomName);
                foreach (Equipment a in room.equipment)
                    Console.WriteLine(a.ToString());
            }

            LoadJsonProfs();
            foreach (Professor professor in professors)
            {
                Console.WriteLine(professor.professorName);
                foreach (TimeSpan t in professor.impeded)
                    Console.WriteLine(t.day.ToString());
            }

            LoadJsonCourseOfStudy();
            foreach (CourseOfStudy cos in courseOfStudies)
            {
                Console.WriteLine(cos.studyProgramName);
            }

            LoadJsonCourses();
            foreach (Course course in courses)
            {
                Console.WriteLine(course.courseName);
            }

        Initializer();

        }

        public static void Initializer()
            {
                week = new List<Day>();
                week.Add(new Day(DayEnum.Monday));
                week.Add(new Day(DayEnum.Tuesday));
                week.Add(new Day(DayEnum.Wednesday));
                week.Add(new Day(DayEnum.Thursday));
                week.Add(new Day(DayEnum.Friday));
               
               
                foreach (Course course in courses)
                {
                    course.professor = (Professor)professors.FirstOrDefault(prof => prof.courses.Contains(course.courseName));
                    course.courseOfStudies = courseOfStudies.Where(_studyCourse => _studyCourse.coursesToVisit.Contains(course.courseName)).ToList);
                    course.numberOfStudents = course.courseOfStudies.Sum(_studyCourse => _studyCourse.numberOfStudents);
                    Console.WriteLine(course.courseName +": "+course.numberOfStudents);
                }
            }

        public static void LoadJsonRooms()
        {
            var data = File.ReadAllText("Room.json");
            rooms = JsonConvert.DeserializeObject<List<Room>>(data);
        }

        public static void LoadJsonProfs()
        {
            var data = File.ReadAllText("Professor.json");
            professors = JsonConvert.DeserializeObject<List<Professor>>(data);
        }

        public static void LoadJsonCourses()
        {
            var data = File.ReadAllText("Course.json");
            courses = JsonConvert.DeserializeObject<List<Course>>(data);
        }

        public static void LoadJsonCourseOfStudy()
        {
            var data = File.ReadAllText("CourseOfStudy.json");
            courseOfStudies = JsonConvert.DeserializeObject<List<CourseOfStudy>>(data);
        }

    }
}
