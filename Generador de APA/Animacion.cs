public class Animacion
{
    public static void Salida(string Texto)
    {
        string SalidaTxto = "";
        int count = 0;
        do
        {
            for (int i = 0; i < Texto.Length; i++)
            {
                Console.WriteLine();
                SalidaTxto += Texto[i];
                Console.Write($"\t \t \t   {SalidaTxto}  ");
                Thread.Sleep(210);
                Console.Clear();
            }
            count += 5;
        } while (count < 5);
    }
}
