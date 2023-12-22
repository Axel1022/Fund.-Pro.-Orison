class BinariosYotros
{
    public static void EXTRA()
    {
        bool ParaWhile = true;
        while (ParaWhile == true)
        {
            Console.Clear();
            TextoGrande.Bi_HE_EN();
            TextoPequeño.EligeOpcion();
            Menu.Bi_HE_EN();
            int Opcion = int.Parse(Console.ReadLine());
            switch (Opcion)
            {
                case 0:                                                                     //!Caso 0
                    Console.Clear();
                    ParaWhile = false;
                    break;
                case 1:                                                                     //!Caso 1
                    //Convertir a Binario.
                    Console.Clear();
                    TextoGrande.ConvertiraB();
                    Console.Write("Ingrese un numero entero: ");
                    long Numero = int.Parse(Console.ReadLine()); //Guardo el numero entero.
                    long Guardado = Numero;
                    long BinarioX;
                    const int posicionf = 1; //Constante.
                    int posicion0i = 0;
                    string BinarioTexto = "";
                    while (Numero > 0)
                    {
                        BinarioX = Numero % 2; //Aqui bussco el modulo del numero introduccido.
                        BinarioTexto = BinarioTexto + Convert.ToString(BinarioX) + ""; //Guardo el resultado en string.
                        Numero = Numero / 2;
                    }
                    int Cantidad = BinarioTexto.Length; //.Length devuelve la cantidad de caracteres que contiene la variable.
                    string[] Original = new string[Cantidad]; //Array.
                    for (int i = 0; i < Original.Length; i++)
                    {
                        Original[i] = BinarioTexto.Substring(posicion0i, posicionf); //EJ: Hola. Substring (0 , 1)= H. //EJ: Hola. Substring (1 , 1)= o.
                        posicion0i++; //Iterador. Mirar el ejemplo anterior.
                    }
                    Console.Clear();
                    la.Animacion(6);
                    TextoGrande.ConvertiraB();
                    Console.Write(Guardado + " convertido a binario es: ");
                    for (int i = 0; i < Original.Length; i++)
                    {
                        Cantidad--;
                        Console.Write(Original[Cantidad]); //Imprime todo en una sola linea.
                    }
                    Console.ReadKey();
                    break;
                case 2:                                                                             //!Caso 2
                    //Binario a decimal
                    Console.Clear();
                    TextoGrande.ConvertiraD();
                    int Suma = 0;
                    Console.Write("Ingrese numero binario: ");
                    string Binario = Convert.ToString(Console.ReadLine());
                    Guardado = Convert.ToInt64(Binario);
                    int Longitud = Binario.Length;
                    int A = Longitud - 1;
                    string[] Numeros = new string[Longitud];
                    int[] NumerosR = new int[Longitud];
                    for (int i = 0; i < Longitud; i++)
                    {
                        NumerosR[i] = Convert.ToInt16(Math.Pow(2, i));
                    }
                    for (int i = 0; i < Longitud; i++)
                    {
                        if (Binario.Substring(i, 1) == "1")
                        {
                            Suma = Suma + NumerosR[A];
                        }
                        A--;
                    }
                    Console.Clear();
                    la.Animacion(6);
                    TextoGrande.ConvertiraD();
                    Console.Write(Guardado + " convertido a entero es: " + Suma);
                    Console.ReadKey();
                    break;
                case 3:                                                                              //!Caso 3
                    Console.Clear();
                    TextoGrande.ConvertiraH();
                    Console.Write("Ingrese un numero entero: ");
                    Numero = int.Parse(Console.ReadLine()); //Guardo el numero entero.
                    Guardado = Numero;
                    string[] NumeroHex = new string[17];
                    string Resultado = "";
                    while (Numero > 0)
                    {
                        BinarioX = Numero % 16; //Aqui bussco el modulo del numero introduccido
                        switch (BinarioX)
                        {
                            case 0:
                                Resultado = Resultado + "0";
                                break;
                            case 1:
                                Resultado = Resultado + "1";
                                break;
                            case 2:
                                Resultado = Resultado + "2";
                                break;
                            case 3:
                                Resultado = Resultado + "3";
                                break;
                            case 4:
                                Resultado = Resultado + "4";
                                break;
                            case 5:
                                Resultado = Resultado + "5";
                                break;
                            case 6:
                                Resultado = Resultado + "6";
                                break;
                            case 7:
                                Resultado = Resultado + "7";
                                break;
                            case 8:
                                Resultado = Resultado + "8";
                                break;
                            case 9:
                                Resultado = Resultado + "9";
                                break;
                            case 10:
                                Resultado = Resultado + "A";
                                break;
                            case 11:
                                Resultado = Resultado + "B";
                                break;
                            case 12:
                                Resultado = Resultado + "C";
                                break;
                            case 13:
                                Resultado = Resultado + "D";
                                break;
                            case 14:
                                Resultado = Resultado + "E";
                                break;
                            case 15:
                                Resultado = Resultado + "F";
                                break;
                        }
                        Numero = Numero / 16;
                    }
                    Cantidad = Resultado.Length;
                    int Inicio = Cantidad - 1;
                    Console.Clear();
                    la.Animacion(6);
                    TextoGrande.ConvertiraH();
                    Console.Write(Guardado + " convertido a hexadecimal es: ");
                    for (int i = 0; i < Cantidad; i++)
                    {
                        const int Final = 1;
                        Console.Write(Resultado.Substring(Inicio, Final));  //Imprime todo en una sola linea.
                        Inicio--;
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("No es una opcion.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
