using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosOpciones
{
    public class operaciones
    {
        public void Suma()
        {
            Console.WriteLine("Escogió la suma");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese por favor los 5 números");
            Console.WriteLine("Primer número: "); Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: "); Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercero número: "); Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto número: "); Num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quinto número: "); Num5 = int.Parse(Console.ReadLine());
            Num6 = Num1 + Num2 + Num3 + Num4 + Num5;
            Console.Clear();
            Console.WriteLine("Números a sumar: "+Num1+"+"+Num2+"+"+ Num3+"+"+ Num4+"+"+ Num5+" El resultado es: "+Num6);
            Console.ReadKey();
        }
        public void Resta()
        {
            Console.WriteLine("Escogió la resta");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Ingrese por favor los 5 números");
            Console.WriteLine("Primer número: "); Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número: "); Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tercero número: "); Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuarto número: "); Num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quinto número: "); Num5 = int.Parse(Console.ReadLine());
            Num6 = Num1 - Num2 - Num3 - Num4 - Num5;
            Console.Clear();
            Console.WriteLine("Números a restar: " + Num1 + "-" + Num2 + "-" + Num3 + "-" + Num4 + "-" + Num5 + " El resultado es: " + Num6);
            Console.ReadKey();
        }
        public int Num1, Num2, Num3, Num4, Num5, Num6;

    }
}
