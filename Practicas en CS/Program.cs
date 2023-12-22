List<string> Nombres = new List<string>();
List<string> Apellidos = new List<string>();
List<string> Correos = new List<string>();
List<string> Telefonos = new List<string>();
List<string> Direcciones = new List<string>();

Console.Write("Ingrese un nombre: ");
Nombres.Add(Console.ReadLine());
Console.Write("Ingrese un apellido: ");
Apellidos.Add(Console.ReadLine());
Console.Write("Ingrese un Correo: ");
Correos.Add(Console.ReadLine());
Console.Write("Ingrese un Telefono: ");
Telefonos.Add(Console.ReadLine());
Console.Write("Ingrese un Direccion: ");
Direcciones.Add(Console.ReadLine());
//-------------------------------------------------
Console.Clear();
Console.WriteLine("Contacto añadido correctamente.");
Console.Write("Precione una tecla");
Console.ReadKey();Console.Clear();
//-------------------------------------------------
Console.Write("Ingrese un nombre: ");
Nombres.Add(Console.ReadLine());
Console.Write("Ingrese un apellido: ");
Apellidos.Add(Console.ReadLine());
Console.Write("Ingrese un Correo: ");
Correos.Add(Console.ReadLine());
Console.Write("Ingrese un Telefono: ");
Telefonos.Add(Console.ReadLine());
Console.Write("Ingrese un Direccion: ");
Direcciones.Add(Console.ReadLine());
Console.Clear();
Console.WriteLine("Contacto añadido correctamente.");
Console.WriteLine("Precione una tecla");
Console.ReadKey();Console.Clear();
//-------------------------------------------------
for (int i = 0; i < Nombres.Count; i++)
{
    Console.WriteLine("---------------"+i+"--------------");
    Console.WriteLine(Nombres[i]);
    Console.WriteLine(Apellidos[i]);
    Console.WriteLine(Correos[i]);
    Console.WriteLine(Telefonos[i]);
    Console.WriteLine(Direcciones[i]);
    Console.WriteLine("**************************************************");
}
//---------------------------------------------------
int Indice=0;
Console.WriteLine("Ingrese el indice del contacto que deseas borrar: ");
Indice= int.Parse(Console.ReadLine());
Nombres.Remove((Nombres[Indice]));
Apellidos.Remove((Apellidos[Indice]));
Correos.Remove((Correos[Indice]));
Telefonos.Remove((Telefonos[Indice]));
Direcciones.Remove((Direcciones[Indice]));
Console.WriteLine("IContactos borrado correctamente");
Console.WriteLine("Precione una tecla");
Console.ReadKey();Console.Clear();
//-----------------------------------------------------
Console.Write("Contactos actualizados");
for (int i = 0; i < Nombres.Count; i++)
{
    Console.WriteLine("---------------"+i+"--------------");
    Console.WriteLine(Nombres[i]);
    Console.WriteLine(Apellidos[i]);
    Console.WriteLine(Correos[i]);
    Console.WriteLine(Telefonos[i]);
    Console.WriteLine(Direcciones[i]);
    Console.WriteLine("**************************************************");
}