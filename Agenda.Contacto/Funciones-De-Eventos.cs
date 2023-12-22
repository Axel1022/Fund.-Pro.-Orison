class Funcion
{
    public static void ActualizarEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        if (NombreEvento.Count != 0)
        {
            Console.Clear();
            VerLista(NombreEvento, Fechas, Hora, Lugar);
            Console.Write("Ingrese el indice del evento que desea Actualizar: ");
            int Index = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Nombre actual: " + NombreEvento[Index]);
            Console.Write("Nombre nuevo: ");
            NombreEvento[Index] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Fecha actual: " + Fechas[Index]);
            Console.Write("Fecha nueva:");
            Fechas[Index] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hora actual: " + Hora[Index]);
            Console.Write("Hora nueva:");
            Hora[Index] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Lugar actual: " + Lugar[Index]);
            Console.Write("Lugar nuevo:");
            Lugar[Index] = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Evento actualizado");
            Funcion.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, Index);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lista vacia.");
        }
        Console.ReadKey();
    }
    public static void BorrarEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        if (NombreEvento.Count != 0)             //!Revisar
        {
            Console.Clear();
            VerLista(NombreEvento, Fechas, Hora, Lugar);
            Console.Write("Ingrese el indice del evento que desea borrar: ");
            int Index = int.Parse(Console.ReadLine());
            NombreEvento.Remove((NombreEvento[Index]));
            Fechas.Remove((Fechas[Index]));
            Hora.Remove((Hora[Index]));
            Lugar.Remove((Lugar[Index]));
            Console.Clear();
            Console.WriteLine("Evento borrado correctamente.");
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine("Evento actualizados.");
            VerLista(NombreEvento, Fechas, Hora, Lugar);
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lista vacia.");
        }
        Console.ReadKey();
    }
    public static void ImprimirInfo(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar, int M)
    {
        Console.WriteLine("--------------------" + M + "--------------------");
        Console.WriteLine("Nombre: " + NombreEvento[M]);
        Console.WriteLine("Fecha: " + Fechas[M]);
        Console.WriteLine("Hora: " + Hora[M]);
        Console.WriteLine("Lugar: " + Lugar[M]);
        Console.WriteLine("-----------------------------------------");
    }
    public static void BuscarEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        if (NombreEvento.Count != 0)
        {
            Console.Clear();
            Console.Write("Buscar evento: ");
            Console.WriteLine("Ej: Reuinon Con axel; 25/12/2022... ");
            string Buscar = Console.ReadLine();
            int N = 0;
            for (int i = 0; i < NombreEvento.Count; i++)
            {
                if (NombreEvento[i] == Buscar || Fechas[i] == Buscar || Hora[i] == Buscar || Lugar[i] == Buscar)
                {
                    Funcion.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, i);
                    N = 1;
                }
            }
            if (N == 0)
            {
                Console.WriteLine("Evento no encontrado");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lista vacia.");
        }
        Console.ReadKey();
    }
    public static void AñadirEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        Console.Clear();
        Console.Write("Nombre: ");
        NombreEvento.Add(Console.ReadLine());
        Console.Write("Fecha: ");
        Fechas.Add(Console.ReadLine());
        Console.Write("Hora: ");
        Hora.Add(Console.ReadLine());
        Console.Write("Lugar: ");
        Lugar.Add(Console.ReadLine());
        Console.WriteLine("Evento añadido.");
        Console.ReadKey();
    }
    public static void VerLista(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        {
            for (int i = 0; i < NombreEvento.Count; i++)
            {
                Funcion.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, i);
            }
        }
    }
    public static void EJVerLista(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        Console.Clear();
        if (NombreEvento.Count == 0)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            VerLista(NombreEvento, Fechas, Hora, Lugar);
        }
        Console.ReadKey();
    }
}