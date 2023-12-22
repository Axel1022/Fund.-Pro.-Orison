internal class Program
{
    private static void Main(string[] args)
    {
        //minutos a horas y minutos.
        {
            Console.Clear();
            int Min, MinE, Hor = 0;
            Console.Write("Ingrese la cantidad de minutos:");
            Min = int.Parse(Console.ReadLine());

            MinE = Min;
            while (Min >= 60)
            {
                Min -= 60;
                Hor++;
            }
            Console.Clear();
            Console.WriteLine(MinE + " minutos" + " son " + Hor + " horas y " + Min + " minutos. ");

        }
    }
}
