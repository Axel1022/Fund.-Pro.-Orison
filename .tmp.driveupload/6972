class Estudiante
{

    public string Matricula { get; set; } = "";

    public string Nombre { get; set; } = "";

    public string Apellido { get; set; } = "";

    public string Edad { get; set; } = "";

    public double Nota { get; set; }

    public double Promedio()
    {
        return (Nota);
    }

    public string literal()
    {
        var literal = "F";
        var promedio = this.Promedio();
        if (promedio >= 90)
        {
            literal = "A";
        }
        else if (promedio >= 80)
        {
            literal = "B";
        }
        else if (promedio >= 70)
        {
            literal = "C";
        }
        else if (promedio <= 69)
        {
            literal = "F";
        }

        return literal;
    }

}