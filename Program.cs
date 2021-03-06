using System;
using CoreSchool.Entities;
using CoreSchool.App;
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

            var reporter = new Reporter(engine.getObjectDic());
            var evaList = reporter.GetListEva();
            var listSub = reporter.GetListSubject();
            var listEvaXSub = reporter.GetDicEvaXsub();
            var listAveXSub = reporter.GetAverage();

            // Printer.WriteTitle("Usando While");
            // WriteLine("Ingrese 4 digitos: ");
            // var numer = new List<int>();
            // var view = Console.ReadLine();
            // while (view.Length < 4)
            // {
            //     WriteLine("finish");
            //     numer.Add(view);
            // }
            // WriteLine("insert a digit: ");

            // static bool EsPar(int numer)
            // {   

            //     while (numer % 2 == 0)
            //     {
            //         return true;
            //     }

            //     return false;
            // }
            // string view = Console.ReadLine();
            // int four = int.Parse(view);
            // WriteLine(EsPar(four));
            // Printer.WriteTitle("True = user par, False = user  impar");


            void Ask()
            {
                int tries = 0;
                while (tries < 4)
                {
                    WriteLine("insert a digit: ");
                    string view = Console.ReadLine();
                    int four = int.Parse(view);

                    while (  four % 2 == 0)
                    {
                        WriteLine("par");
                        break;
                    }
                    while ( four % 2 != 0)
                    {
                        WriteLine("impar");
                        break;
                    }
                    tries++;
                }
            }
            Ask();

            // Printer.WriteTitle("Evaluations by Console");
            // var newEval = new Evaluation();
            // string name, stringnote;

            // //NAME
            // WriteLine("Enter the name of the Evaluation: ");
            // Printer.PressEnter();
            // name = Console.ReadLine();
            // if (string.IsNullOrWhiteSpace(name))
            // {
            //     Printer.WriteTitle("The name can not be empty");
            //     WriteLine("Closing App");
            // }
            // else
            // {
            //     newEval.Name = name.ToLower();
            //     WriteLine("Name was set successessfully");
            // }
            //NOTE
            // WriteLine("Enter the note of the Evaluation: ");
            // Printer.PressEnter();
            // stringnote = Console.ReadLine();

            // if (string.IsNullOrWhiteSpace(stringnote))
            // {
            //     Printer.WriteTitle("Note can not be empty");
            //     WriteLine("Closing App");
            // }
            // else
            // {
            //     try
            //     {
            //         newEval.Note = float.Parse(stringnote);
            //         if (newEval.Note < 0 || newEval.Note > 5)
            //         {
            //             throw new ArgumentOutOfRangeException("The Note must be a number between 0 and 5");
            //         }
            //         WriteLine("Note was set successessfully");
            //     }
            //     catch (ArgumentOutOfRangeException arge)
            //     {
            //         Printer.WriteTitle(arge.Message);
            //         WriteLine("Closing App");
            //     }

            //     catch (Exception)
            //     {
            //         Printer.WriteTitle("The note must be a number");
            //         WriteLine("Closing App");
            //     }
            //     finally
            //     {
            //         Printer.WriteTitle("Finally");
            //         Printer.Beep(1000, 200, 1);


            //     }
            // }



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
            // Printer.Beep(3000, 1000, 3);
            Printer.Beep(1000, 200, 1);
            Printer.Beep(3400, 150, 2);

            Printer.Beep(1000, 200, 1);
            Printer.Beep(3400, 150, 2);

            Printer.Beep(2000, 120, 1);
            Printer.Beep(3100, 150, 2);
            Printer.WriteTitle("Exit");
        }


        private static void printSchoolCourses(School school)
        {
            Printer.WriteTitle("School Courses=>");


            //corto circuito de expresion de validaciones: si la primera validacion no es verdadera no preguntara para segunda, si la escuela es diferente entonces si procede a verificar si los cursos son diferentes
            if (school?.Courses != null)
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
