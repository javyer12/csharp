using System.Collections.Generic;

namespace CoreSchool.Entities
{
        class School 
        {
                //encapsulamiento: ponerle logica a los elementos para que en el futuro no se tenga que modificar en cada espacio que viva el codigo
                string name;

                 //esta es la propiedad de encapsulamiento
                 public string Name
                {
                        get { return "Copy: " +  name; }
                        set { name = value.ToUpper(); }
                }

                public int YearCreated { get;set; }

                public string Country { get; set; }
                public string City { get; set; }

                private int myVar;

                public  TypeSchools TypeSchools {get;set;}

                public List<Course> Courses { get; set; }

                public string env = System.Environment.NewLine;
// igualacion por tupla, para construir el metodo (entre parentesis)
                public School(string name, int year) => (Name, YearCreated) = (name, year);

                public School(string name, 
                int year, 
                TypeSchools type, 
                string country = " ",
                 string city = " ")
                {
                        (Name, YearCreated) = (name, year);
                        Country = country;
                        City = city;
                }
// override me sirve para sobre escribir
                public override string ToString() 
                {
                        return $"Name: \"{Name}\", {env} Type: {TypeSchools},{env} Country: {Country}, {env} City: {City} ";
                }
        }
}