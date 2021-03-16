using System;

namespace ejercicio_1
{
    class suma
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int valor = 1;
            int i = 0;

            while (valor > 0)
            {
                Console.WriteLine("Entrar Valor: ");
                valor = int.Parse(Console.ReadLine());

                suma = suma + valor;
                i++;
            }
            Console.WriteLine("La suma es igual a:  {0}", + suma);
            Console.WriteLine("Total de numeros ingresados:  {0}",  + i);
        }
    }
}
