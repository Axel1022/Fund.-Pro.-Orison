//Programa Ramdom

using System;

{
    {
        //*Elegir dos estidiantes totalmente ramdom.
        string[] NombresArrays;	//*Declarando el arreglo.
        NombresArrays = new string[21];	//*Espacio que tiene el array.
        bool cicloHace = true;
        bool cicloManda = true;
        bool ciclopadre = true;
        //bool RepetidoM;
        int repetidoH = 0, repetidoM = 0;
        string desicion = "";
        int PH = 0, PM = 0, M = 0, H = 0, PosicionArray = 1;
        //string ConteoDesicion;
        int[] arrayManda = new int[21];
        int[] arrayHace = new int[21];
        Random Primero = new Random();	//*Numero ramdom.
        Random Segundo = new Random();	//*Numero ramdom.
        int Hace = 0, Manda = 0;
        //*Estudiantes con un espacio asignado (numero) dentro del array
        NombresArrays[0] = "";
        NombresArrays[1] = "Derik Diaz";
        NombresArrays[2] = "Rainy Diaz";
        NombresArrays[3] = "Jinnet Reyes";
        NombresArrays[4] = "Paul Garcia";
        NombresArrays[5] = "Federico Garcia";
        NombresArrays[6] = "Jack Gomez";
        NombresArrays[7] = "Daniel Beras";
        NombresArrays[8] = "Starling Jacobo";
        NombresArrays[9] = "Bryant Reynoso";
        NombresArrays[10] = "Enmanuel Lopez";
        NombresArrays[11] = "Wandry Martinez";
        NombresArrays[12] = "Osiris Moreta";
        NombresArrays[13] = "Luis Mendez";
        NombresArrays[14] = "Yoshua Perez";
        NombresArrays[15] = "Feliz Navarro";
        NombresArrays[16] = "Dayely Mateo";
        NombresArrays[17] = "Jaylina Rodriguez";
        NombresArrays[18] = "Jose Sandoval";
        NombresArrays[19] = "Jose Ramirez";
        NombresArrays[20] = "Alexander Campusano";
        //*Variable boleana para el ciclo ehile.
        bool FinWhile = true;
        //*Console.Clear();
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
                    Manda = Primero.Next(1, 21);
                    cicloManda = true;
                    for (M = 0; M < arrayManda.Length; M++)
                    {
                        while (Manda == arrayManda[M])
                        {
                            Manda = Primero.Next(1, 21);
                            M = 0;
                        }
                    }
                    for (int M1 = 0; M1 < arrayManda.Length; M1++) //!desde aqui
                    {
                        if (Manda != arrayManda[M])
                        {
                            repetidoM = 1;
                        }
                    } //!Hasta aqui
                    if (repetidoM == 0)
                    {
                        arrayManda[PM] = Manda;
                        PM++;
                        cicloManda = false;
                    }
                    else
                    {
                        cicloManda = true;
                    }
                }
                cicloHace = true;
                while (cicloHace == true)
                {
                    Hace = Segundo.Next(1, 21);
                    //cicloHace = false;
                    for (H = 0; H < arrayHace.Length; H++)
                    {
                        if (Hace == arrayHace[H])
                        {
                            Hace = Segundo.Next(1, 21);
                            H = 0;
                        }
                    }
                    if (repetidoH == 0)
                    {
                        arrayHace[PH] = Hace;
                        PH++;
                        cicloHace = false;
                    }
                    else
                    {
                        cicloHace = true;
                    }
                }
                if (Hace != Manda)
                {
                    FinWhile = false;
                }
                else
                {
                    FinWhile = true;
                    cicloHace = true;
                    cicloManda = true;
                }
            }
            Console.Clear();
            Console.WriteLine(PosicionArray);
            Utils.Repro("Audio.wav"); //*Audio
            Thread.Sleep(5000); //*Darle tiempo para que acabe el audio.
            /*switch (Manda) //! Sin completar. desde aqui.
            {   case 1:
                    Utils.Repro(".wav"); //*Audio Derik
                break;
                case 2:
                    Utils.Repro(".wav"); //*Audio
                break;
                case 3:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                    case 4:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 5:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 6:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 7:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 8:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 9:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 10:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 11:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 12:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 13:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 14:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 15:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 16:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 17:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 18:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 19:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
                case 20:
                    Utils.Repro("Audio.wav"); //*Audio
                break;
            }*/ //!Hasta aqui
            Console.WriteLine($"Da el mandato: {NombresArrays[Manda]}");
            Utils.Repro("Audio.wav"); //*Audio
            Thread.Sleep(5000); //*Darle tiempo para que acabe el audio.
            Console.WriteLine($"Hace el mandato: {NombresArrays[Hace]}");
            Utils.Repro("_se_la_acaba_de_beberr_-_Parodiadera.wav"); //*Audio
            Thread.Sleep(14000); //Darle tiempo para que acabe el audio.
            PosicionArray++;
            Utils.Repro("Desea.wav"); //Audio
            Console.WriteLine("¿Desea correrlo nuevamente? x = terminar");
            desicion = Console.ReadLine();
            if (desicion == "x" || PosicionArray == 21)
            {
                ciclopadre = false;
                cicloHace = false;
                cicloManda = false;
                if (PosicionArray == 22)
                {
                    Console.Clear();
                    Utils.Repro("Todos.wav"); //*Audio
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
                    Utils.Repro("Gracias.wav"); //*Audio
                    Console.WriteLine("Gracias por utilizar mi programa(◔◡◔)");
                    Console.ReadKey();
                }
            }
            if (desicion != "x" && PosicionArray < 21)
            {
                ciclopadre = true;
                cicloHace = true;
                cicloManda = true;
            }
            Console.Clear();
        }
    }
}
