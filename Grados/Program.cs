class El
{
    public static void Grado()
    {
        bool X=true;
        while (X==true)
        {Console.Clear();
            Console.WriteLine("---------------------------Calculadora de temperaturas---------------------------");
            Console.WriteLine(@"Elije la opcion que quieres realizar
            (1) FAHRENHEIT a CELSIUS y KELVIN
            (2) CELSIUS a FAHRENHEIT y KELVIN
            (3) KELVIN a FAHRENHEIT y CELSIUS
            (0) Salir?");
            int Opcion= int.Parse(Console.ReadLine());
            Console.Clear();
            switch (Opcion)
            {
                case 0:
                X=false;
                break;
                case 1:
                FUNCIONES.FAHRENHEIT();
                Console.ReadKey();
                break;
                case 2:
                FUNCIONES.CELSIUS();
                Console.ReadKey();
                break;
                case 3:
                FUNCIONES.KELVIN();
                Console.ReadKey();
                break;
                default:
                Console.WriteLine("Opcion no valida.");
                Console.ReadKey();
                break;
            }
        }
    }
}
