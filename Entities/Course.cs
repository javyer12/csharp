using System;
using System.Collections.Generic;
using static System.Console;
using CoreSchool.Util;

namespace CoreSchool.Entities
{
  public class Course: ObjectSchoolBase, IPlace
  {
    public TypeJourney Journey { get; set; }

    public List<Subject> Subjects{get; set;}
    public List<Student> Students{get; set;}
    public string Address { get; set; }

    public  void CleanPlace()
        {
            Printer.DrawLine();
            WriteLine("Cleaning Cleaning..");
            WriteLine($"Course {Name} is clean");
        }

        // shift + alt + flecha hacia abajo (copiar la linea)
    }
}