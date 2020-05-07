using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Serialization;



namespace Serialization
{
    [Serializable]
    public class Person
    {
        string name;
        string lastname;
        int age;

        public Person(string Name, string LastName, int Age)
        {
            this.name = Name;
            this.lastname = LastName;
            this.age = Age;
        }
        public string Info()
        {
            return "Nombre: " + name + " Apellido: " + lastname + " Edad: " + age;
        }
    }
}
