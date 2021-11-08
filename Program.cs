using System;
using CoreSchool.Entities;
using System.Collections.Generic;
using CoreSchool.Util;
using static System.Console; //me permite usar todas las funciones de la clase Console obviando el uso de System.Console.

namespace CoreSchool
{
  class Program
  {
    static void Main(string[] args)
    {
                  //APRENDIZAJE DE C#
                  // var school = new School("Soft School", 2001, TypeSchools.Primary,
                  // city: "New York",
                  // country: "United States"
                  // );

                  // //colecciones
                  // //generico: se debe utilizar para un tipo de dato especifico
                  // //addRange, podemos agregar una coleccion a otra coleccion
                  // school.Courses = new List<Course>()
                  // {
                  //   new Course() { Name = "101", Journey = TypeJourney.MorningShift},
                  //   new Course() { Name = "102", Journey = TypeJourney.MorningShift},
                  //   new Course() { Name = "103", Journey = TypeJourney.MorningShift},
                  // };

                  // school.Courses.Add( new Course { Name = "104", Journey = TypeJourney.WeenkendDay});

                  // var anotherOne =  new List<Course>()
                  // {
                  //   new Course() { Name = "201", Journey = TypeJourney.MorningShift},
                  //   new Course() { Name = "202", Journey = TypeJourney.MorningShift},
                  //   new Course() { Name = "203", Journey = TypeJourney.MorningShift},
                  // };

                  //borrar la coleccion 
                  // anotherOne.Clear();

                  //removeAll borrar todos los elementos que cumplan con la condicion
                  // school.Courses.RemoveAll(course => course.Name.Contains("104"));
                  //school.Courses.Remove(course_name)

                  // school.Courses.AddRange(anotherOne);

                  //arrays
                  // school.Courses = new Course[]{
                  //   new Course() { Name = "101" },
                  //   new Course() { Name = "102" },
                  //   new Course() { Name = "103"},
                  // };

                  // school.Courses = null;
      var engine = new SchoolEngine();
      engine.Initialize();
      Printer.WriteTitle("WELCOME TO SCHOOL");
      Printer.Beep(1000, count: 10);

      
      printSchoolCourses(engine.School);
    }

    private static void printSchoolCourses(School school)
    {
      Printer.WriteTitle("School Courses=>");


//corto circuito de expresion de validaciones: si la primera validacion no es verdadera no preguntara para segunda, si la escuela es diferente entonces si procede a verificar si los cursos son diferentes
      if ( school?.Courses != null)
      {
        foreach (var course in school.Courses)
        {
          WriteLine($"Name: {course.Name}, Id: {course.UniqueId}");
        }
      }
      else
      {
        WriteLine("The school has no courses");
      }

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
