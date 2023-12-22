/* Parte 2:10
 {(√4*3) [(10+15) (5*12)² + √16 – (16-4*3)]} / 6
 */ 
  using System; 

  {
    {   //(√4*3)
        double A = Math.Sqrt(4) * 3; 

        //(10+15)
        int B = (10+15); 

        //(5*12)²
        int XD = (5*12); 
        double C = Math.Pow(XD, 2); 

        //√16
        double D = Math.Sqrt(16); 
        
        //(16-4*3)
        int E = (16-4*3); 

        int F = 6; 

        //A*B*C+D-E/F
        double Fin = (A * B * C + D - E) / F; 

        Console.WriteLine(Fin); 

    }
  }
