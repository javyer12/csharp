using System;
using System.Collections.Generic;
using System.Linq;
using CoreSchool.Entities;

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
      LoadSubjects();

      foreach (var course in School.Courses)
      {
        course.Students.AddRange(LoadStudents());
      }
      
      // LoadEvaluations();
    }

    private void LoadSubjects()
    {
      foreach (var course in School.Courses)
      {
          List<Subject> SubjectList = new List<Subject>()
        {
          new Subject{Name = "Math "},
          new Subject{Name = "Science "},
          new Subject{Name = "Spanish"},
          new Subject{Name = "Biology"},
        };
        course.Subjects.AddRange(SubjectList);
      }
    }

    // private void LoadEvaluations()
    // {
    //   throw new NotImplementedException();
    // }

    private IEnumerable<Student> LoadStudents()
    {
      string[] name1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
      string[] lastName1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
      string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

      //Cartesian product
      var studentList = from n1 in name1
                        from n2 in name2
                        from a1 in lastName1
                        select new Student { Name = $"{n1} {n2} {a1}" };

      return studentList;
    }

    private void LoadCourses()
    {
      School.Courses = new List<Course>()
        {
              new Course() { Name = "101", Journey = TypeJourney.MorningShift},
              new Course() { Name = "102", Journey = TypeJourney.MorningShift},
              new Course() { Name = "103", Journey = TypeJourney.MorningShift},
              new Course() { Name = "201", Journey = TypeJourney.MorningShift},
              new Course() { Name = "202", Journey = TypeJourney.MorningShift},
        };
    }
  }

}