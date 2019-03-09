using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 100;
            //short z = (short)x; //castear, convertir explicitamente un tipo a otro tipo.
            //double d = 13.45;
            //x = (int)d;
            //Console.WriteLine(z);
            //Console.WriteLine(x);
            //Console.ReadKey(true);
            string nombre;
            string numEj;
            Console.WriteLine("Buenos dias, ingrese su nombre");
            nombre = Console.ReadLine();
            while (true)
            {
                Console.WriteLine("Hola " + nombre + ", bienvenido");
                Console.WriteLine("Seleccione que ejercicio desea ejecutar");
                Console.WriteLine("1, 2, 3");
                numEj = Console.ReadLine();
                switch (numEj)
                {
                    case "1":
                        metodoEj1();
                        break;
                    case "2":
                        metodoEj2();
                        break;
                    case "3":
                        metodoEj3();
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta");
                        break;
                }
                void metodoEj1()
                {
                    Console.WriteLine("Ingrese el primer numero");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo numero");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num1 > num2)
                    {
                        Console.WriteLine("El numero mayor es " + num1);
                    }
                    else
                    {
                        Console.WriteLine("El numero mayor es " + num2);
                    }
                    Console.WriteLine();
                }
                void metodoEj2()
                {
                    Console.WriteLine("Ingrese numero para realizar sumatoria");
                    int entero1 = int.Parse(Console.ReadLine());
                    int i;
                    int sum = 0;
                    for (i = 1; i <= entero1; i++)
                    {
                        sum = sum + i;
                        Console.WriteLine(sum);
                    }
                    Console.WriteLine("La suma total es: " + sum);
                    Console.WriteLine();
                }
                void metodoEj3()
                {
                    ArrayList miLista = new ArrayList();
                    string palabra;
                    Console.WriteLine("Ingrese palabra");
                    palabra = Console.ReadLine();
                    while (palabra != "")
                    {
                        miLista.Add(palabra);
                        Console.WriteLine("Ingrese palabra");
                        palabra = Console.ReadLine();
                    }
                    foreach (string st in miLista)
                    {
                        Console.Write(st + " ");
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
