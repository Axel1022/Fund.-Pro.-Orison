//Buscar las vocales y cantidad de palabras.

string letra = "";
bool signo = true;
int vocales = 0;
int palabras = 0;
string texto = "";
Console.Clear();

while (signo == true)
{
    Console.WriteLine("Ingrese un texto caracter por caracter");
    letra = Console.ReadLine();
    Console.Clear();

    if (letra=="$")
    {
        signo = false;
    }
    else if (letra == "a"|| letra == "e" || letra == "i" || letra == "o" || letra == "u"||letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
    {
            vocales++;
    }

    else if (letra == " " || letra == "." )
    {
        palabras++;
    }


    if (letra != "$")
    { texto = texto + letra; }

    
}


Console.WriteLine($"El texto ingresado es: {texto}");
Console.WriteLine($"Cantidad de  vocales encontradas: {vocales}");
Console.WriteLine($"Cantidas de palabras encontradas: {palabras}");
