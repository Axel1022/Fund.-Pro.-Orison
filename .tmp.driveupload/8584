class la
{
    public static void Animacion(int numero)
    {
        string Texto = "Xd";
        switch (numero)
        {
            case 1:
                Texto = "Saliendo...";
                break;
            case 2:
                Texto = "Actualizando...";
                break;
            case 3:
                Texto = "Guardando cambios...";
                break;
            case 4:
                Texto = "Buscando...";
                break;
            case 5:
                Texto = "Cargando lista...";
                break;
            case 6:
                Texto = "Generando...";
                break;
            case 7:
                Texto = "Calculando...";
                break;
            case 8:
                Texto = "Borrando...";
                break;
        }
        string SalidaTxto = "";
        int count = 0;
        do
        {
            for (int i = 0; i < Texto.Length; i++)
            {
                Console.WriteLine();
                SalidaTxto = SalidaTxto + Texto[i];
                Console.Write($"\t \t \t   {SalidaTxto}  ");
                Thread.Sleep(210);
                Console.Clear();
            }
            count += 5;
        } while (count < 5);
    }
}
