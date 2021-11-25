using System;

namespace CoreSchool.Entities
{
    public abstract class ObjectSchoolBase
    {
        public string UniqueId { get; private  set;}
        public string Name { get; set; }

        public ObjectSchoolBase()
        {
            // Guid = Globally Unique Identifier, la funcion NEWID(), genera un unico valor cada vez que se genera
            UniqueId = Guid.NewGuid().ToString();
        }
        public override string ToString()
        {
            return $"{Name}, {UniqueId}";
        }
    }
}

//clase abstracta, hereda de un objeto, pero espera que cada uno donde se hereda cree su propia funcionalidad, tampoco puede ser instanciada

//sealed (cellada) permite que no se pueda heredar de esta clase, no se puede crear una clase hija de esta, pero si se crea instancias