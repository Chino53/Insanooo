using System;
using libreriaClases;
namespace libreria{
    class Principal{
        static void Main(){

            // Con referencias :v
            Persona p1 = new Persona("Juan", "1/1/1", 42435093);

            p1.mostrarPersona();
            Console.WriteLine(p1.caminar());
            //
            // Sin referencias :v
            Persona p2 = new Persona(); 
            p2.Nombre = "Diego";
            p2.FechaNacimiento = "19/2/2005";
            p2.Dni = 44932842;
            p2.mostrarPersona();
            Console.WriteLine(p2.caminar());
            //
            // Herencia insana
            Alumno a1 = new Alumno();

            a1.Dni = 42102032;
            a1.Nombre = "Pedro";
            a1.mostrarPersona(); 

        }
    }

}