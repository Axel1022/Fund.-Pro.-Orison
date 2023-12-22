//Cronometro
/*//!    Inicio del Cronometro.
            //Console.ReadKey();
            bool ciclo=true;
            Console.Write($"Ingrese los minutos");
            int Dato = int.Parse(Console.ReadLine());
            int Segundos = 0, Minutos = 0;

            do
            {
                Segundos++;
                if (Segundos == 60)
                {
                    Minutos++;
                    Segundos = 0;
                }
                if (Minutos == Dato)
                {
                    ciclo = false;
                }

                Console.Clear();
                Console.WriteLine(Minutos + ":" + Segundos);
                Thread.Sleep(899);

            } while (ciclo == true);//!    Fin del Cronometro.*/

//Cronometro Para la competencia
/*bool ciclo = true;
Console.Write("Ingrese los minutos: ");
int Dato = int.Parse(Console.ReadLine());
int Segundos = 0, Minutos = 0;
do
{
    switch (Dato)
    {
        case 0:
            Console.WriteLine($"Por favor, ingrese una cantidad de minutos mas elavada.");
            Console.Write("Ingrese los minutos: ");
            Dato = int.Parse(Console.ReadLine());
            break;
        default:
            {


                    Console.WriteLine("¿Estan listos para iniciar?");
                    string Respuesta = Console.ReadLine();
                    bool Preparado = true;
                    if (Respuesta == "SI" || Respuesta == "si" || Respuesta == "Si" || Respuesta == "sI")
                    {

                        while (Preparado == true)
                        {
                                Segundos++;
                            if (Segundos == 60)
                            {
                                {
                                    Minutos++;
                                    Segundos = 0;
                                }
                                if (Minutos == Dato)
                                {
                                    ciclo = false;
                                    Preparado= false;
                                }


                            }
                            Console.Clear();
                            Console.WriteLine(Minutos + ":" + Segundos);
                            Thread.Sleep(899);

                    }
                    }



            }
            break;
    }
} while (ciclo == true);*/

//Cronometro
//!    Inicio del Cronometro.
//Console.ReadKey();
bool ciclo = true;
Console.Write($"Ingrese los minutos");
int Dato = int.Parse(Console.ReadLine());
int Segundos = 0, Minutos = 0;

do
{
    Segundos++;
    if (Segundos == 60)
    {
        Minutos++;
        Segundos = 0;
    }
    if (Minutos == Dato)
    {
        ciclo = false;
    }

    Console.Clear();
    Console.WriteLine(Minutos + ":" + Segundos);
    Thread.Sleep(1000);

} while (ciclo == true);//!    Fin del Cronometro.*/


