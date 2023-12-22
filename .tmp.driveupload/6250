class program
{
    static void Main()
    {
        bool repetir = true;
        int Respuesta = 0;
        while (repetir == true)
        {
            Console.Clear();
            Console.WriteLine("Funciones");
            Console.WriteLine(@"
            ¿Que deseas hacer?
            (1) Nombre y saludo.
            (2) Ultimo digito.
            (3) Par o impar.
            (4) Multiplicar digito.
            (5) Numero mayor.
            (0) Salir");
            Respuesta= Convert.ToInt32(Console.ReadLine());
            switch(Respuesta) 
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Ingrese su nombre: ");
                    string Nombre = Console.ReadLine();
                    Console.WriteLine(Saludar(Nombre));
                    Console.ReadKey();
                    break;
                    case 2:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero de dos digitos");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(UltimoDigito(Numero));
                    Console.ReadKey();
                    break;
                    case 3:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(ParOImpar(Numero));
                    Console.ReadKey();
                    break;
                    case 4:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero de dos digitos");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(Multiplicar(Numero));
                    Console.ReadKey();
                    break;
                    case 5:
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero de dos digitos");
                    int Numero = int.Parse(Console.ReadLine());
                    Console.WriteLine(Multiplicar(Numero));
                    Console.ReadKey();
                    break;
                    case 0:
                    Console.Clear();
                    Console.WriteLine("Gracias por utilizar mi programa!");
                    repetir= false;
                    break;
                    default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("!ERROR¡");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"{Respuesta} no es una opcion valida");
                    Console.ReadKey(); break;
            }
        }
    }
    //Funciones
    static string Saludar(string nombre)
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UNA CADENA
         * (EL NOMBRE DEL USUARIO) LA FUNCIÓN DEBE RETORNAR UN SALUDO 
         * QUE INCLUYA EL NOMBRE DEL USUARIO QUE RECIBIÓ.*/
        Console.Clear();
        string nombreySaludo= nombre + ", nice to meet you.";
        return nombreySaludo;
    }
    static int UltimoDigito(int Numero)
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE 
         * DOS DÍGITOS Y RETORNE SU ÚLTIMO DÍGITO. */
        Console.Clear();
        Numero = Numero % 10;
        return Numero;
    }
    static int ParOImpar(int Numero)
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN NUMERO
         * Y RETORNE UN MENSAJE DICIENDO SI ES PAR O IMPAR, SEGÚN SEA
         * EL CASO.*/
        Console.Clear();
        if (Numero%2==0)
        {
            return Numero + " es par.";
        }
        else
        {
            return Numero + " es impar.";
        }
    }
    static int Multiplicar(int Numero)
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS
         * DÍGITOS Y QUE ESTA FUNCIÓN GENERE Y MUESTRE EN PANTALLA LA TABLA 
         * DE MULTIPLICAR DEL PRIMER DÍGITO, SIENDO EL LÍMITE DE LA TABLA EL
         * SEGUNDO DÍGITO. */
        Console.Clear();
        int NumeroP = Numero % 100/10;
        int NumeroU = Numero % 10;
        for(int i =0; i <= NumeroU; i++)
        {
            return($"{NumeroP} * {i} = {NumeroP * i}");
        }
    }
    static int NumeroMayor(int Numero)
    {
        /*CONSTRUIR UNA FUNCIÓN QUE RECIBA COMO PARÁMETRO UN ENTERO DE DOS DÍGITOS.
         * LA FUNCIÓN DEBE RETORNAR EL MAYOR DE LOS DOS DÍGITOS.*/
        Console.Clear();
        int NumeroP = Numero % 100 / 10;
        int NumeroU = Numero % 10;
        if (NumeroP > NumeroU)
        {
            return NumeroP+ " es mayor que "+ NumeroU;
        }
        else if(NumeroU==NumeroP)
        {
            return NumeroP + " y " + NumeroU+ " son iguales";
        }
        else
        { return NumeroU + " es mayor que " + NumeroP; }
    }
}
