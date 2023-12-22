/* Un vendedor recibe un sueldo base mas un 10% extra por comisión de sus ventas.
 El desea saber cuanto recibirá a fin de mes por concepto de comisión y por concepto
 de salario total. Debe ingresar el salario del vendedor, monto vendido, realizar el
 calculo y mostrar los resultados. */
using System;

{
   {
      //Declaro variables
      double Com1, Com2, Com3, Com4, Sue, SueF, ComT;
      //El vendedor hace 4 ventas al mes***
      //Entrada
      Console.Write("Ingrese la primera venta: ");
      Com1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Ingrese la segunda venta: ");
      Com2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Ingrese la tercera venta: ");
      Com3 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Ingrese la cuarta venta: ");
      Com4 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Ingrese su sueldo: ");
      Sue = Convert.ToDouble(Console.ReadLine());
      //Console.Clear();
      //Proceso
      ComT = (Com1 + Com2 + Com3 + Com4) * 0.10;
      SueF = Sue + ComT;
      //Salida
      Console.WriteLine("-------------------------------- Datos --------------------------------");
      Console.WriteLine("Sueldo: " + Sue);
      Console.WriteLine("Comision por ventas :" + ComT);
      Console.WriteLine("Suelto total: " + SueF);

   }
}

/*using System;

{
{

    //Elegir dos estidiantes totalmente ramdom.
    string[]NombresArrays;	//Declarando el arreglo.
    NombresArrays = new string[20];	//Espacio que tiene el array.
    int Hace = 0, Manda = 0, Respuesta;
    //Estudiantes con un espacio asignado (numero) dentro del array
    NombresArrays[0] = "Alexander Campusano";

    NombresArrays[1] = "Derik Diaz";

    NombresArrays[2] = "Rainy Diaz";

    NombresArrays[3] = "Jinnet Reyes";

    NombresArrays[4] = "Paul Garcia";

    NombresArrays[5] = "Federico Garcia";

    NombresArrays[6] = "Jack Gomez";

    NombresArrays[7] = "Daniel Beras";

    NombresArrays[8] = "Starling Jacobo";

    NombresArrays[9] = "Bryant Reynoso";

    NombresArrays[10] = "Enmanuel Lopez";

    NombresArrays[11] = "Wandry Martinez";

    NombresArrays[12] = "Osiris Moreta";

    NombresArrays[13] = "Luis Mendez";

    NombresArrays[14] = "Yoshua Perez";

    NombresArrays[15] = "Feliz Navarro";

    NombresArrays[16] = "Dayely Mateo";

    NombresArrays[17] = "Jaylina Rodriguez";

    NombresArrays[18] = "Jose Sandoval";

    NombresArrays[19] = "Jose Ramirez";

    //Variable boleana para el ciclo ehile.
    bool FinWhile = true;


    while (FinWhile == true)

    {


      Console.WriteLine (NombresArrays[Manda]);
      Console.WriteLine (NombresArrays[Hace]);

      Console.WriteLine(@"Elija una opcion:
      1. !RROR¡ Repetir.
      2. Elejir nuevos candidatos.
      3. Terminar por hoy.
      ");
      Respuesta = int.Parse(Console.ReadLine());
      switch (Respuesta)
      {
         case 1:

         break;

      }


      FinWhile = false;


    }






}
}*/
