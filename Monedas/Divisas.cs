
class Divisas
{
    public static void Main()
    {
        bool ParaWhile =true;
        while (ParaWhile==true)
        {
            Console.Clear();
            Console.WriteLine(@"¿Que quieres hacer?
            (1) De Pesos Dominicanos a Dolares y Euros
            (2) De Euros a Dolares y Pesos Dominicanos
            (3) De Dolares a Pesos Dominicanos y Euros
            (4) Historial
            (0) Atras");
            int Opcion= int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:
                Console.Clear();
                ParaWhile=false;
                break;
                case 1:
                Console.Clear();
                Monedas.Domi();
                Console.ReadKey();
                break;
                case 2:
                Console.Clear();
                Monedas.Espa();
                Console.ReadKey();
                break;
                case 3:
                Console.Clear();
                Monedas.Esta();
                Console.ReadKey();
                break;
                case 4:
                Console.Clear();
                Historial.LeerHistorial();
                Console.ReadKey();
                break;
                default:
                Console.Clear();
                Console.WriteLine(Opcion+ " no es una opcion.d");
                Console.ReadKey();
                break;
            }
        }
    }
}
