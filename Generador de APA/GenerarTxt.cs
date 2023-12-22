public class Generar
{
    public static void Txt(string [] citas){

        String NombreTxt = "NormasApa.txt";
        for (int i = 0; i < citas.Length; i++)
        {
            TextWriter ElHistorial = File.AppendText(NombreTxt);
            ElHistorial.WriteLine($"{i+1}. {citas[i]}");
            ElHistorial.Close();
        }
    }
}
