/*!
//!Extra de mi programa.
------------------------------------------
Convertor de Numeros enteros a Binarios
Convertor de Binarios  a Numeros enteros
Convertor de Numeros enteros a Hexadecimal
------------------------------------------
Adivina el numero * Juego
------------------------------------------
Animaciones
------------------------------------------
Uso de archivo de texto para (Historial)
------------------------------------------
!*/ 
class ProgramPrincipalDeAxel
{
    public static void Main()
    {
        bool Inicio = true;
        int Opcion;
        while (Inicio == true)
        {
            try
            {
                MenuPrincipal:
                Console.Clear();
                TextoGrande.Nombre();
                TextoPequeño.EligeOpcion();
                Menu.Inicio();
                Opcion = int.Parse(Console.ReadLine());
                switch (Opcion) //Primero.
                {
                    //Agenda electromica
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Clear();
                        TextoGrande.AgendaElectronica();
                        TextoPequeño.EligeOpcion();
                        Menu.Agenda();
                        Opcion = int.Parse(Console.ReadLine());
                        if (Opcion == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            goto MenuPrincipal;
                        }
                        switch (Opcion)
                        {
                            case 1:
                                Parte.Contactos();
                                break;
                            case 2:
                                La.Agenda();
                                break;
                            default:
                                break;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    //Conversor
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Clear();
                        //MenuConversor:
                        TextoGrande.Conversor();
                        TextoPequeño.EligeOpcion();
                        Menu.Conversor();
                        Opcion = int.Parse(Console.ReadLine());
                        if (Opcion == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            goto MenuPrincipal;
                        }
                        switch (Opcion)
                        {
                            case 1:
                                //Temperatura //!Terminado.
                                Console.Clear();
                                //El.Grado(Opcion);
                                break;
                            case 2:
                                //Binarios y otros  //!Terminado.       Extra!!
                                Console.Clear();
                                BinariosYotros.EXTRA();
                                break;
                            case 3:
                                //Divisas   //!Sin diseño.
                                Console.Clear();
                                Las.Divisas();
                                Console.ReadKey();
                                break;
                            case 4:
                                //Tiempo //!Extra!!
                                Console.Clear();
                                break;
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    //Calculadora //!Terminado.
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Blue;
                    MenuCalcularora:
                        Console.Clear();
                        TextoGrande.Calculadora();
                        TextoPequeño.EligeOpcion();
                        Menu.Calculadora();
                        Opcion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Opcion == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            goto MenuPrincipal;
                        }
                        Desicion.SRMD(Opcion);
                        Pedir.Numeros(Opcion);
                        Console.ForegroundColor = ConsoleColor.White;
                        goto MenuCalcularora;
                    case 4:
                        //!Juego Extra.
                        Un.Juego();
                        break;
                    //Salir
                    case 0:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        TextoGrande.creador();
                        Inicio = false;
                        break;
                }
            }
            catch (Exception Error)
            {
                Console.Clear();
                Console.WriteLine(Error.Message);
                Thread.Sleep(800);
                Console.WriteLine("Precione una tecla para continuar");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
