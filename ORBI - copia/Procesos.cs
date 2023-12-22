class Procesos
{
    //int Acumulado = 0 ; 

    public static List<Estudiante> Modificar(List<Estudiante> estudiantes)
    {

        Console.Clear();
        Console.WriteLine("Listado de los estudiantes");

        var n = 0;
        foreach (var Estudiante in estudiantes)
        {
            Console.WriteLine(@$"{n} 


                    Matricula: {Estudiante.Matricula}
                    Nombre: {Estudiante.Nombre}
                    Apellido: {Estudiante.Apellido}
                    Edad: {Estudiante.Edad}
                    Primera Nota: {Estudiante.Nota}
                    Promedio: {Estudiante.Promedio()}
                    Literal: {Estudiante.literal()}


                ");
            n++;
        }
        Utils.Repro("listado.wav");
        var eleccion = (int)Utils.LeerDouble("Elija el estudiante que deseas modificiar: ");



        if (eleccion >= 0 && eleccion < estudiantes.Count)
        {
            var Estudiante = estudiantes[eleccion];
            var posible = "";

            Console.WriteLine($"La matricula de este estudiante es {Estudiante.Matricula} digite el valor que quiere agregar o pulse Enter para cancelar");
            Utils.Repro("la_nueva_matricula.wav");
            posible = Utils.LeerString("Digite la nueva matricula: ");
            if (posible.Length > 0)
            {
                Estudiante.Matricula = posible;
            }

            Console.WriteLine($"El nombre actual es {Estudiante.Nombre}, ingrese el nuevo nombre o presione Enter para continuar sin modificar.");
            Utils.Repro("nuevo_nombre.wav");
            posible = Utils.LeerString("Ingrese el nuevo nombre: ");
            if (posible.Length > 0)
            {
                Estudiante.Nombre = posible;
            }

            Console.WriteLine($"El apellido registrado es {Estudiante.Apellido}, ingrese el nuevo apellido o presione Enter para continuar sin modificar.");
            Utils.Repro("nuevo_apellido.wav");
            posible = Utils.LeerString("Ingrese el nuevo apellido: ");
            if (posible.Length > 0)
            {
                Estudiante.Apellido = posible;
            }

            Console.WriteLine($"La Edad establecida es {Estudiante.Edad}, puede cambiarla o presionar Enter para cancelar.");
            posible = Utils.LeerString("Actualice la nueva Edad: ");
            if (posible.Length > 0)
            {
                Estudiante.Edad = posible;
            }

            Console.WriteLine($"La Nota otenida es {Estudiante.Nota}, puede cambiarla o presionar Enter para cancelar.");
            posible = Utils.LeerString("Ingrese la nueva Nota: ");

            if (posible.Length > 0)
            {
                Estudiante.Nota = Convert.ToDouble(posible);
            }
            estudiantes[eleccion] = Estudiante;

            Utils.MostrarMensaje("Los datos del estudiante han sido modificados correctamente.");
            Utils.Repro("datos_modificados_correctamente.wav");
        }
        else
        {
            Utils.MostrarMensajeError("La información que ha introducido no es válida.");
        }

        return estudiantes;

    }

    public static void GuardarEstudiantes(List<Estudiante> estudiantes)
    {
        var tmp = Newtonsoft.Json.JsonConvert.SerializeObject(estudiantes);
        System.IO.File.WriteAllText("datos.json", tmp);

    }

    public static List<Estudiante> Eliminar(List<Estudiante> estudiantes)
    {

        Console.Clear();
        Console.WriteLine("Lista de los estudiantes");
        Utils.Repro("lista_de_los_estudiantes.wav");
        var n = 0;
        foreach (var Estudiante in estudiantes)
        {
            Console.WriteLine(@$"{n}

                    Matricula: {Estudiante.Matricula}
                    Nombre: {Estudiante.Nombre}
                    Apellido: {Estudiante.Apellido}
                    Edad: {Estudiante.Edad}
                    Nota: {Estudiante.Nota}
                    Promedio: {Estudiante.Promedio()}
                    Literal: {Estudiante.literal()}


                ");
            n++;
        }
        var eleccion = (int)Utils.LeerDouble(@"
        Seleccione el número del estudiante que desea eliminar: ");

        if (eleccion >= 0 && eleccion < estudiantes.Count)
        {
            estudiantes.RemoveAt(eleccion);
            Utils.Repro("estudiante_eliminado.wav");
            Utils.MostrarMensaje("El estudiante ha sido eliminado correctamente");

            Procesos.GuardarEstudiantes(estudiantes);
        }
        else
        {
            Utils.MostrarMensajeError("La información que ha introducido no es válida.");
        }

        return estudiantes;
    }

    public static List<Estudiante> Quiz(List<Estudiante> estudiantes)
    {
        Console.Clear();
        Console.WriteLine("Listado de los estudiantes: ");
        var n = 0;
        foreach (var Estudiante in estudiantes)
        {
            Console.WriteLine(@$"{n}


                    Matricula: {Estudiante.Matricula}
                    Nombre: {Estudiante.Nombre}
                    Apellido: {Estudiante.Apellido}
                    Edad: {Estudiante.Edad}
                    Primera Nota: {Estudiante.Nota}
                    Promedio: {Estudiante.Promedio()}
                    Literal: {Estudiante.literal()}

                ");
            n++;
            var eleccion = (int)Utils.LeerDouble("Elija el estudiante que desea realizar el Quiz: ");
            Console.Clear();

            int puntos = 0;
            Estudiante.Nota = puntos + 0;
            if (eleccion >= 0 && eleccion < estudiantes.Count)
            {
                if (eleccion >= 0 && eleccion < estudiantes.Count)
                {
                    var studiante = estudiantes[eleccion];
                    var posible = "";

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine(@"
¿Qué es Anidar?

1- Un if dentro de un para

2- Un for dentro de un if 

3- Una fución o varias funciones dentro de otra

4- Un While dentro de un Else

");
                string opcion = "";
                opcion = Console.ReadLine() ?? "";

                if (opcion == "1")
                {

                    puntos += 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    //Acumilado = Acomulado + 2;
                    Console.WriteLine(@"
Correcto");
                    Console.ReadKey();
                }
                else if (opcion == "2")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion == "3")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion == "4")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }

                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("¿Qué es Do-While?");
                Console.WriteLine(@"
        
1- Mientras Hacer      

2- Hacer Mientras

");

                string opcion2 = "";
                opcion2 = Console.ReadLine() ?? "";

                if (opcion2 == "1")
                {

                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion2 == "2")
                {
                    puntos += 2;
                    //Acomlado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();

                }
                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();


                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("¿Qué es un Algoritmo?");
                Console.WriteLine(@"
        
1- Son distintas herramientas que el programador utiliza para crear la aplicación en un leguaje determinado

2- Serie de pasos que se siguen para solucionar un problema determinado

");

                string opcion3 = "";
                opcion3 = Console.ReadLine() ?? "";

                if (opcion3 == "1")
                {

                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion3 == "2")
                {
                    puntos += 2;
                    //Acomulado = Acomulado + 2; 
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto"
                    );
                    Console.ReadKey();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Su valor es constante, o sea, que va cambiando");
                Console.WriteLine(@"
        
1- Variable      

2- Constante

3- Variable con dato entero

4- Falso

");

                string opcion4 = "";
                opcion4 = Console.ReadLine() ?? "";

                if (opcion4 == "1")
                {

                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion4 == "2")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto"
                    );
                    Console.ReadKey();
                }

                else if (opcion4 == "3")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }

                else if (opcion4 == "4")
                {
                    puntos += 2;
                    //Acomulado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto"
                    );
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }

                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Cuando se habla de programación, ¿Se habla de solucionar problemas?");
                Console.WriteLine(@"
        
1- Verdadero

2- Falso

");

                string opcion5 = "";
                opcion5 = Console.ReadLine() ?? "";

                if (opcion5 == "1")
                {

                    puntos += 2;
                    //Acomulado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto");
                    Console.ReadKey();
                }
                else if (opcion5 == "2")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("¿Cuál es la diferencia entre un Bit y un Byte?");
                Console.WriteLine(@"
        
1- En que uno corresponde a la unidad máxima de memoria y el otro es un conjunto de 6 a 8 bytes.    

2- La diferencia es que uno es de datos y el otro es un conjunto de datos

3- La diferencia es de 1024 Mb de almacenamiento

4- En que uno correspode a la unidad mínima de Memoria y el otro es un conjunto de 6 a 8 bits

");

                string opcion6 = "";
                opcion6 = Console.ReadLine() ?? "";

                if (opcion6 == "1")
                {

                    puntos += 2;
                    //Acomulado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto");
                    Console.ReadKey();
                }
                else if (opcion6 == "2")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();

                }
                else if (opcion6 == "3")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Icorrecto");
                    Console.ReadKey();
                }
                else if (opcion6 == "4")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                Console.WriteLine("La puntuación es: " + puntos);
                Console.ReadKey();

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Son nombres de lenguajes de programación orientados a objetos");
                Console.WriteLine(@"
        
1- Java, C++, Smalltalk, Phyton, Object Pascal, Visual .net, Visual Basic, Deplhi, Perl, entre otros.

2- Visual Basic, Visual C++, Visual DialogScript, Visual Foxpro, Ensamblador, Borland C, Turbo C, entre otros.

3- HTML, XML, VML, Java, PHP, C++, Fortran, Cobol, Lips, entre otros.

4- Actionscript, COBOL, C++, .NET, PHP, Simula, PowerBuilder, Maya, entre otros.

");

                string opcion7 = "";
                opcion7 = Console.ReadLine() ?? "";

                if (opcion7 == "1")
                {

                    puntos += 2;
                    //Acomulado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto");
                    Console.ReadKey();
                }
                else if (opcion7 == "2")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Icorrecto");
                    Console.ReadKey();
                }
                else if (opcion7 == "3")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Icorrecto");
                    Console.ReadKey();
                }
                else if (opcion7 == "4")
                {
                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Icorrecto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.WriteLine("La puntuación es: " + puntos);
                    Console.ReadKey();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Son los tipos de Variables que se manejan en programación?");
                    Console.WriteLine(@"
        
1- Tipo Java, C++, Smalltalk, ¨hyton, Object Pascal, Visual .net, Visual Basic, Delphi, Perl, entre otros.    

2- Cadena, Boleanos, Carácter, Números, Enter, Cadena, Boleano, entre otros.

3- De Actionscript, COBOL, C#, .NET, PHP, Simula, PowerBuilder, Mya, entre otros.

");

                    string opcion8 = "";
                    opcion8 = Console.ReadLine() ?? "";

                    if (opcion8 == "1")
                    {

                        puntos += 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                    }
                    else if (opcion8 == "2")
                    {
                        puntos += 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                    }
                    else if (opcion8 == "3")
                    {
                        puntos += 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Icorrecto");
                        Console.ReadKey();
                    }
                    else if (opcion8 == "4")
                    {
                        puntos += 2;
                        //Acomulado = Acomulado + 2;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Correcto");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                    Console.WriteLine("La puntuación es: " + puntos);
                    Console.ReadKey();

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("¿Qué se un atributo en Programación?");
                    Console.WriteLine(@"
        
1- Son las cosas individuales que diferencian una clase de objetos de otros y determinan la apariencia, estado y otras cualidades de la clase.

2- Es un programa que transforma código fuente escrito en Java a un código neutral a la plataforma conocida como Java.

3- Es un entorno de desarrllo integrado libre, hecho principalmente para el lenguae de programación Java.

4- Es un atributo de una parte de los datos que indica al ordenador (y/o al programador) algo sobre la clase de datos sobre los que se va a procesar.

");

                    string opcion9 = "";
                    opcion9 = Console.ReadLine() ?? "";

                    if (opcion9 == "1")
                    {

                        puntos += 2;
                        //Acomulado = Acomulado + 2;
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.WriteLine("Correcto");
                        Console.ReadKey();
                    }
                    else if (opcion9 == "2")
                    {
                        puntos += 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                    }
                    else if (opcion9 == "3")
                    {
                        puntos = 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Inorrecto");
                        Console.ReadKey();
                    }
                    else if (opcion9 == "4")
                    {
                        puntos += 0;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Incorrecto");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                    }
                    Console.WriteLine("La puntuación es: " + puntos);
                    Console.ReadKey();
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("¡Es lo mismo programar que codificar!");
                Console.WriteLine(@"
        
1- Verdadero      

2- Falso

");

                string opcion0 = "";
                opcion0 = Console.ReadLine() ?? "";

                if (opcion0 == "1")
                {

                    puntos += 0;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Incorrecto");
                    Console.ReadKey();
                }
                else if (opcion0 == "2")
                {
                    puntos += 2;
                    //Acomulado = Acomulado + 2;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Correcto");
                    Console.ReadKey();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(@"
No se encontró esta opción, favor usar una opción válida.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                    Console.WriteLine("La puntuación es: " + puntos

                    );
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
        return estudiantes;
    }
}