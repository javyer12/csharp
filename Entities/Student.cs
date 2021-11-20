using System.Collections.Generic;

namespace CoreSchool.Entities
{
    public class Student: ObjectSchoolBase
    {
        public List<Evaluation> Evaluations { get; private set;  }  = new List<Evaluation>();

    }
}