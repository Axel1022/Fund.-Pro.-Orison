using System;

class Program
{
    static void Main()
    {
        string[] citas;

        do
        {

            Console.Clear();
            Console.Write(@"
===============================
    Generador de Citado APA
===============================
Seleccione una opción:
1. Manual de uso.
2. Citado General.

Por favor, ingrese el número correspondiente a su elección:");

            char opcion;

            if (!char.TryParse(Console.ReadLine(), out opcion))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Digito incorrecto.");
                Thread.Sleep(1000);
                Console.ResetColor();
            }

            switch (opcion)
            {
                case '1':
                    Manual.verManual();
                    break;
                case '2':
                    citas = Apa.generalApa();
                    Animacion.Salida("Generando normas...");
                    Generar.Txt(citas);
                    Animacion.Salida("Abriendo docuemnto generado...");
                    Abrir.Txt();
                    break;
            }
        } while (true);

    }

}
