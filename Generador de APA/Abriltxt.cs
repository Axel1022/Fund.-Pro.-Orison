using System.Diagnostics;
public class Abrir
{
    public static void Txt()
    {
        try
        {
            string rutaArchivo = @"C:\Users\IngCa\OneDrive\Escritorio\Carpetas\Programacion C#\Generador de APA\NormasApa.txt";

            if (File.Exists(rutaArchivo))
            {
                Process.Start("notepad.exe", rutaArchivo);
            }
            else
            {
                Console.WriteLine("El archivo no existe en la ruta especificada.");
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error al intentar abrir el documento: " + ex.Message);
            Console.ReadKey();
        }
    }
}
