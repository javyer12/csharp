using System;

namespace CoreSchool.Entities
{
    public class Student
    {
        public Student(string uniqueId, string name)
        {
            this.UniqueId = uniqueId;
            this.Name = name;

        }
        public string UniqueId { get; private set; }

        public string Name { get; set; }

        // public evaluate(float evaluations)
        // {
        //     this.evaluation = evaluation;
        // }

        public float  evaluation { get; set; }

        public Student() => UniqueId = Guid.NewGuid().ToString();

    }
}