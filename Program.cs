using System;
using CoreSchool.Entities;

namespace etapa1
{
  class Program
  {
    static void Main(string[] args)
    {
      var school = new School("Soft School", 2001, TypeSchools.Primary,
      city: "New York",
      country: "United States"
      );
      var courseArray = new Course[3];

      courseArray[0] = new Course()
      {
        Name = "1"
      };


      var course2 = new Course()
      {
        Name = "2"
      };
      courseArray[1] = course2;

      courseArray[2] = new Course
      {
        Name = "3"
      };

      Console.WriteLine(school);
      System.Console.WriteLine("=========");
      printCoursesWhile(courseArray);
      System.Console.WriteLine("=========");
    //   printCoursesDoWhile(courseArray);
      printCoursesFor(courseArray);
      System.Console.WriteLine("=========");
      printCoursesForEach(courseArray);

    }

    private static void printCoursesWhile(Course[] courseArray)
    {
      int count = 0;
      while (count < courseArray.Length)
      {
        Console.WriteLine($"Name: {courseArray[count].Name}, Id: {courseArray[count].UniqueId} ");
        count++;
      }
    }

    // private static void printCoursesDoWhile(Course[] courseArray)
    // {
    //   int count = 0;
    //   do
    //   {
    //     Console.WriteLine($"Namer: {courseArray[count].Name}, Id: {courseArray[count].UniqueId} ");
    //     // count++;
    //   } while (count++ < courseArray.Length);
    // }

    private static void printCoursesFor(Course[] courseArray)
    {
      for (int i = 0; i < courseArray.Length; i++)
      {
        Console.WriteLine($"Nam: {courseArray[i].Name}, Id: {courseArray[i].UniqueId} ");
      }
    }

    private static void printCoursesForEach(Course[] courseArray)
    {
      foreach (var course in courseArray)
      {
        Console.WriteLine($"Nombre: {course.Name}, Id: {course.UniqueId} ");
      }
    }

  }
}
