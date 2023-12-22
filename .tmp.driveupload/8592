class DeEventos
{
    public static void ActualizarEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        if (NombreEvento.Count != 0)
        {
        Menu:
            Console.Clear();
            TextoGrande.ActualizarEvento();
            VerLista(NombreEvento, Fechas, Hora, Lugar);
            Console.Write("Ingrese el indice del evento que desea Actualizar: ");
            int Index = int.Parse(Console.ReadLine());
            if (Index <= NombreEvento.Count)
            {
                Console.Clear();
                TextoGrande.ActualizarEvento();
                Console.WriteLine("Nombre actual: " + NombreEvento[Index]);
                Console.Write("Nombre nuevo: ");
                NombreEvento[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarEvento();
                Console.WriteLine("Fecha actual: " + Fechas[Index]);
                Console.Write("Fecha nueva:");
                Fechas[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarEvento();
                Console.WriteLine("Hora actual: " + Hora[Index]);
                Console.Write("Hora nueva:");
                Hora[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarEvento();
                Console.WriteLine("Lugar actual: " + Lugar[Index]);
                Console.Write("Lugar nuevo:");
                Lugar[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarEvento();
                la.Animacion(2);
                TextoGrande.ActualizarEvento();
                DeEventos.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, Index);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un numero valido.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                goto Menu;
            }
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
        Menu:
            Console.Clear();
            TextoGrande.BorrarEvento();
            VerLista(NombreEvento, Fechas, Hora, Lugar);
            Console.Write("Ingrese el indice del evento que desea borrar: ");
            int Index = int.Parse(Console.ReadLine());
            if (Index <= NombreEvento.Count)
            {
                NombreEvento.Remove((NombreEvento[Index]));
                Fechas.Remove((Fechas[Index]));
                Hora.Remove((Hora[Index]));
                Lugar.Remove((Lugar[Index]));
                Console.Clear();
                la.Animacion(8);
                TextoGrande.BorrarEvento();
                Console.WriteLine("Evento actualizados.");
                VerLista(NombreEvento, Fechas, Hora, Lugar);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un numero valido.");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
                goto Menu;
            }
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
            TextoGrande.BuscarEvento();
            TextoPequeño.EjemploEvento();
            string Buscar = Console.ReadLine();
            la.Animacion(4);
            la.Animacion(4);
            int N = 0;
            for (int i = 0; i < NombreEvento.Count; i++)
            {
                if (NombreEvento[i] == Buscar || Fechas[i] == Buscar || Hora[i] == Buscar || Lugar[i] == Buscar)
                {
                    DeEventos.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, i);
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
            TextoGrande.BuscarEvento();
            Console.WriteLine("Lista vacia.");
        }
        Console.ReadKey();
    }
    public static void AñadirEvento(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        Console.Clear();
        TextoGrande.AgregarEvento();
        TextoPequeño.Insercion();
        Console.Write("Nombre: ");
        NombreEvento.Add(Console.ReadLine());
        Console.Write("Fecha: ");
        Fechas.Add(Console.ReadLine());
        Console.Write("Hora: ");
        Hora.Add(Console.ReadLine());
        Console.Write("Lugar: ");
        Lugar.Add(Console.ReadLine());
        la.Animacion(3);
        TextoGrande.AgregarEvento();
        Console.WriteLine("Evento añadido correctamente.");
        Console.ReadKey();
    }
    public static void VerLista(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        {
            for (int i = 0; i < NombreEvento.Count; i++)
            {
                DeEventos.ImprimirInfo(NombreEvento, Fechas, Hora, Lugar, i);
            }
        }
    }
    public static void EJVerLista(List<string> NombreEvento, List<string> Fechas, List<string> Hora, List<string> Lugar)
    {
        Console.Clear();
        TextoGrande.ListaEventos();
        la.Animacion(5);
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