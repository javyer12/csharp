using System;

namespace CoreSchool.Entities
{
  public class Course
  {
    public string UniqueId { get; private set; }

    public string Name { get; set; }
    public TypeJourney Journey { get; set; }

      // shift + alt + flecha hacia abajo (copiar la linea)
    public Course() =>  UniqueId = Guid.NewGuid().ToString();
    
  }
}