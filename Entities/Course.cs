using System;
using System.Collections.Generic;

namespace CoreSchool.Entities
{
  public class Course: ObjectSchoolBase
  {
    public TypeJourney Journey { get; set; }

    public List<Subject> Subjects{get; set;}
    public List<Student> Students{get; set;}

      // shift + alt + flecha hacia abajo (copiar la linea)
  }
}