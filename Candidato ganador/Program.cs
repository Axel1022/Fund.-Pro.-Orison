class ProgramdeFunciones
{
    private static void Main()
    {
        string letra = ""; int votosA = 0, votosB = 0, Nulos = 0; bool ParaWhile = true; string Generando = "Generando otra vuelta.";
        string Contando = "Contando los votos."; string Da = "Danilo Medina"; string Do = "Donald Trump"; int Cual = 0;
        Console.Clear();
        Console.WriteLine("Elije el nuevo Presidente de la junta de vecino.");
        while (ParaWhile == true)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Vota A por Donald Trum o B por Danilo Medina:");
                letra = Console.ReadLine();
                if (letra == "a" || letra == "A")
                {
                    votosA++;
                }
                else if (letra == "b" || letra == "B")
                {
                    votosB++;
                }
                else
                {
                    Nulos++;
                }
                Console.Clear();
            }
            if (votosA == votosB)
            {
                Funciones.LaFuncion(Contando);
                Console.WriteLine("Votacion empatada.");
                Console.WriteLine("Vuelva a realizar las votaciones.");
                Thread.Sleep(4000);
                Funciones.LaFuncion(Generando);
                ParaWhile = true; votosA = 0; votosB = 0; Nulos = 0;
            }
            else if (votosA > votosB)
            {
                Funciones.LaFuncion(Contando);
                Cual = 1;
                Funciones.Candidato(Da, Do, votosA, votosB, Cual, Nulos);
                ParaWhile = false;
            }
            else if (votosA < votosB)
            {
                Funciones.LaFuncion(Contando);
                Cual = 2;
                Funciones.Candidato(Da, Do, votosA, votosB, Cual, Nulos);
                ParaWhile = false;
            }
        }
    }
}
