class Funciones
{
    public static void decimalTohexagesimal(int BinarioX, int Cantidad){
        Console.Clear();
        Console.Write("Ingrese un numero entero: ");
        int Numero = int.Parse(Console.ReadLine()); //Guardo el numero entero.
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
        for (int i = 0; i < Cantidad; i++)
        {
            const int Final = 1;
            Console.Write(Resultado.Substring(Inicio, Final));  //Imprime todo en una sola linea.
            Inicio--;
        }
        Console.ReadKey();

    }
}
