using System;
{
    {
        //bool Fin_While = true;
        bool Fin_While1 = true;
        int Respuesta, V3 = 0, Desicion;
        while (Fin_While1 != false)
        {
            Console.Clear();
            Console.WriteLine(@"
        Elije una opcion:

        1. PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO. CUANDO EL USUARIO,
            TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE ESOS NÚMEROS.
        2. PROGRAMA QUE RECIBA 7 NÚMEROS DE PARTE DEL USUARIO. DEBE VERIFICAR SI DENTRO DE ELLOS ESTA
            EL 23. EN CASO DE QUE ASÍ SEA, MOSTRAR UN SALUDO Y SALIR. EN CASO CONTRARIO MOSTRAR UNA DESPEDIDA Y SALIR.
        3. PROGRAMA QUE LEA 10 NÚMEROS ENTEROS INGRESADOS POR EL USUARIO Y LOS INSERTE EN UN ARREGLO. A CONTINUACIÓN,
            EL PROGRAMA DEBE CONTAR Y CLASIFICAR CUÁNTOS NÚMEROS PARES Y CUÁNTOS NÚMEROS IMPARES HAY DENTRO DEL ARREGLO, Y MOSTRAR ESOS RESULTADOS.
        4. PROGRAMA QUE LEA 5 NÚMEROS POR TECLADO. DEBE COPIAR LOS VALORES EN UN SEGUNDO ARREGLO.
        0. Cerrar consola.");
            Respuesta = int.Parse(Console.ReadLine());
            Console.Clear();

            //while (Fin_While1 != false)
            {
                if (Respuesta == 0)
                {
                    Fin_While1 = false;
                    //Fin_While= false;
                }

                switch (Respuesta)
                {
                    case 1:
                        /*PROGRAMA QUE LE PIDA AL USUARIO 5 NÚMEROS Y LOS ALMACENE EN UN ARREGLO. CUANDO EL USUARIO 
                        TERMINE DE INGRESARLOS  DEBE MOSTRAR LA SUMATORIA DE ESOS NÚMEROS.*/
                        int[] Numeros = new int[5];
                        int Num = 0, Suma;
                        for (int i = 0; i < Numeros.Length; i++)
                        {
                            Num++;
                            Console.Write("Ingrese un numero " + Num + ": ");
                            Numeros[i] = int.Parse(Console.ReadLine());
                        }
                        Console.Clear();

                        Suma = Numeros[0] + Numeros[1] + Numeros[2] + Numeros[3] + Numeros[4];

                        Console.WriteLine("La suma es: " + Suma);
                        /*Console.WriteLine("¿Desea ejecutar otro ejercicio? 1 = Si, 2 = No");
                        Desicion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Desicion == 2)
                        {
                            Fin_While1= false;
                            //Fin_While=false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");

                        }*/
                        Console.WriteLine("Preciona 1 para continuar con otro ejercicio o preciona 2 para terminar");
                        Desicion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Desicion == 2)
                        {
                            Fin_While1 = false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");
                        }
                        // Console.WriteLine("Preciona una tecla para continuar con otro ejercicio");
                        //Console.ReadKey();
                        break;


                    case 2:
                        /*PROGRAMA QUE RECIBA 7 NÚMEROS DE PARTE DEL USUARIO. DEBE VERIFICAR SI DENTRO DE ELLOS ESTA
                        EL 23. EN CASO DE QUE ASÍ SEA, MOSTRAR UN SALUDO Y SALIR. EN CASO CONTRARIO MOSTRAR UNA DESPEDIDA Y SALIR.*/
                        int[] Numeros_caso2 = new int[7];
                        int No_C2 = 0;

                        for (int i = 0; i < Numeros_caso2.Length; i++)
                        {
                            No_C2++;
                            Console.Write("Ingrese numero " + No_C2 + ":");
                            Numeros_caso2[i] = int.Parse(Console.ReadLine());
                            if (Numeros_caso2[i] == 23)
                            {

                                V3++;
                            }

                        }
                        Console.Clear();
                        if (V3 > 0)
                        {
                            Console.WriteLine("Klk");
                        }
                        else
                        {
                            Console.WriteLine("Usted no cuenta con suficiente balance para esta llamada. XD");
                        }
                        /*Console.WriteLine("¿Desea ejecutar otro ejercicio? 1 = Si, 2 = No");
                        Desicion = int.Parse(Console.ReadLine());
                        if (Desicion == 2)
                        {
                            Fin_While1= false;
                            //Fin_While=false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");
                        }*/
                        Console.WriteLine("Preciona 1 para continuar con otro ejercicio o preciona 2 para terminar");
                        Desicion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Desicion == 2)
                        {
                            Fin_While1 = false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");
                        }
                        //Console.ReadKey();


                        break;

                    case 3:
                        //PROGRAMA QUE LEA 10 NÚMEROS ENTEROS INGRESADOS POR EL USUARIO Y LOS INSERTE EN UN ARREGLO. A CONTINUACIÓN, 
                        //EL PROGRAMA DEBE CONTAR Y CLASIFICAR CUÁNTOS NÚMEROS PARES Y CUÁNTOS NÚMEROS IMPARES HAY DENTRO DEL ARREGLO, Y MOSTRAR ESOS RESULTADOS.
                        int[] Numeros_caso3 = new int[10];
                        int No = 0, Par = 0, Impar = 0;
                        for (int i = 0; i < Numeros_caso3.Length; i++)
                        {
                            No++;
                            Console.Write("Ingrese numero " + No + ":");
                            Numeros_caso3[i] = int.Parse(Console.ReadLine());
                            if (Numeros_caso3[i] % 2 == 0)
                            {
                                Par++;
                            }
                            else
                            {
                                Impar++;
                            }


                        }
                        Console.Clear();
                        Console.WriteLine("Numeros pares: " + Par);
                        Console.WriteLine("Numeros impares: " + Impar);
                        /*Console.WriteLine("Preciona cualquier tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("¿Desea ejecutar otro ejercicio? 1 = Si, 2 = No"); 
                        Desicion = int.Parse(Console.ReadLine());
                        if (Desicion == 2)
                        {
                            //Fin_While = false;
                            Fin_While1 = false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");
                        }*/
                        Console.WriteLine("Preciona 1 para continuar con otro ejercicio o preciona 2 para terminar");
                        Desicion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Desicion == 2)
                        {
                            Fin_While1 = false;
                            Console.WriteLine("!GRACIAS POR UTILIZAR MIS SERVICIO¡");
                        }
                        //Console.WriteLine("Preciona una tecla para continuar con otro ejercicio");
                        //Console.ReadKey();




                        break;

                    case 4:
                        /*PROGRAMA QUE LEA 5 NÚMEROS POR TECLADO. DEBE COPIAR LOS VALORES EN UN SEGUNDO ARREGLO, SIGUIENDO ESTE REQUERIMIENTO:
                        SI EL NUMERO DE TURNO DEL PRIMER ARREGLO ES PAR, COPIARLO AL SEGUNDO ARREGLO MULTIPLICADO POR 10 
                        EN CASO CONTRARIO COPIARLO AL SEGUNDO ARREGLO TAL COMO ESTA.*/

                        int[] Numeros_caso4 = new int[5];
                        int No_ = 0;
                        for (int i = 0; i < Numeros_caso4.Length; i++)
                        {
                            No_++;
                            Console.Write("Ingrese numero " + No_ + ":");
                            Numeros_caso4[i] = int.Parse(Console.ReadLine());

                        }
                        int[] Copiados = new int[5];
                        Copiados[0] = Numeros_caso4[0];
                        Copiados[1] = Numeros_caso4[1];
                        Copiados[2] = Numeros_caso4[2];
                        Copiados[3] = Numeros_caso4[3];
                        Copiados[4] = Numeros_caso4[4];


                        Console.WriteLine("Ingresado por el usuario " + Numeros_caso4[0]);
                        Console.WriteLine("Copiado " + Copiados[0]);
                        Console.WriteLine("Ingresado por el usuario " + Numeros_caso4[1]);
                        Console.WriteLine("Copiado " + Copiados[1]);
                        Console.WriteLine("Ingresado por el usuario " + Numeros_caso4[2]);
                        Console.WriteLine("Copiado " + Copiados[2]);
                        Console.WriteLine("Ingresado por el usuario " + Numeros_caso4[3]);
                        Console.WriteLine("Copiado " + Copiados[3]);
                        Console.WriteLine("Ingresado por el usuario " + Numeros_caso4[4]);
                        Console.WriteLine("Copiado " + Copiados[4]);
                        Console.ReadKey();


                        /*int [] Numeros_caso4 = new int [5];
                        int No_ = 0;
                        for (int i = 0; i < Numeros_caso4.Length; i++)
                        {
                            No_ ++;
                            Console.Write("Ingrese numero "+No_+":");
                        }*/

                        break;


                }


            }

        }






    }
}
