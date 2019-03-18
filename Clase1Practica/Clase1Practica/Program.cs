using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hola Santi, bienvenido");
                Console.WriteLine("Seleccione que ejercicio desea ejecutar");
                Console.WriteLine("6, 7, 7b, 8, 11, 12, 13, 14, 15, 16, 17, 18, 19");
                string numEj = Console.ReadLine();
                switch (numEj) //El switch case solo entiende strings?
                {
                    case "6":
                        MetodoEj6();
                        break;
                    case "7":
                        MetodoEj7();
                        break;
                    case "7b":
                        MetodoEj7b();
                        break;
                    case "8":
                        MetodoEj8();
                        break;
                    case "11":
                        MetodoEj11();
                        break;
                    case "12":
                        MetodoEj12();
                        break;
                    case "13":
                        MetodoEj13();
                        break;
                    case "14":
                        MetodoEj14();
                        break;
                    case "15":
                        MetodoEj15();
                        break;
                    case "16":
                        MetodoEj16();
                        break;
                    case "17":
                        MetodoEj17();
                        break;
                    case "18":
                        MetodoEj18();
                        break;
                    case "19":
                        MetodoEj19();
                        break;
                    case "20":
                        MetodoEj20();
                        break;
                    case "21":
                        MetodoEj21();
                        break;
                    case "22":
                        MetodoEj22();
                        break;
                    default:
                        Console.WriteLine("La opcion no es correcta");
                        break;
                }
                void MetodoEj6() //EJERCICIO 6
                {
                    Console.WriteLine("Ingrese su nombre");
                    string name = Console.ReadLine();
                    if (name != "")
                    {
                        Console.WriteLine("Bienvenido " + name);
                    }
                    else
                    {
                        Console.WriteLine("Hola Mundo!");
                    }

                }
                void MetodoEj7() //EJERCICIO 7
                {
                    Console.WriteLine("Ingrese su nombre");
                    string name = Console.ReadLine();
                    if (name == "juan")
                    {
                        Console.WriteLine("¡Hola Amigo! Me alegro de verte");
                    }
                    else if (name == "maria")
                    {
                        Console.WriteLine("Buen dia señora");
                    }
                    else if (name == "alberto")
                    {
                        Console.WriteLine("Hola Alberto, que tenga usted un buen dia");
                    }
                    else if (name == "")
                    {
                        Console.WriteLine("¡Buen dia mundo!");
                    }
                    else
                    {
                        Console.WriteLine("Buen dia " + name);
                    }
                }
                void MetodoEj7b() //EJERCICIO 7b
                {
                    Console.WriteLine("Ingrese su nombre");
                    string name = Console.ReadLine();
                    switch (name)
                    {
                        case "juan":
                            Console.WriteLine("¡Hola Amigo! Me alegro de verte");
                            break;
                        case "maria":
                            Console.WriteLine("Buen dia señora");
                            break;
                        case "alberto":
                            Console.WriteLine("Hola Alberto, que tenga usted un buen dia");
                            break;
                        case "":
                            Console.WriteLine("¡Buen dia mundo!");
                            break;
                        default:
                            Console.WriteLine("Buen dia " + name);
                            break;
                    }

                }
                void MetodoEj8() //EJERCICIO 8
                {
                    Console.WriteLine("Ingrese cadena de texto");
                    string cadena = Console.ReadLine();
                    while (cadena != "")
                    {
                        Console.WriteLine(cadena.Length);
                        Console.WriteLine("Ingrese cadena de texto");
                        cadena = Console.ReadLine();
                    }
                }
                    void MetodoEj11() //EJERCICIO 11
                    {
                        Console.WriteLine("Ingrese cadenas");
                        string cadena = Console.ReadLine();
                        if ((cadena != null) && (cadena.Contains(' ')))
                        {
                            string[] partes = cadena.Split(' ');
                            int posicionCadena1 = 0;
                            if (partes[1] != null)
                            {
                                int posicionCadena2 = partes[1].Length - 1;
                                if (partes[0].Length == partes[1].Length)
                                {
                                    while (posicionCadena1 < partes[0].Length)
                                    {
                                        if (partes[0][posicionCadena1] == partes[1][posicionCadena2])
                                        {
                                            posicionCadena1++;
                                            posicionCadena2--;
                                            if (posicionCadena2 < 0)
                                            {
                                                Console.WriteLine("Las palabras son simetricas");
                                                Console.ReadKey(true);
                                                Console.WriteLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No son simetricas las palabras");
                                            Console.WriteLine();
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No son simetricas las palabras");
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine("Formato incorrecto el formato debe ser, dos palabras separadas por espacio");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Formato incorrecto el formato debe ser, dos palabras separadas por espacio");
                        }
                    }
                    void MetodoEj12() //EJERCICIO 12
                    {
                        for (int i = 1; i <= 1000; i++)
                        {
                            if (i % 17 == 0)
                            {
                                Console.WriteLine(i + " es multiplo de 17");
                            }
                            else if (i % 29 == 0)
                            {
                                Console.WriteLine(i + " es multiplo de 29");
                            }
                        }
                    }
                    void MetodoEj13() //EJERCICIO 13 -> PROPUESTO POR LA CATEDRA
                    {
                        Console.WriteLine("10/3 = " + 10 / 3);
                        Console.WriteLine("10.0/3 = " + 10.0 / 3);
                        Console.WriteLine("10/3.0 = " + 10 / 3.0);
                        int a = 10, b = 3;
                        Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
                        Console.WriteLine("entonces a/b = " + a / b);
                        double c = 3;
                        Console.WriteLine("Si c es una variable double, c=3");
                        Console.WriteLine("entonces a/c = " + a / c);
                        string texto = "texto"; //Lo agregue yo
                        int numero = 9; //Lo agregue yo
                        string resutladoTexto = texto + numero;
                        int textoAInt = int.Parse(texto);
                        int resultadoNumero = textoAInt + numero;
                        Console.WriteLine(resutladoTexto);
                        Console.ReadKey();
                    }
                    void MetodoEj14() //EJERCICIO 14
                    {
                        string numString;
                        Console.WriteLine("Ingrese numero entero para calcular todos sus divisores");
                        numString = Console.ReadLine();
                        int num = int.Parse(numString);
                        for (int i = 1; i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                Console.WriteLine(i + " es divisor de " + num);
                            }
                        }
                    }
                    void MetodoEj15() //EJERCICIO 15
                    {
                        string num2s;
                        Console.WriteLine("Ingrese primer numero real");
                        double num1 = double.Parse(Console.ReadLine()); //Leo y convierto a double de una.
                        Console.WriteLine("Ingrese segundo numero real");
                        num2s = Console.ReadLine();
                        double num2 = double.Parse(num2s);
                        Console.WriteLine("El resultado de la suma es" + num2 + num1);
                    }
                    void MetodoEj16() //EJERCICIO 16
                    {
                        Console.WriteLine("Ingrese numero entero a multiplicar por 365");
                        int numInt = int.Parse(Console.ReadLine());
                        int resultado = 365 * numInt;
                        string resultadoString = resultado.ToString();
                        for (int i = resultadoString.Length - 1; i >= 0; i--) //Bucle desde tamañoString-1 hasta que la i se haga 0 y decremento i
                        {
                            Console.WriteLine(resultadoString[i]);
                        }
                    }
                    void MetodoEj17() //EJERCICIO 17
                    {
                        double resultadoD;
                        int resultadoI;
                        Console.WriteLine("Ingrese numero a dividir");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese numero divisor");
                        double num2 = double.Parse(Console.ReadLine());
                        if (num2 != 0)
                        {
                            resultadoD = num1 / num2;
                            Console.WriteLine("El resultado Double = " + resultadoD);
                            resultadoI = Convert.ToInt32(resultadoD);
                            Console.WriteLine("El resultado Int = " + resultadoI);
                        }
                        else
                        {
                            Console.WriteLine("No se puede dividir por 0 burro");
                        }
                    }
                    void MetodoEj18() //EJERCICIO 18
                    {
                        Console.Write("Ingrese año: ");
                        int año = int.Parse(Console.ReadLine());
                        if ((año % 4 == 0) & (año % 100 != 0))
                        {
                            Console.WriteLine("El año es bisiesto");
                        }
                        else if ((año % 100 == 0) & (año % 400 == 0))
                        {
                            Console.WriteLine("El año es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("El año no es bisiesto");
                        }
                    }
                    void MetodoEj19() //EJERCICIO 19
                    {
                        int a;
                        int b;
                        a = 100;
                        b = 11;
                        if ((b != 0) & (a / b > 5))
                        {
                            Console.WriteLine(a / b);
                        }
                    }
                    void MetodoEj20() //EJERCICIO 20
                    {
                        //int a, b, c;
                        //int a; int b; int c, d;
                        //int a = 1; int b = 2; int c = 3;
                        //int b; int c; int a = b = c = 1;
                        //int c; int a, b = c = 1;
                        //int c; int a = 2, b = c = 1;
                        //int a = 2, b, c, d = 2 * a;
                        //int a = 2, int b = 3, int c = 4; //Esta Falla -> Indica que tipo dato va a ser cada variable separando con , en este caso deberia ser con ;
                        //int a = 2; b = 3; c = 4; //Esta Falla -> No indica de que tipo son b y c, y el chabon separo con ; en vez de con ,
                        //int a; int c = a; //Esta Falla -> Quiere asignar una variable (a) pero (a) no tiene valor
                        //char c = 'A', string st = "Hola"; //Esta Falla -> Separa con , en vez de ; y quiere declarar otro tipo de dato
                        //char c = 'A'; string st = "Hola";
                        //char c = 'A', st = "Hola"; //Esta Falla -> quiere guardar un string en un char
                    }
                    void MetodoEj21() //EJERCICIO 21
                    {
                        //int i = 0; -> Quitando esta linea se soluciona el problema
                        for (int i = 1; i <= 10;)
                        {
                            Console.WriteLine(i++);
                        }
                        Console.ReadKey();
                    }
                    void MetodoEj22() //EJERCICIO 22
                    {
                        int i = 1;
                        if (--i == 0)
                        {
                            Console.WriteLine("cero");
                        }
                        if (i++ == 0)
                        {
                            Console.WriteLine("cero");
                        }
                        Console.WriteLine(i);
                        Console.ReadKey();
                    }

                }
            }
        }
    }

