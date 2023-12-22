/*NOMBRE DEL EVENTO, FECHA, HORA, LUGAR*/
class Agenda
{
    private static void Main()
    {
        Console.Clear();
        List<string> NombreEvento = new List<string>();
        List<string> Fechas = new List<string>();
        List<string> Hora = new List<string>();
        List<string> Lugar = new List<string>();
        {
        MenuPrincipal:
            Console.Clear();
            Console.WriteLine(@"¿Que quieres hacer?
            (1) Ver lista.
            (2) Añadir evento.
            (3) Borrar evento.
            (4) Actualizar evento.
            (5) Buscar evento.
            (0) Salir");
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    Funcion.EJVerLista(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 2:
                    Funcion.AñadirEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 3:
                    Funcion.BorrarEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 4:
                    Funcion.ActualizarEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 5:
                    Funcion.BuscarEvento(NombreEvento, Fechas, Hora, Lugar);
                    Console.ReadLine();
                    goto MenuPrincipal;
                default:
                    Console.Clear();
                    Console.WriteLine(Opcion + " no es una opcion valida.");
                    goto MenuPrincipal;
            }
        }
    }
}