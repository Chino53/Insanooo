using libreriaClases;

    namespace otraLibreria{
            class Principal{

                static void Main(){

                    Silla pepe = new Silla();

                    //usando atributos
                    pepe.color = "rojo";
                    pepe.material = "plastico";

                    //usando metodos

                    Console.WriteLine(pepe.crear());
                    pepe.mover("pepe");
                    Console.WriteLine(pepe.color);
                    Console.WriteLine(pepe.material);

                    Silla roberta = new Silla();

                    roberta.color = "verde";
                    roberta.material = "metal";

                    Console.WriteLine(roberta.crear());
                    roberta.mover("roberta");
                    Console.WriteLine(roberta.color);
                    Console.WriteLine(roberta.material);
        }
    }
}