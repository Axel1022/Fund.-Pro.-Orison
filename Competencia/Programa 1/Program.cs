﻿
using System;
{
    {
        //*Elegir dos estidiantes totalmente ramdom.
        string[] NombresArrays;	//*Declarando el arreglo.
        NombresArrays = new string[21];	//*Espacio que tiene el array.
        bool cicloHace = true;
        bool cicloManda = true;
        bool ciclopadre = true;
        int Entrada = 0;
        string desicion = "";
        int PH = 0, PM = 0, M = 0, H = 0, PosicionArray = 1;
        //*string ConteoDesicion;
        int[] arrayManda = new int[21];
        int[] arrayHace = new int[21];
        Random Primero = new Random();	//*Numero ramdom.
        Random Segundo = new Random();	//*Numero ramdom.
        int Hace = 0, Manda = 0;
        //*Estudiantes con un espacio asignado (numero) dentro del array
        NombresArrays[0] = "Joshua H";
        NombresArrays[1] = "Van troid";
        NombresArrays[2] = "Rainy Diaz";
        NombresArrays[3] = "Federico Garcia";
        NombresArrays[4] = "Starling Jacobo";
        NombresArrays[5] = "Wandry Martinez";
        NombresArrays[6] = "Osiris Moreta";
        NombresArrays[7] = "Luis Mendez";
        NombresArrays[8] = "Alexander Campusano";
        NombresArrays[9] = "Jose H";
        //*Variable boleana para el ciclo ehile.
        bool FinWhile = true;
        //*Console.Clear();
        while (Entrada == 0) //!Desde aqui
        {
            Console.WriteLine(@"

# ______._............_................__....._.......... .........._................................................. .........................._.......
# |.___.(_)..........|.|..............(_)...|.|...... ............|.|................................... ......................|.|......
# |.|_/./_..___._.__.|.|__...___._.__.._..__|.|.___..____.....__. _|.|..._.__.._.__.___...__._._.__.__._._.__.___...__.__...__| .|.___..
# |.___.\.|/._.\.'_.\|.'_.\./._.\.'_.\|.|/._`.|/._.\/ .__|.../._`.|.|..|.'_.\|.'__/._.\./._`.|.'__/._`.|.'_ .`._.\./._`.|.../._`.|/._.\.
# |.|_/./.|..__/.|.|.|.|_).|..__/.|.|.|.|.(_|.|.(_).\ __.\..|.(_|.|.|..|.|_).|.|.|.(_).|.(_|.|.|.|.(_|.|. |.|.|.|.|.(_|.|..|.(_|.|..__/.
# \____/|_|\___|_|.|_|_.__/.\___|_|.|_|_|\__,_|\___/|___/...\__,_ |_|..|..__/|_|..\___/.\__,.|_|..\__,_|_|.|_|.|_|\__,_|.. .\__,_|\___|.
# .................................................. ...................|.|...............__/.|......... ................................
# .................................................. ...................|_|.............|___/........... ...............................
# ..........................................._................. ..........................._................._... ..................................
# ..................................|.|............. ..........................|.|................(_).. ..................................
# ..................................|.|.__._.....___.___. ._.__.___.._.__...___|.|_.___._.__...___._..__._............. ................
# ..................................|.|/._`.|.../.__/ ._.\|.'_.`._.\|.'_.\./._.\.__/._.\.'_.\./.__|.|/._`. |.................................
# ..................................|.|.(_|.|..|.(_| .(_).|.|.|.|.|.|.|_).|..__/.||..__/.|.|.|.(__|.|.(_|. |.................................
# ..................................|_|\__,_|...\___\___/ |_|.|_|.|_|..__/.\___|\__\___|_|.|_|\___|_|\__,_|.......... ...................
# .................................................. ...............|.|................................ ..................................
# .................................................. ...............|_|................................ ..................................
");
            Thread.Sleep(3000);
            Console.WriteLine(@"

# ._____...._.......................................... .........................._.__._............_.......... ............._................._._............._...... .......
# |..___|..|.|....................................... .......................|.(_|_)..........|.|....... ..............|.|...........|.(_)...........|.|... .........
# |.|__.___|.|_.___..._.__.._.__.___...__._._.__.__._._.__.___...__ ._....___|.|_._..___....__|.|.___..___....___..___|.|_._..._..__ |.|_..__._._.__.|.|_.___..___..
# |..__/.__|.__/._.\.|.'_.\|.'__/._.\./._`.|.'__/._`.|.' _.`._.\./._`.|../._.\.|.|.|/._.\../._`.|/._.\/.__|. ./._.\/.__|.__|.|.|.|/._`.|.|/._`.|.'_.\|.__/._.\/.__| .
# |.|__\__.\.||..__/.|.|_).|.|.|.(_).|.(_|.|.|.|.(_|.| .|.|.|.|.|.(_|.|.|..__/.|.|.|..__/.|.(_|.|.(_).\__.\. |..__/\__.\.|_|.|_|.|.(_|.|.|.(_|.|.|.|.|.||..__/\__.\ .
# \____/___/\__\___|.|..__/|_|..\___/.\__,.|_|..\__,_|_|.|_|.|_| \__,_|..\___|_|_|.|\___|..\__,_|\___/|___/..\___||___/\__|\__,_|\__ ,_|_|\__,_|_|.|_|\__\___||___/.
# ...................|.|...............__/.|........ .................................._/.|................... .................................................... ..........
# ...................|_|.............|___/.......... .........................|__/...................... .................................................... ........
# .__.....______................................................. _.................................................. .................................................... .....
# /..|....|.___.\.................................... ...|.|............................................ .................................................... .........
# `|.|....|.|_/./__.._.__...___..._..._._.__...._.__.___|.| _.___................................................... .................................................... .
# .|.|....|..__/._.\|.'_.\./._.\.|.|.|.|.'_.\..|.'__/ ._.\.__/._.\........................................... .................................................... ........
# _|.|__..|.|.|.(_).|.|.|.|..__/.|.|_|.|.|.|.|.|.|.|. .__/.||.(_).|...................................... .................................................... ........
# \___(_).\_|..\___/|_|.|_|\___|..\__,_|_|.|_|.|_|..\___|\__\ ___(_).................................................. ..........................................................
# .................................................. .................................................... .................................................... ...........
# .................................................. .................................................... .................................................... ...........
# ._____.....__..._......................._............_ .................................................... .................................................... .......
# /.__..\...|.|.|.|.....................|.|......... .|.|.................................................. .................................................... ..........
# `'././'...|.|_|.|.__._..___.___....___|.|.._.__.___|.|_.___.. .................................................... ..........................................................
# .././.....|.._..|/._`.|/.__/._.\../._.\.|.|.'__/._. \.__/._.\.......................................... .................................................... ........
# ././____..|.|.|.|.(_|.|.(_|..__/.|..__/.|.|.|.|..__/.|| .(_).|................................................ .................................................... .....
# \_____(_).\_|.|_/\__,_|\___\___|..\___|_|.|_|..\___|\__\___(_)... .................................................... .............................................
# .................................................. .................................................... .................................................... ...........
# .................................................. .................................................... .................................................... ...........
");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"

# .__.__...____..___.___...___..._____......____........___.._......_.. .....___..
# |..|..|./....||...|...|./...\./.___/...../....|.... ../.._]|.|....|.|...../...\.
# |..|..||..o..||._..._.||.....(...\_.....|..o..|.. .../..[_.|.|....|.|....|.....|
# |..|..||.....||..\_/..||..O..|\__..|....|.....|... .|...._]|.|___.|.|___.|..O..|
# |..:..||.._..||...|...||.....|/..\.|....|.._..|.. ..|...[_.|.....||.....||.....|
# .\.../.|..|..||...|...||.....|\....|....|..|..|.. ..|.....||.....||.....||.....|
# ..\_/..|__|__||___|___|.\___/..\___|....|__|__|....|_____||_____||_____|. \___/.
# .................................................. ...............................
");
            Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"

# .__.__...____..___.___...___..._____......____........___.._......_.. .....___..
# |..|..|./....||...|...|./...\./.___/...../....|.... ../.._]|.|....|.|...../...\.
# |..|..||..o..||._..._.||.....(...\_.....|..o..|.. .../..[_.|.|....|.|....|.....|
# |..|..||.....||..\_/..||..O..|\__..|....|.....|... .|...._]|.|___.|.|___.|..O..|
# |..:..||.._..||...|...||.....|/..\.|....|.._..|.. ..|...[_.|.....||.....||.....|
# .\.../.|..|..||...|...||.....|\....|....|..|..|.. ..|.....||.....||.....||.....|
# ..\_/..|__|__||___|___|.\___/..\___|....|__|__|....|_____||_____||_____|. \___/.
# .................................................. ...............................
");
            Thread.Sleep(500);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"
# .__.__...____..___.___...___..._____......____........___.._......_.. .....___..
# |..|..|./....||...|...|./...\./.___/...../....|.... ../.._]|.|....|.|...../...\.
# |..|..||..o..||._..._.||.....(...\_.....|..o..|.. .../..[_.|.|....|.|....|.....|
# |..|..||.....||..\_/..||..O..|\__..|....|.....|... .|...._]|.|___.|.|___.|..O..|
# |..:..||.._..||...|...||.....|/..\.|....|.._..|.. ..|...[_.|.....||.....||.....|
# .\.../.|..|..||...|...||.....|\....|....|..|..|.. ..|.....||.....||.....||.....|
# ..\_/..|__|__||___|___|.\___/..\___|....|__|__|....|_____||_____||_____|. \___/.
# .................................................. ...............................
");
            Thread.Sleep(1000);
            Entrada = 1;//!Hasta aqui!
            Console.Clear();
        }

        for (int i = 0; i < arrayManda.Length; i++)
        {
            arrayHace[i] = 0;
            arrayManda[i] = 0;
        }
        while (ciclopadre == true)
        {
            FinWhile = true;
            while (FinWhile == true)
            {
                while (cicloManda == true)
                {
                    Manda = Primero.Next(0, 10);
                    cicloManda = true;
                    for (M = 0; M < arrayManda.Length; M++)
                    {
                        while (Manda == arrayManda[M])
                        {
                            Manda = Primero.Next(0, 10);
                            M = 0;
                        }
                    }
                    cicloManda = false; //!Nuevo
                    /*if (repetidoM == 0)//!PENDIENTE!
                    {
                        arrayManda[PM] = Manda;
                        PM++;                       //!DEBO REORGANIZARLO
                        cicloManda = false;
                    }
                    else
                    {
                        cicloManda = true;
                    }//!HASTA AQUI*/
                }
                cicloHace = true;
                while (cicloHace == true)
                {
                    Hace = Segundo.Next(0, 10);
                    cicloHace = true;
                    for (H = 0; H < arrayHace.Length; H++)
                    {
                        while (Hace == arrayHace[H])
                        {
                            Hace = Segundo.Next(0, 10);
                            H = 0;
                        }
                    }
                    cicloHace = false;
                    /*if (repetidoH == 0)//!PENDIENTE!
                    {
                        arrayHace[PH] = Hace;
                        PH++;                           //!DEBO REORGANIZARLO
                        cicloHace = false;
                    }
                    else
                    {
                        cicloHace = true;
                    }*///!HASTA AQUI
                }
                if (Hace != Manda)//! CAMBIARLO DE POSICION
                {
                    arrayHace[PH] = Hace;
                    PH++;
                    arrayManda[PM] = Manda;
                    PM++;
                    FinWhile = false;
                }
                else                //! ES MEJOR PONERLO ARRIBA
                {
                    FinWhile = true;
                    cicloHace = true;
                    cicloManda = true;
                }//!HASTA AQUI
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(PosicionArray);
            Utils.Repro("Audio.wav");    //!MUTEADO
            Thread.Sleep(5000); //!MUTEADO
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Da el mandato: {NombresArrays[Manda]}");
            Utils.Repro("Audio.wav"); //!MUTEADO
            Thread.Sleep(5000); //!MUTEADO
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hace el mandato: {NombresArrays[Hace]}");
            Utils.Repro("_se_la_acaba_de_beberr_-_Parodiadera.wav"); //!MUTEADO
            Thread.Sleep(14000); //!MUTEADO
            bool ciclo = true;
            //!    Inicio del Cronometro.
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ingrese los minutos: ");
            int Dato = int.Parse(Console.ReadLine());
            int Segundos = 0, Minutos = 0;
            do
            {
                switch (Dato)
                {
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Por favor, ingrese una cantidad de minutos mas elavada.");
                        Console.Write("Ingrese los minutos: ");
                        Dato = int.Parse(Console.ReadLine());
                        break;
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("¿Estan listos para iniciar?");
                            string Respuesta = Console.ReadLine();
                            bool Preparado = true;
                            if (Respuesta == "SI" || Respuesta == "si" || Respuesta == "Si" || Respuesta == "sI")
                            {
                                while (Preparado == true)
                                {
                                    Segundos++;
                                    if (Segundos == 60)
                                    {
                                        {
                                            Minutos++;
                                            Segundos = 0;
                                        }
                                        if (Minutos == Dato)
                                        {
                                            Utils.Repro("tiempo.wav");
                                            ciclo = false;
                                            Preparado = false;
                                        }
                                    }
                                    Console.Clear();
                                    if (Minutos + 1 == Dato)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                    }
                                    if (Minutos + 1 == Dato && Segundos >= 50)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                    }
                                    Console.WriteLine(Minutos + ":" + Segundos);
                                    Thread.Sleep(899);
                                }
                            }
                        }
                        break;
                }
            } while (ciclo == true); //!    Fin del Cronometro.
            //Console.BackgroundColor = ConsoleColor.Black;
            PosicionArray++;
            //Utils.Repro("Desea.wav"); //!MUTEADO
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("¿Desea correrlo nuevamente? x = terminar");
            desicion = Console.ReadLine();
            if (desicion == "x" || PosicionArray == 14)
            {
                ciclopadre = false;
                cicloHace = false;
                cicloManda = false;
                if (PosicionArray == 10)
                {
                    Console.Clear();
                    //Utils.Repro("Todos.wav"); //*Audio
                    Console.WriteLine("Todos los estudiantes han participado, es suficiente por hoy(ㆆ_ㆆ)");
                    for (int i = 0; i < arrayManda.Length; i++)
                    {
                        arrayHace[i] = 0;
                        arrayManda[i] = 0;
                    }
                    Console.ReadKey();
                }
                if (desicion == "x")
                {
                    Console.Clear();
                    //Utils.Repro("Gracias.wav"); //*Audio
                    Console.WriteLine("Gracias por utilizar mi programa(◔◡◔)");
                    Console.ReadKey();
                }
            }
            if (desicion != "x" && PosicionArray < 10)
            {
                ciclopadre = true;
                cicloHace = true;
                cicloManda = true;
            }
            Console.Clear();
        }
    }
}
