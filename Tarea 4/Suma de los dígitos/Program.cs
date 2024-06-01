/*PROGRAMA QUE LEA UN NUMERO DE DOS DÍGITOS
 QUE DETERMINE LA SUMA DE LOS DOS DÍGITOS.*/
internal class Program
{
    private static void Main(string[] args)
    {
        //Variables
        int Num, Num1, Num2, Numf;        //Entrada
        Console.WriteLine("Ingrese un numero de dos digitos");
        Num = int.Parse(Console.ReadLine());
        //Proceso
        Num1 = Num % 100 / 10;
        Num2 = Num % 10;
        Numf = Num1 + Num2;
        //Salida
        Console.WriteLine(Num1 + " + " + Num2 + " es : " + Numf);
        Console.WriteLine(Num1);
        Console.WriteLine(Num2);
    }
}
