/*PROGRAMA QUE LEA UN NUMERO DE TRES DÍGITOS
(DEBE VALIDAR ESA ENTRADA) Y CALCULE LA SUMATORIA DE SUS DÍGITOS*/
int numero;

Console.Write("Ingrese un número de tres dígitos: ");
if (int.TryParse(Console.ReadLine(), out numero))
{
    if (numero >= 100 && numero <= 999)
    {
        int suma = 0;
        int digito;

        digito = numero % 10; // Obtener el último dígito
        suma += digito;
        numero = numero / 10; // Descartar el último dígito

        digito = numero % 10; // Obtener el siguiente dígito
        suma += digito;
        numero = numero / 10; // Descartar el siguiente dígito

        digito = numero % 10; // Obtener el primer dígito
        suma += digito;

        Console.WriteLine("La sumatoria de los dígitos es: " + suma);
    }
    else
    {
        Console.WriteLine("El número ingresado no tiene tres dígitos.");
    }
}
else
{
    Console.WriteLine("Ingrese un número válido.");
}
