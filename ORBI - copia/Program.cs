bool continuar = true;

List<Estudiante> estudiantes = new List<Estudiante>();

if (System.IO.File.Exists("datos.json"))
{

    try
    {
        var json = System.IO.File.ReadAllText("datos.json");
        estudiantes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Estudiante>>(json);
    }
    catch (Exception)
    {
        Utils.MostrarMensajeError("Vaya... algo no ha ocurrido bien, revisa el archivo .json y confirma que los datos esten bien digitados.");
    }
}
while (continuar)
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.Clear();
    Utils.Repro("Bien.wav");
    Console.WriteLine(@"


     .----------------.  .----------------.  .----------------.  .----------------. 
    | .--------------. || .--------------. || .--------------. || .--------------. |
    | |     ____     | || |  _______     | || |   ______     | || |     _____    | |
    | |   .'    `.   | || | |_   __ \    | || |  |_   _ \    | || |    |_   _|   | |
    | |  /  .--.  \  | || |   | |__) |   | || |    | |_) |   | || |      | |     | |
    | |  | |    | |  | || |   |  __ /    | || |    |  __'.   | || |      | |     | |
    | |  \  `--'  /  | || |  _| |  \ \_  | || |   _| |__) |  | || |     _| |_    | |
    | |   `.____.'   | || | |____| |___| | || |  |_______/   | || |    |_____|   | |
    | |              | || |              | || |              | || |              | |
    | '--------------' || '--------------' || '--------------' || '--------------' |
     '----------------'  '----------------'  '----------------'  '----------------'
# ....____..______...____..___.......______.....____..____..____.._____.__..______..__.._______________________ .
# .../.__.\/.____/../.__.)/...|....././.__.\.../.__.\/.__.\ /.__.\/.___//./././.__.\/./././.____/.___/_..__/.__.\
# .././././.__/..../.__.././|.|__../././././.././_/./. /_/././././\__.\/././././_/././././.__/..\__.\./././. /././
# ././_/././___..././_/./.___././_/././_/./../.____/._,._/ ./_/./___/././_/./.____/./_/././___.___/.//./././_/./.
# /_____/_____/../_____/_/..|_\____/\____/../_/.../_/.|_|\____//____/\____/_/. ...\____/_____//____//_/..\____/..
# .................................................. .................................................... ...........


        Menú principal:

    1- Agrega un estudiante.
    2- Listado de los estudiantes.
    3- Modificar a un estudiante.
    4- Eliminar a cualquier estudiante.
    5- Tomar el examen.
    6- Salir del programa.");

    var opcion = Utils.LeerString(@"
    Ingrese una opcion: ");

    switch (opcion.ToLower())
    {
        case "1":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"Procederemos a agregar un nuevo estudiante.
            ", ConsoleColor.DarkBlue);

            var e = new Estudiante();
            e.Matricula = Utils.LeerString("Introduzca la matricula: ");
            Utils.Repro("Agregar.wav");
            e.Nombre = Utils.LeerString(@"Ingrese su nombre: ");
            Utils.Repro("agregar_apellido.wav");
            e.Apellido = Utils.LeerString("Ingrese su apellido: ");
            Utils.Repro("edad.wav");
            e.Edad = Utils.LeerString("Ingrese edad del estudiante: ");

            e.Nota = Utils.LeerDouble("A ver su primera Calificación: ");
            estudiantes.Add(e);
            Procesos.GuardarEstudiantes(estudiantes);

            Utils.Repro("a_sido_agregado_correctamente.wav");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Utils.MostrarMensaje(@"
    El estudiante ha sido agregado correctamente.");
            break;
        case "2":
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Lista de los estudiantes agregados:");
            foreach (var estudiante in estudiantes)
            {
                Console.WriteLine(@$"
____     ____     ____     ____     ____     ____     ____     ____     ____     ____     ____
/\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\
\/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/

                    Matricula: {estudiante.Matricula}
                    Nombre: {estudiante.Nombre}
                    Apellido: {estudiante.Apellido}
                    Edad: {estudiante.Edad}
                    Primera Nota: {estudiante.Nota}
                    Promedio: {estudiante.Promedio()}
                    Literal: {estudiante.literal()}

____     ____     ____     ____     ____     ____     ____     ____     ____     ____     ____
/\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\ /\____/\
\/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/ \/____\/
                ");

                Utils.MostrarMensaje(@"
    Presiona una tecla para continuar.");
            }

            break;
        case "3":
            estudiantes = Procesos.Modificar(estudiantes);
            break;
        case "4":
            estudiantes = Procesos.Eliminar(estudiantes);
            break;
        case "5":
            estudiantes = Procesos.Quiz(estudiantes);

            break;
        case "7":
            continuar = false;

            Procesos.GuardarEstudiantes(estudiantes);

            Utils.MostrarMensaje("Gracias por utilizar nuestro programa.");
            break;
    };
}



