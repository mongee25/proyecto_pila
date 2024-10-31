using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_pila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pila pilaON = null;
            int mode;
            do
            {
                Console.WriteLine("-------Proyecto Pilas-------");
                Console.WriteLine("1.-Establecer tamaño\n2.- Push\n3.- Pop\n4.- Imprimir\n5.- Salir");
                Console.Write("Seleccionar opcion => ");
                mode = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------------------");
                Console.WriteLine();

                switch (mode)
                {
                    case 1:
                        Console.WriteLine("Introduzca el TOPE de la pila");
                        int tope = int.Parse(Console.ReadLine());
                        pilaON = new pila(tope);
                        Console.WriteLine();
                        break;

                    case 2:
                        if(pilaON == null)
                        {
                            Console.WriteLine(" Establecer TOPE primero");
                            break;
                        }
                        Console.WriteLine("Ingrese el valor para realizar el PUSH");
                        int valorPush = int.Parse(Console.ReadLine());
                        pilaON.Push(valorPush);
                        Console.WriteLine();
                        break;

                    case 3:
                        if(pilaON == null)
                        {
                            Console.WriteLine("Establecer TOPE primero");
                            break;
                        }

                        int valorPop = pilaON.Pop();
                        if(valorPop != -1)
                        {
                            Console.WriteLine($"Valor sacado de la pila: {valorPop}");
                        }
                        Console.WriteLine();
                        break;

                    case 4:
                        if(pilaON == null)
                        {
                            Console.WriteLine("Estalecer TOPE primero");
                        }
                        pilaON.PrintStack();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Nos vemos...");    
                        break;

                    default:
                        Console.WriteLine("Opción NO válida");
                        break;
                }
            }while (mode != 5); 
        }
    }
}
