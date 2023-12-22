class Funciones
{
    public static void Masa(int R)
    {
        switch (R)
        {
            case 1:
            //De Centrimetro a Metros y Kilometros
            Console.Write("Ingrese las libras: ");
            double Masa=Convert.ToDouble(Console.ReadLine());
            double Onzas = (Masa*16) /1;
            //double Kilometros = (Longitud) /1000000;
            //Console.WriteLine(Kilometros);
            Console.WriteLine(Onzas);
            break;
        }
    }
}
