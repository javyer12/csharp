using System;
using CoreSchool.Entities;
using System.Collections.Generic;
using CoreSchool.Util;
using static System.Console;
using System.Linq;
//me permite usar todas las funciones de la clase Console obviando el uso de System.Console.

namespace CoreSchool
{
  class Program
  {
    static void Main(string[] args)
    {
      AppDomain.CurrentDomain.ProcessExit += EventAction;

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
      // Printer.Beep(1000, count: 10);
      printSchoolCourses(engine.School);

      Dictionary<int, string> dictionary = new Dictionary<int, string>();
      dictionary.Add(1, "One");
      dictionary.Add(2, "Two");
      
       foreach (var keyValPair in dictionary)
      {
        WriteLine($"Key: {keyValPair.Key}, Value: {keyValPair.Value}");
      }

      var dictem = engine.getObjectDic();
      engine.PrintDic(dictem);
      //cuando otros dev la consuman
      //devolver un tipo de lista generico
      //solo lectura si no queremos que la modifiquen clase

      //IENumerable, los otros dev podran usar el metodo con la data que nececiten

      // var ListPlace = from obj in listObjects
      //                 where obj is IPlace
      //                 select (IPlace)obj;
      //en interfaces no es lo mismo que herencias, en herencia todo el comportamiento es heredado, la interfaz me dice que cosas debe cumplir, no le digo que debe de tener pero debe de garantizar que cumpla con eso.

     // engine.School.CleanPlace();

      // Printer.DrawLine(20);
      // Printer.WriteTitle("pruebas de polimorfismo");

    //polimorfismo
      // var studentTest = new Student{Name = "Dibi tur"};
      // ObjectSchoolBase ob = studentTest;

      // Printer.WriteTitle("Student");
      // WriteLine($"Student: {studentTest.Name}");
      // WriteLine($"Student: {studentTest.UniqueId}");
      // WriteLine($"Student: {studentTest.GetType()}");

      // Printer.WriteTitle("Objeto escuela");
      // WriteLine($"Student: {ob.Name}");
      // WriteLine($"Student: {ob.UniqueId}");
      // WriteLine($"Student: {ob.GetType()}");
    }
     private static void EventAction(object sender, EventArgs e)
    {
      Printer.WriteTitle("SALIENDO DEL PROGRAMA");
      Printer.Beep(3000,1000,3);
      Printer.WriteTitle("Exit");
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
