class Historial
{
    public static void EscribirHistorial(string guardar)
    {
        TextWriter ElHistorial = File.AppendText("Historial.txt");
        ElHistorial.WriteLine(guardar);
        ElHistorial.Close();
        
    }
    public static void LeerHistorial()
    {
        TextReader ELHistorial = new StreamReader("Historial.txt");
        Console.WriteLine(ELHistorial.ReadToEnd());
        ELHistorial.Close();
    }
}
class Monedas
{
    //TextWriter ElHistorial = new StreamWriter("Historial.txt");//!Para crear el archivo.
    string ParaGuardar="";
        public static void Domi()
        {
            string ParaGuardar="";
            Console.Write("Ingrese los RD$: ");
            int Entrada = Convert.ToInt32(Console.ReadLine());
            double Dolares = Entrada * 0.018;
            double Euros = Entrada * 0.017;
            Console.WriteLine("Resultado: " + Math.Round(Dolares,2));
            Console.WriteLine("Resultado: " + Math.Round(Euros,2));
            ParaGuardar=$"{Entrada} RD = {Dolares} USD y {Euros} EUR";
            Historial.EscribirHistorial(ParaGuardar);
        }
        public static void Esta()
        {
            Console.WriteLine("Ingrese los USD$");
            int Entrada = Convert.ToInt32(Console.ReadLine());
            double Pesos = Entrada * 54.75;
            double Euro = Entrada * 0.96;
            Console.WriteLine("Resultado: " + Math.Round(Pesos,2));
            Console.WriteLine("Resultado: " + Math.Round(Euro,2));
        }
        public static void Espa()
        {
            Console.WriteLine("Ingrese los EUR$");
            int Entrada = Convert.ToInt32(Console.ReadLine());
            double Pesos = Entrada * 57.29;
            double Dolares = Entrada * 1.05;
            Console.WriteLine("Resultado: " + Math.Round(Pesos,2));
            Console.WriteLine("Resultado: " + Math.Round(Dolares,2));
        }
}


