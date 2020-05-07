using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Serialization
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string respuesta;
            string nombre;
            string apellido;
            int edad;
            //List<Person> myList = new List<Person>();
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1) Crear y serializar persona");
            Console.WriteLine("2) Leer Persona");
            respuesta= Console.ReadLine();
            if (respuesta=="1")
            {

                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido");
                apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad");
                edad = Convert.ToInt32(Console.ReadLine());
                Person persona1 = new Person(nombre, apellido, edad);
                //myList.Add(persona1);

                BinaryFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("Personas.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                //formatter.Serialize(stream, myList);
                formatter.Serialize(stream, persona1);
                stream.Close();
            }
            if (respuesta=="2")
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Stream myStream = new FileStream("Personas.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                Person persona1 = (Person)formatter.Deserialize(myStream);
                //List<Person> Lista = (List<Person>)formatter.Deserialize(myStream);
                myStream.Close();
                Console.WriteLine(persona1.Info());
                //foreach(Person a in Lista)
                //{
                    //Console.WriteLine(Lista.Info());
                //}

            }
        }
    }
}
