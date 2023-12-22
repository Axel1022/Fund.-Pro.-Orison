/*NOMBRE DEL EVENTO, FECHA, HORA, LUGAR*/
class La
{
    public static void Agenda()
    {
        Console.Clear();
        List<string> NombreEvento = new List<string>();
        List<string> Fechas = new List<string>();
        List<string> Hora = new List<string>();
        List<string> Lugar = new List<string>();
        {
        MenuPrincipal:
            Console.Clear();
            TextoGrande.Eventos();
            TextoPequeño.EligeOpcion();
            Menu.ContactosyEventos();
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    DeEventos.EJVerLista(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 2:
                    DeEventos.AñadirEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 3:
                    DeEventos.BorrarEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 4:
                    DeEventos.ActualizarEvento(NombreEvento, Fechas, Hora, Lugar);
                    goto MenuPrincipal;
                case 5:
                    DeEventos.BuscarEvento(NombreEvento, Fechas, Hora, Lugar);
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