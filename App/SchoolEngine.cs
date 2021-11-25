using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;
using static System.Console;

namespace CoreSchool
{
    public class SchoolEngine
    {
        public School School { get; set; }

        //evitar que los contructores tengan entrada y salida
        public SchoolEngine()
        {

        }
        public void Initialize()
        {
            School = new School("Soft School", 2001, TypeSchools.Primary,
            city: "New York",
            country: "United States"
            );

            LoadCourses();
            LoadSubject();
            LoadEvaluations();
        }

        public List<ObjectSchoolBase> GetObjectSchool(
            out int countEva,
            out int countCourses,
            out int countSubject,
            out int countStudent,
            bool getEvaluations = true,
            bool  getStudent = true, 
            bool getSubject = true,
            bool getCourses = true
            )
        {
            countEva =  countSubject = countStudent = 0;

            var listobj = new List<ObjectSchoolBase>();
            listobj.Add(School);

                if (getCourses)
                    listobj.AddRange(School.Courses);

                countCourses = School.Courses.Count;

                foreach (var course in School.Courses)
                {
                    countSubject += course.Subjects.Count;
                    countStudent += course.Students.Count;
                    
                    if (getSubject)
                         listobj.AddRange(course.Subjects);

                    if (getStudent)
                        listobj.AddRange(course.Students);

                    if (getEvaluations)
                    {
                        foreach (var student in course.Students)
                        {
                            listobj.AddRange(course.Students);
                            countEva += student.Evaluations.Count;
                        }
                    }
                }
            
            return (listobj, countEva );
        }
          public List<ObjectSchoolBase> GetObjectSchool()
        {
            var listobj = new List<ObjectSchoolBase>();
            listobj.Add(School);
            listobj.AddRange(School.Courses);

            foreach (var course in School.Courses)
            {
                listobj.AddRange(course.Subjects);
                listobj.AddRange(course.Students);

                foreach (var student in course.Students)
                {
                    listobj.AddRange(course.Students);
                }
            }
            return listobj;
        }

#region  Metodos de carga    
        private void LoadSubject()
        {
            foreach (var course in School.Courses)
            {
                var subjectList = new List<Subject>(){

                new Subject{Name = "Math "},
                new Subject{Name = "Science "},
                new Subject{Name = "Spanish"},
                new Subject{Name = "Biology"}
              };
                course.Subjects = subjectList;
            }
        }


        private void LoadEvaluations()
        {
            foreach (var course in School.Courses)
            {
                foreach (var subject in course.Subjects)
                {
                    foreach (var student in course.Students)
                    {
                        var rnd = new Random(System.Environment.TickCount);
                        for (int i = 0; i < 5; i++)
                        {
                            var ev = new Evaluation()
                            {
                                Subject = subject,
                                Name = $"{subject.Name} EV# {i + 1}",
                                Note = (float)(5 * rnd.NextDouble()),
                                Student = student
                            };
                            student.Evaluations.Add(ev);
                        }
                    }
                }
            }
        }

       

        private List<Student> CreateListStudents(int amount)
        {
            string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] lastName1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            //Cartesian product
            var studentList = from n1 in name1
                              from n2 in name2
                              from a1 in lastName1
                              select new Student { Name = $"{n1} {n2} {a1}" };

            return studentList.OrderBy((a1) => a1.UniqueId).ToList();
        }

        private void LoadCourses()
        {
            School.Courses = new List<Course>()
            {
                new Course() { Name = "101", Journey = TypeJourney.MorningShift},
                new Course() { Name = "102", Journey = TypeJourney.MorningShift},
                new Course() { Name = "103", Journey = TypeJourney.MorningShift},
                new Course() { Name = "201", Journey = TypeJourney.MorningShift},
                new Course() { Name = "202", Journey = TypeJourney.MorningShift}

            };
            Random rnd = new Random();
            foreach (var c in School.Courses)
            {
                int amountRandom = rnd.Next(5, 20);
                c.Students = CreateListStudents(amountRandom);
            }
        }
    }
    #endregion
}