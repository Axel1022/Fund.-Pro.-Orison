
//Desarrollar un programa con un arreglo de diez posiciones, llenar por el teclado con numeros enteros, determinsr cuantos fueron positivos, cuantos fueron posicitivos y cuantos neutros.

int positivos = 0;
int negativos = 0;
int neutros = 0;
string input = "";
int inputInt = 0;
bool esNumero = false;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Ingrese el número {i}: ");
    input = Console.ReadLine()!;
    esNumero = int.TryParse(input, out inputInt);

    while (!esNumero)
    {
        Console.WriteLine("El número ingresado no es válido.");
        Console.Write($"Ingrese el número {i}: ");
        input = Console.ReadLine()!;
        esNumero = int.TryParse(input, out inputInt);
    }

    RegistrarNumero(inputInt);
}

Console.WriteLine($"Positivos: " + positivos);
Console.WriteLine($"Negativos: " + negativos);
Console.WriteLine($"Neutros: " + neutros);

void RegistrarNumero(int num)
{
    if (num == 0) neutros++;
    else if (num > 0) positivos++;
    else if (num < 0) negativos++;
}



