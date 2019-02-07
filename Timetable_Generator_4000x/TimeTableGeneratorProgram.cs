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
        static TimeSpan[] times;
        static List<CourseOfStudy> courseOfStudies;
        static List<Room> rooms;

        static void Main(string[] args)
        {
            LoadJsonRooms();
            foreach (Room room in rooms)
            {
                Console.WriteLine(room.roomName);
                foreach (string a in room.equipment)
                    Console.WriteLine(a.ToString());
            }

            LoadJsonProfs();
            foreach (Professor professor in professors)
            {
                Console.WriteLine(professor.professorName);
                foreach (TimeSpanDay t in professor.impeded)
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

            GenerateTimeable();

        }

        public static void Initializer()
        {
            week = new List<Day>();
            week.Add(new Day(DayEnum.Monday));
            week.Add(new Day(DayEnum.Tuesday));
            week.Add(new Day(DayEnum.Wednesday));
            week.Add(new Day(DayEnum.Thursday));
            week.Add(new Day(DayEnum.Friday));

            times = new TimeSpan[6];
            times[0] = new TimeSpan(new DateTime(2019, 01, 01, 7, 45, 0), new DateTime(2019, 01, 01, 9, 15, 0));
            times[1] = new TimeSpan(new DateTime(2019, 01, 01, 9, 30, 0), new DateTime(2019, 01, 01, 11, 15, 0));
            times[2] = new TimeSpan(new DateTime(2019, 01, 01, 11, 15, 0), new DateTime(2019, 01, 01, 12, 15, 0));
            times[3] = new TimeSpan(new DateTime(2019, 01, 01, 14, 00, 0), new DateTime(2019, 01, 01, 15, 15, 0));
            times[4] = new TimeSpan(new DateTime(2019, 01, 01, 15, 45, 0), new DateTime(2019, 01, 01, 17, 15, 0));
            times[5] = new TimeSpan(new DateTime(2019, 01, 01, 17, 30, 0), new DateTime(2019, 01, 01, 19, 15, 0));

            foreach (Day day in week)
            {
                day.timeBlockNumber = new List<TimeBlock>();
                for (int i = 0; i < times.Length; i++)
                    day.timeBlockNumber.Add(new TimeBlock(times[i], i, day.day));
                {

                }
            }
            foreach (Course course in courses) // "=>" sind Lambdaausdrücke
            {
                course.professor = (Professor)professors.FirstOrDefault(prof => prof.courses.Contains(course.courseName));
                course.courseOfStudies = courseOfStudies.Where(_studyCourse => _studyCourse.coursesToVisit.Contains(course.courseName)).ToList();
                course.numberOfStudents = course.courseOfStudies.Sum(_studyCourse => _studyCourse.numberOfStudents);
                Console.WriteLine(course.courseName + ": " + course.numberOfStudents);
            }
        }

        public static void GenerateTimeable()
        {
            var timeblock = week.SelectMany(x => x.timeBlockNumber);

            foreach(Course course in courses.OrderByDescending(course => course.numberOfStudents).ToList())
            {
                course.room = rooms.OrderBy(room => room.numberOfSeats).FirstOrDefault(room =>room.numberOfSeats >= course.numberOfStudents);
                if(course.room != null){
                    if(ListHelper.ContainsAllItems<string>(course.room.equipment, course.equipmentForCourse) != false)
                        Console.WriteLine(course.courseName + "in Room: "+ course.room.roomName);
                    else
                        Console.WriteLine("course.courseName: " + "Das Material ist in keinem Raum vorhanden" );
                }else 
                    Console.WriteLine("course.courseName: " + "Es gibt keinen Raum der groß genug ist");
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

    public static class ListHelper
    {
        public static bool ContainsAllItems<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return !b.Except(a).Any();
        }
    }
}
