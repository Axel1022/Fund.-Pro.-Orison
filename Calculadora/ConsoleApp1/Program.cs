//Binario a decimal
int Inicio = 1;
int Suma = 0;
Console.WriteLine("Ingrese numero binario");
string Binario = Convert.ToString(Console.ReadLine());
int Longitud = Binario.Length;
int A = Longitud - 1;
string[] Numeros = new string[Longitud];
int[] NumerosR = new int[Longitud];
for (int i = 0; i < Longitud; i++)
{
    NumerosR[i] = Convert.ToInt16(Math.Pow(2, i));
}
for (int i = 0; i < Longitud; i++)
{
    
    if (Binario.Substring(i, 1)=="1")
    {
        Suma = Suma + NumerosR[A];
    }
    A--;
}
Console.WriteLine(Suma);
