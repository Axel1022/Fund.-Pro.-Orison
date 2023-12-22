
internal class Program
{
    private static void Main(string[] args)
    {
        string SalidaTxto = "";
        string Texto = "Texto de ejemplo";
        int count = 0;
        do
        {
            for (int i = 0; i < Texto.Length; i++)
            {
                Console.WriteLine();
                SalidaTxto = SalidaTxto + Texto[i];
                Console.Write($"\t \t \t   {SalidaTxto}  ");
                Thread.Sleep(210);
                Console.Clear();
            }
            count += 5;
        } while (count < 5);
    }
}
