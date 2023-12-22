//Cambiarlo a centimetro, metros y kilometros.
bool ParaElWhile = true;
while (ParaElWhile == true)
{
    Console.WriteLine(@"¿Que quieres hacer
    (1) De Libras a Onzas y Gramos
    (2) De Onzas a Libras y Gramosdo
    (3) De Gramos a Onzas y Libras
    (0) Salir?");
    int R = int.Parse(Console.ReadLine());
    Funciones.Masa(R);
}
