public class Apa
{
    public static string[] generalApa()
    {
        do
        {
        inicio:
            Console.Clear();
            Console.WriteLine(@"
            ======================================
                        Citado General
            ======================================");

            System.Console.WriteLine("Cantidad de citas que desea genral: ");
            System.Console.Write(">>>");
            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Digito incorrecto.");
                Thread.Sleep(1000);
                Console.ResetColor();
                goto inicio;
            }
            string[] citas = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Clear();
                System.Console.WriteLine($"Citas: {i + 1} ");
                System.Console.WriteLine("Nombre");
                System.Console.Write(">>> ");
                string Nombre = Console.ReadLine()!;
                System.Console.WriteLine("Apellido");
                System.Console.Write(">>> ");
                string Apellido = Console.ReadLine()!;
                System.Console.WriteLine("Titulo");
                System.Console.Write(">>> ");
                string Titulo = Console.ReadLine()!;
                System.Console.WriteLine("Fecha");
                System.Console.Write(">>> ");
                string Fecha = Console.ReadLine()!;
                System.Console.WriteLine("Editoral");
                System.Console.Write(">>> ");
                string editoral = Console.ReadLine()!;
                //Console.WriteLine("\u001B[3m cursiva \u001B[0m");
                //Console.ReadKey();
                citas[i] = $"{Apellido}, {Nombre[0]}. ({Fecha}). {Titulo}. {editoral}.";
            }
            //S


            return citas;

        } while (true);




        //Console.ReadKey();




    }
}
/*


*/
