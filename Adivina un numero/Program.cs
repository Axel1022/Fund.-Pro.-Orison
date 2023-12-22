
public class Program
{
    private static void Main()
    {
        bool CicloJuego = true;
        Random NRa = new Random();
        int Azar = NRa.Next(0, 100);
        int Contador = 10;
        int Numero = 0;
        while (CicloJuego == true)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"---Intentos restantes: {Contador}.---");
                Contador--;
                Console.Write("Ingrese un numero:");
                try
                {
                    Numero = int.Parse(Console.ReadLine());
                }
                catch (Exception Error)
                {
                    Console.WriteLine("Ha ocurrido un error: "+Error.Message);
                    Thread.Sleep(1000);
                    Console.WriteLine("Tomare el 0 como numero introduccido.");
                    Numero = 0;
                    Thread.Sleep(2000);

                }

                Console.Clear();
                if (Numero == Azar)
                {
                    Console.Clear();
                    Console.WriteLine($"El numero es {Numero}");
                    Console.WriteLine($"Adivinaste en el intento {i} !Felicidades¡");
                    Console.WriteLine($"-------------Hecho por Axel-------------");
                    i = 11;
                    CicloJuego = false;
                }
                else if (Numero < Azar)
                {
                    Console.WriteLine("Numero muy pequeño");
                }
                else if (Numero > Azar)
                {
                    Console.WriteLine("Numero muy grande");
                }
                if (i == 10 && Numero != Azar)
                {
                    Console.Clear();
                    Console.WriteLine($"Se agotaron los intentos, el numero era {Azar}");
                    CicloJuego = false;
                    Console.WriteLine( $"-------------Hecho por Axel-------------");
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
