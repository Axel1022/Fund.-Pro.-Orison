class FUNCIONES
{
                public static void FAHRENHEIT()
                {
                    Console.Clear();
                    Console.WriteLine("Conversor de Fahrenheit a Celsius y Kelvin");
                    Console.WriteLine("Ingrese los grados Fahrenheit");
                    double Entrada = Convert.ToDouble(Console.ReadLine());
                    double SalidaC = Entrada - 32;
                    SalidaC = SalidaC / 1.8;
                    double SalidaK = (Entrada - 32) * 5 / 9 + 273.15;
                    Console.WriteLine("Celcius: " +SalidaC+" °C");
                    Console.WriteLine("Kelvin: " +SalidaK +" K");
                }
                /*public static void FAHRENHEITaKELVIN()    //!Esta simplificado.
                {
                    Console.Clear();
                    Console.WriteLine("CONVERSOR DE FAHRENHEIT A KELVIN");
                    Console.WriteLine("Ingrese los grados fahrenheit");
                    double Entrada = Convert.ToInt32(Console.ReadLine());
                    double Salida = (Entrada - 32) * 5 / 9 + 273.15;
                    Console.WriteLine("Resultado: " + Salida);
                }*/
                public static void CELSIUS()
                {
                    Console.Clear();
                    Console.WriteLine("Conversor de Celsius a Fahrenheit y Kelvin");
                    Console.WriteLine("Ingrese los grados Celsius");
                    double Entrada = Convert.ToDouble(Console.ReadLine());
                    double SalidaF = Entrada * 9 / 5 + 32;
                    double SalidaK = Entrada + 273.15;
                    Console.WriteLine("Fahrenheit: " +SalidaF+" °F");
                    Console.WriteLine("Kelvin: " +SalidaK + " K");
                    
                }
                /*public static void CELSIUSaKELVIN()       //!Esta simplificado.
                {
                    Console.Clear();
                    Console.WriteLine("CONVERSOR DE CELSIUS A KELVIN");
                    Console.WriteLine("Ingrese los grados Celsius");
                    double Entrada = Convert.ToInt32(Console.ReadLine());
                    double Salida = Entrada + 273.15;
                    Console.WriteLine("Resultado: " + Salida);
                }*/
                public static void KELVIN()
                {
                    Console.Clear();
                    Console.WriteLine("Conversor de Kelvin a Fahrenheit y Celsius");
                    Console.Write("Ingrese los grados Kelvin: ");
                    double Entrada = Convert.ToDouble(Console.ReadLine());
                    double SalidaF = (Entrada - 273.15) * 9 / 5 + 32;
                    double SalidaC = Entrada - 273.15;
                    Console.WriteLine("Fahrenheit: " +SalidaF+" °F");
                    Console.WriteLine("Celsius: " +SalidaC+ "°C");
                }
                /*public static void KELVINaCELSIUS()           //!Esta simplificado.
                {
                    Console.Clear();
                    Console.WriteLine("CONVERSOR DE KELVIN A CELSIUS");
                    Console.WriteLine("Ingrese los grados Kelvin");
                    double Entrada = Convert.ToInt32(Console.ReadLine());
                    double Salida = Entrada - 273.15;
                    Console.WriteLine("Resultado: " +Salida);
                }*/
}