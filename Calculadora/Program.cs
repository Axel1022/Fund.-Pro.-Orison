//Calculadora
class Calculadora
{
    public static void Main()
    {
        bool CicloWhile = true; string Opcion = "";
        while (CicloWhile == true)
        {
            Console.WriteLine(@"Elije una opcion:
            (+) Sumar
            (-) Restar
            (*) Multiplicar
            (/) Dividir
            (X) Salir");
            Opcion = Console.ReadLine(); Opcion = Opcion.ToLower();
            if (Opcion == "+" || Opcion == "-" || Opcion == "*" || Opcion == "/" || Opcion == "x")
            {
                if (Opcion == "+" || Opcion == "-" || Opcion == "*" || Opcion == "/")
                {
                    Console.Clear();
                    Console.Write("Ingrese numero 1: ");
                    decimal Numero1 = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Ingrese numero 2: ");
                    decimal Numero2 = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine(Funciones.Calcular(Opcion, Numero1, Numero2));
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    CicloWhile = false;
                }
            }
            else { Funciones.NoValido(); }
        }
    }
}