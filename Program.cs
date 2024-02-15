//Tarea semana 2
using System.Reflection;
using System.Security.Cryptography;
using System;
using System.Runtime.InteropServices;
using System.Dynamic;

for (int ii=0; ii != -1;)
{
    Console.Clear();
    Console.WriteLine("Bienbenido la tarea semana 2\nElije una opción:\n1. Conversión de tipos.\n2. Operaciones con tipos de datos.\n3. Uso de char y string.\n4. Uso de tipos de datos numéricos.\n-1. Cerrar Programa.");
    int emenu1 = int.Parse(Console.ReadLine());
    if (emenu1 > 0 && emenu1 < 5)
    {
        switch (emenu1)
        {
            case 1:

                //1. Conversión de tipos.================================================================

                for (int jj = 0; jj != -1;)
                {
                    Console.Clear();
                    Console.WriteLine("Elija la operación a realizar:\n1. Entero a decimal.\n2. Decimal a flotante.\n3. flotante a entero.\n4. Caracter a entero.\n5. Entero a caracter.\n-1. Atras.");
                    emenu1 = int.Parse(Console.ReadLine());
                    if (emenu1 > 0 && emenu1 < 6)
                    {
                        switch (emenu1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese un entero para transformarlo en un decimal:");
                                int numentero = int.Parse(Console.ReadLine());
                                decimal numdecimal = numentero;
                                Console.WriteLine("El número entero es: " + numentero);
                                Console.WriteLine("Y el numero decimal es: " + numdecimal);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese un decimal para transformarlo en un flotante:");
                                numdecimal = decimal.Parse(Console.ReadLine());
                                float numflotante = (float)numdecimal;
                                Console.WriteLine("El número decimal es: " + numdecimal);
                                Console.WriteLine("Y el numero flotante es: " + numflotante);
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingrese un flotante para transformarlo en un entero:");
                                numflotante = float.Parse(Console.ReadLine());
                                numentero = (int)numflotante;
                                Console.WriteLine("El número flotante es: " + numflotante);
                                Console.WriteLine("Y el numero entero es: " + numentero);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese un caracter para transformarlo en un entero:");
                                char ecaracter = char.Parse(Console.ReadLine());
                                numentero = Convert.ToInt32(ecaracter);
                                Console.WriteLine("El caracter es: " + ecaracter);
                                Console.WriteLine("Y el numero entero es: " + numentero);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingrese un entero para transformarlo en un caracter:");
                                numentero = int.Parse(Console.ReadLine());
                                ecaracter = Convert.ToChar(numentero);
                                Console.WriteLine("El número entero es: " + numentero);
                                Console.WriteLine("Y el caracter es: " + ecaracter);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        if (emenu1 == -1)
                        {
                            jj = -1;
                        }
                        else
                        {
                            Console.WriteLine("El número que elegiste es incorrecto, prueba nuevamente.");
                            Console.ReadKey();
                        }
                    }
                }                              
            break;

            case 2:

                //2. Operaciones con tipos de datos. ===================================================

                for (int jj= 0; jj != -1;)
                {
                    Console.Clear();
                    Console.WriteLine("Elija la operación a realizar:\n1. Suma de dos enteros.\n2. Resta de dos numeros decimales.\n3. Multiplicación de dos numeros flotantes.\n4. Divición de dos numeros enteros.\n5. Calcular en modulo de dos numeros enteros.\n-1. Atras.");
                    emenu1 = int.Parse(Console.ReadLine());
                    if (emenu1 > 0 && emenu1 < 6)
                    {
                        switch (emenu1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese en primer numero entero:");
                                int numentero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese en segundo numero entero:");
                                int numentero2 = int.Parse(Console.ReadLine());
                                int resultadosum = numentero1 + numentero2;
                                Console.WriteLine("El resultado de la suma es: " + resultadosum);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese en primer numero decimal:");
                                decimal numdecimal1 = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese en segundo numero decimal:");
                                decimal numdecimal2 = decimal.Parse(Console.ReadLine());
                                decimal resultadodec = numdecimal1 - numdecimal2;
                                Console.WriteLine("El resultado es: " + resultadodec);
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingrese en primer numero flotante:");
                                float numflotante1 = float.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese en segundo numero flotante:");
                                float numflotante2 = float.Parse(Console.ReadLine());
                                float resulflotante = numflotante1 * numflotante2;
                                Console.WriteLine("El resultado es: " + resulflotante);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese en primer numero entero:");
                                numentero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese en segundo numero entero:");
                                numentero2 = int.Parse(Console.ReadLine());
                                decimal resuldivicion = numentero1 / numentero2;
                                Console.WriteLine("El resultado es: " + resuldivicion);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingrese en primer numero entero:");
                                numentero1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese en segundo numero entero:");
                                numentero2 = int.Parse(Console.ReadLine());
                                int resulmodulo = numentero1 % numentero2;
                                Console.WriteLine("El modulo es: " + resulmodulo);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        if (emenu1 == -1)
                        {
                            jj = -1;
                        }
                        else
                        {
                            Console.WriteLine("El número que elegiste es incorrecto, prueba nuevamente.");
                            Console.ReadKey();
                        }
                    }
                }              
                break;

            case 3:

                //3. Uso de char y string. ==============================================================

                for (int jj = 0; jj != -1;)
                {
                    Console.Clear();
                    Console.WriteLine("Elija la operación a realizar:\n1. Texto a mayusculas.\n2. Texto a minusculas.\n3. Texto al revez.\n4. Buscar la palabra.\n5. Numero de bocales que contiene.\n-1. Atras.");
                    emenu1 = int.Parse(Console.ReadLine());
                    if (emenu1 > 0 && emenu1 < 6)
                    {
                        switch (emenu1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Ingrese el texto que desea pasar a mayusculas: ");
                                string etexto = Console.ReadLine();
                                string etextomayus = etexto.ToUpper();
                                Console.WriteLine("El texto en mayusculas es: " + etextomayus);
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Ingrese el texto que desea pasar a minusculas: ");
                                etexto = Console.ReadLine();
                                string etextominus = etexto.ToLower();
                                Console.WriteLine("El texto en minusculas es: " + etextominus);
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Ingresa el texto que desea pasar al reves: ");
                                string text = Console.ReadLine();
                                string textreves = new string (text.Reverse().ToArray());
                                Console.WriteLine("El texto al reves es: " + textreves);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese una oración: ");
                                string ora = Console.ReadLine();
                                Console.WriteLine("Ingrese la palabra que desea buscar: ");
                                string buscarpal = Console.ReadLine();
                                if (ora.ToLower().Contains(buscarpal.ToLower()))
                                {
                                    Console.WriteLine("La palabra que buscas si se encuentra en la oración.");
                                    Console.ReadKey ();
                                }
                                else
                                {
                                    Console.WriteLine("La palabra que buscas no se encuentra en la oración.");
                                    Console.ReadKey ();
                                }
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingresa la palabra cuyo numero de bocales quieres conocer");
                                string epalabra = Console.ReadLine();
                                string evocales = "aeiouAEIOU";                            
                                int enumvocal = 0;
                                for (int i = 0; i<epalabra.Length; i++)
                                {
                                    if (evocales.Contains(epalabra[i]))
                                    {
                                        enumvocal++;
                                    }
                                }
                                Console.WriteLine("La cantidad de vocales en la palabra es de: " + enumvocal);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        if (emenu1 == -1)
                        {
                            jj = -1;
                        }
                        else
                        {
                            Console.WriteLine("El número que elegiste es incorrecto, prueba nuevamente.");
                            Console.ReadKey();
                        }
                    }
                }
            break;

            case 4:
                for (int jj = 0; jj != -1;)
                {
                    Console.Clear ();
                    Console.WriteLine("Elije la opción que desees:\n1. Calcular el area de un triangulo.\n2. Calcualr el volumen de una esfera.\n3. Calcular la distancia entre dos puntos.\n4. Convertir grados Celsius a Fahrenheit\n5. Convertir grados Fahrenheit a Celsius.\n-1. Atras.");
                    emenu1 = int.Parse (Console.ReadLine());                   
                    if (emenu1 > 0 && emenu1 < 6)
                    {
                        switch (emenu1)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Para calcular el area de un triangulo necesitas tener el valor de la base y el de la altura.\nIngresa el valor de la base: ");
                                decimal ebase = decimal.Parse (Console.ReadLine());
                                Console.WriteLine("Ingresa la altura del triangulo: ");
                                decimal ealtura = decimal.Parse(Console.ReadLine());
                                decimal earea = (ebase * ealtura) / 2;
                                Console.WriteLine("El area del triangulo es: " + earea);
                                Console.ReadKey ();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Para calcular el volumen de una esfera, se necesita tener el radio de esta.\nIngrese el radio de la esfera: ");
                                double eradio = double.Parse(Console.ReadLine());
                                double evolumen = 4 / 3 *Math.PI * Math.Pow(eradio,3);
                                Console.WriteLine("El volumen de la esfera es: " + evolumen);
                                Console.ReadKey ();
                                break;
                            case 3:
                                Console.Clear();
                                Console.WriteLine("Para calcular la distancia entre dos puntos, debe ingresar las coordenadas X y Y de cada punto.\nIngrese las coordenadas X del punto 1:");
                                double x1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese las coordenadas Y del punto 1:");
                                double y1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ahora debe ingresar las coordenadas del punto número 2.\nIngrese la coordenada X del punto 2.");
                                double x2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la coordenada Y del punto 2");
                                double y2 = double.Parse(Console.ReadLine());
                                double edistancia = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
                                Console.WriteLine("La distancia entre los puntos que se diron es de: "+ edistancia);
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                Console.WriteLine("Ingrese la cantidad de grados Celsius que desea transformar en Fehrenheit:");
                                double ecelci = double.Parse (Console.ReadLine());
                                double eresfahre = (ecelci * 9/5) +32;
                                Console.WriteLine("La cantidad de grados Fahrenheit son: " + eresfahre);
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Ingrese la cantidad de grados Celsius que desea transformar en Fehrenheit:");
                                double efahren = double.Parse(Console.ReadLine());
                                double erescel = (efahren - 32) * 5 / 9;
                                Console.WriteLine("La cantidad de grados Fahrenheit son: " + erescel);
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        if (emenu1 == -1)
                        {
                            jj=-1;
                        }
                        else
                        {
                            Console.WriteLine("El número que elegiste es incorrecto, prueba nuevamente.");
                            Console.ReadKey();
                        }
                    }               
                }
            break;
        }
    }
    else
    {
        if(emenu1 == -1)
        {
            ii = -1;
        }
        else
        {
            Console.WriteLine("El número que elegiste es incorrecto, prueba nuevamente.");
            Console.ReadKey();
        }
    }
//Edgar Chinchilla
}
