
public class Un
{
    public static void Juego()
    {
    Menu:
        int Opcion;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Clear();
        TextoGrande.Adivina();
        TextoPequeño.EligeOpcion();
        Menu.Juego();
        Opcion = int.Parse(Console.ReadLine());
        if (Opcion != 0)
        {
            Console.Clear();
            TextoGrande.Adivina();
            bool CicloJuego = true;
            Random NRa = new Random();
            int Azar = NRa.Next(0, 100);
            int Contador = 10;
            while (CicloJuego == true)
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.Clear();
                    TextoGrande.Adivina();
                    Console.WriteLine($"---Intentos restantes: {Contador}.---");
                    Contador--;
                    Console.Write("Ingrese un numero:");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (Numero == Azar)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        TextoGrande.Adivina();
                        Console.WriteLine($"El numero es {Numero}");
                        Console.WriteLine($"Adivinaste en el intento {i} !Felicidades¡");
                        TextoGrande.creador();
                        i = 11;
                        CicloJuego = false;
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        goto Menu;
                    }
                    else if (Numero < Azar)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        TextoGrande.Adivina();
                        Console.WriteLine("Numero muy pequeño");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else if (Numero > Azar)
                    {
                        TextoGrande.Adivina();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Numero muy grande");
                        Thread.Sleep(1000);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    if (i == 10 && Numero != Azar)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        TextoGrande.Adivina();
                        Console.WriteLine($"Se agotaron los intentos, el numero era {Azar}");
                        TextoGrande.creador();
                        CicloJuego = false;
                        Console.ReadKey();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Clear();
                        goto Menu;
                    }
                }
            }
        }
        else
        {
            Console.Clear();
            TextoGrande.creador();
            Thread.Sleep(3000);
            la.Animacion(1);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}