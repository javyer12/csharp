using System;

namespace CoreSchool.Entities
{
    public class Evaluation: ObjectSchoolBase
    {
   
        public Student Student { get; set; }

        public Subject Subject { get; set;}

        public float Note { get; set; }

        public override string ToString()
        {
            return $"{this.Note}, {this.Student}, {this.Subject}";
        }
    }
}