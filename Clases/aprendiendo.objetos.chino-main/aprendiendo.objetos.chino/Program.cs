using System;

namespace libreriaClases {
    class Silla{

        //atributos
        public string color;
        
        public string material;

        //metodos
        public string crear(){

            return "Hola";

        }
        
        public void mover(string pNombre){
            Console.WriteLine("Se mueve a la derecha {0}", pNombre);
        }

    }
}