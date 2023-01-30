using System;
using System.Security.Cryptography.X509Certificates;

namespace DosOpciones
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string Reps;
                do
                {
                    Console.Clear();
                    operaciones OPS = new operaciones();
                    Console.WriteLine("Seleccione la operación deseada");
                    Console.WriteLine("Escriba 1 para sumar\r\n" +
                        "Escriba 2 para restar");
                    int SW = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (SW)
                    {
                        case 1:
                            OPS.Suma();
                            break;
                        case 2:
                            OPS.Resta();
                            break;
                        default: Console.WriteLine("La opción " + SW + " no es válida"); break;
                    }
                    Console.WriteLine("Si desea continuar entonces presione y");
                    Reps = Console.ReadLine();
                } while (Reps !="Y" || Reps !="y");  
            }
            catch (Exception ex)
            {
                throw new Exception("Error:" + ex.Message);
            }


        }
    }
}
