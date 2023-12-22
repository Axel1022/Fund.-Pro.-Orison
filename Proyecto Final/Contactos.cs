
class Parte
{
    public static void Contactos()
    {
        Console.Clear();
        List<string> Nombres = new List<string>();
        List<string> Apellidos = new List<string>();
        List<string> Correos = new List<string>();
        List<string> Telefonos = new List<string>();
        List<string> Direcciones = new List<string>();
        bool ParaWhile = true;
        while (ParaWhile == true)
        {
        Menu:
            Console.Clear();
            TextoGrande.Contactos();
            TextoPequeño.EligeOpcion();
            Menu.ContactosyEventos();
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:
                    ParaWhile = false;
                    break;
                case 1:
                    Funcion.EJVerLista(Nombres, Apellidos, Correos, Telefonos, Direcciones);
                    break;
                case 2:
                    Funcion.AñadirContacto(Nombres, Apellidos, Correos, Telefonos, Direcciones);
                    break;
                case 3:
                    Funcion.BorrarContacto(Nombres, Apellidos, Correos, Telefonos, Direcciones);
                    goto Menu;
                case 4:
                    Funcion.ActualizarContacto(Nombres, Apellidos, Correos, Telefonos, Direcciones);
                    break;
                case 5:
                    Funcion.BuscarContacto(Nombres, Apellidos, Correos, Telefonos, Direcciones);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine(Opcion + " no es una opcion valida.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}









