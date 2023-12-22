class Manual
{
    public static void verManual() {

        Console.WriteLine(@"
======================================
           Manual de Usuario
======================================
Para salir del programa: Presione la tecla 'ESC'.
Ingrese solo números para seleccionar una opción.

Flujo del programa:
1. Seleccione la opción 2 para generar las normas de citado.
2. Ingrese la cantidad de citas que desea generar.
3. Introduzca los datos solicitados para cada cita.
   En caso de no aplicar un dato solicitado, déjelo vacío.

Ejemplo de flujo:
1. Seleccione la opción 2.
2. Ingrese '3' para generar tres citas.
3. Siga las indicaciones para proporcionar los datos de cada cita.
   Si un dato no aplica, simplemente presione Enter para dejarlo vacío.

¡Gracias por utilizar el Generador de Citado APA!
>>>Press Enter to continue...");
        Console.ReadKey();

    }
}
