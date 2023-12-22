class Funcion
{
    public static void ActualizarContacto(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        if (Nombres.Count != 0)
        {
        Menu:
            int Index = 0;
            Console.Clear();
            TextoGrande.ActualizarContactos();
            VerLista(Nombres, Apellidos, Correos, Telefonos, Direcciones);
            TextoPequeño.UnDato(2);
            Index = int.Parse(Console.ReadLine());
            if (Index <= Nombres.Count)
            {
                Console.Clear();
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Nombre actual: " + Nombres[Index]);
                Console.Write("Nombre nuevo: ");
                Nombres[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Apellido actual: " + Apellidos[Index]);
                Console.Write("Apellido nuevo:");
                Apellidos[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Correos actual: " + Correos[Index]);
                Console.Write("Correo nuevo:");
                Correos[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Telefonos actual: " + Telefonos[Index]);
                Console.Write("Telefono nuevo:");
                Telefonos[Index] = Console.ReadLine();
                Console.Clear();
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Direccion actual: " + Direcciones[Index]);
                Console.Write("Direcciones nuevo:");
                Direcciones[Index] = Console.ReadLine();
                Console.Clear();
                la.Animacion(2);
                TextoGrande.ActualizarContactos();
                Console.WriteLine("Contacto actualizado");
                Funcion.ImprimirInfo(Nombres, Apellidos, Correos, Telefonos, Direcciones, Index);
                Console.ReadKey();
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
            TextoGrande.ActualizarContactos();
            Console.Clear();
            Console.WriteLine("Lista vacia.");
            Console.ReadKey();
        }
    }
    public static void BorrarContacto(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        if (Nombres.Count != 0)             //!Revisar
        {
        Menu:
            Console.Clear();
            TextoGrande.BorrarContato();
            TextoPequeño.ListaOfContactos();
            VerLista(Nombres, Apellidos, Correos, Telefonos, Direcciones);
            TextoPequeño.UnDato(3);
            int Index = int.Parse(Console.ReadLine());
            if (Index <= Nombres.Count)
            {
                Nombres.Remove((Nombres[Index]));
                Apellidos.Remove((Apellidos[Index]));
                Correos.Remove((Correos[Index]));
                Telefonos.Remove((Telefonos[Index]));
                Direcciones.Remove((Direcciones[Index]));
                Console.Clear();
                la.Animacion(8);
                TextoGrande.BorrarContato();
                Console.WriteLine("Contacto borrado correctamente.");
                Thread.Sleep(2000);
                Console.Clear();
                TextoGrande.BorrarContato();
                //TextoPequeño.ListaOfContactos();
                VerLista(Nombres, Apellidos, Correos, Telefonos, Direcciones);
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
    public static void ImprimirInfo(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones, int M)
    {
        Console.WriteLine("--------------------" + M + "--------------------");
        Console.WriteLine("Nombre: " + Nombres[M]);
        Console.WriteLine("Apellido: " + Apellidos[M]);
        Console.WriteLine("Correo: " + Correos[M]);
        Console.WriteLine("Telefono: " + Telefonos[M]);
        Console.WriteLine("Direccion: " + Direcciones[M]);
        Console.WriteLine("-----------------------------------------");
    }
    public static void BuscarContacto(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        if (Nombres.Count != 0)
        {
            Console.Clear();
            TextoGrande.BuscarContato();
            TextoPequeño.UnDato(1);
            TextoPequeño.Ejemplo();
            string Buscar = Console.ReadLine();
            la.Animacion(4);
            TextoGrande.BuscarContato();
            int N = 0;
            for (int i = 0; i < Nombres.Count; i++)
            {
                if (Nombres[i] == Buscar || Apellidos[i] == Buscar || Correos[i] == Buscar || Telefonos[i] == Buscar || Direcciones[i] == Buscar)
                {
                    Funcion.ImprimirInfo(Nombres, Apellidos, Correos, Telefonos, Direcciones, i);
                    N = 1;
                }
            }
            if (N == 0)
            {
                Console.WriteLine("Contacto no encontrado");
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Lista vacia.");
        }
        Console.ReadKey();
    }
    public static void AñadirContacto(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        Console.Clear();
        TextoGrande.AgregarContato();
        TextoPequeño.Insercion();
        Console.Write("Nombre: ");
        Nombres.Add(Console.ReadLine());
        Console.Write("Apellido: ");
        Apellidos.Add(Console.ReadLine());
        Console.Write("Correo: ");
        Correos.Add(Console.ReadLine());
        Console.Write("Telefono: ");
        Telefonos.Add(Console.ReadLine());
        Console.Write("Direccion: ");
        Direcciones.Add(Console.ReadLine());
        la.Animacion(3);
        TextoGrande.AgregarContato();
        Console.Clear();
    }
    public static void VerLista(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        {
            for (int i = 0; i < Nombres.Count; i++)
            {
                Funcion.ImprimirInfo(Nombres, Apellidos, Correos, Telefonos, Direcciones, i);
            }
        }
    }
    public static void EJVerLista(List<string> Nombres, List<string> Apellidos, List<string> Correos, List<string> Telefonos, List<string> Direcciones)
    {
        Console.Clear();
        if (Nombres.Count == 0)
        {
            Console.WriteLine("Lista vacia");
        }
        else
        {
            la.Animacion(5);
            TextoGrande.ListaContactos();
            VerLista(Nombres, Apellidos, Correos, Telefonos, Direcciones);
        }
        Console.ReadKey();
    }
}
