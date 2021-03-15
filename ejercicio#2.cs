using System;

namespace practica_2
{
    class Program
    {

        static void Main()
        
     {  
         
         
		int r;
        int res;
        
		do
		{
		Console.WriteLine("¿Qué deseas realizar?");
		Console.WriteLine("");
		Console.WriteLine("1 = Convertir de grados Celsius a Fahrenheit");
		Console.WriteLine("2 = Convertir dólar a pesos");
		Console.WriteLine("3 = Convertir metros a pies");
		Console.WriteLine("4 = Salir");
		Console.WriteLine("");

			
		res = int.Parse(Console.ReadLine());
			
		
		
		switch(res)
		{
			case 1:
				Console.WriteLine("Introduzca la temperatura en grados ºC: ");
                double grados_c = double.Parse(Console.ReadLine());
                double grados_f = (grados_c * 9 / 5) + 32;
                Console.WriteLine ("La temperatura en grados Fahrenheit es igual a: "  + grados_f);
				r=0;
		
				break;
				
			case 2:
				Console.WriteLine("Ingrese cantidad de dolar: ");
                double dolar = double.Parse(Console.ReadLine());
                double pesos = (dolar * 57.23);
                Console.WriteLine("Convertido en pesos dominicanos es igual a: " + pesos);
				
				r=0;
				break;
				
			case 3:
			
		     	Console.WriteLine("Indroduzca los Metros:");
                double metros  = double.Parse(Console.ReadLine());
                double pies = (metros * 3.28084);
                Console.WriteLine("Esto convertido en Pies es igual a: " + pies);
                
                r=0;
                break;
				
			case 4: 
				Console.WriteLine("Cerrando sesión ");
				Console.WriteLine("....");
				Console.WriteLine("Que tenga un buen día");
				r=2;
				break;
				
			default:
				Console.WriteLine("Esta opción no existe");
				r=0;
				break;
		
		}
		
		} while(r<2);
	
      }

    }
}