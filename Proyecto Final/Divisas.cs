
class Las
{
    public static void Divisas()
    {
        bool ParaWhile = true;
        while (ParaWhile == true)
        {
            Console.Clear();
            TextoGrande.Divisas();
            TextoPequeño.EligeOpcion();
            Menu.Divisas();
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:
                    Console.Clear();
                    ParaWhile = false;
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
                    Historial.LeerHistorial(2);
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(Opcion + " no es una opcion.d");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
