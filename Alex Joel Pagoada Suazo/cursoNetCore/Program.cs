﻿namespace cursoNetCore;

class Program
{
  static void Main(string[] args)
  {
    String separador = "================";
    Program progra = new Program();
    // progra.functionTipoDato(separador);
    // progra.functionArray(separador);
    // progra.functionCicloFor(separador);
    progra.trianguloPascal(separador);
  }

  public void functionTipoDato(String separador)
  {
    // int year = 10;
    int year = Convert.ToInt16("12"); // Convirtiendo la cadena de texto a entero
    double doble = 2.5; // Variable (double) con valor decimal
    string nombre = "Jolberth"; // Variable (string) con valor texto
    String nombres = "Jolberth Alberto"; // Variable (string) con valor cadena de texto
    decimal decimales = 2.08M; // Variable (decimal) con valor decimal
    float flotante = 8.34F; // Variable (float) con valor decimal
    bool valida = false; // Variable (false|true) con valor booleano
    char letra = 'A'; // Variable (char) almacena una caracter
    Decimal de = 28.4M; // Variable (Decimal) con valor decimal
    Boolean valor = false;
    Console.WriteLine("Hola Jolberth Reyes, bienvenido al mundo de la programación");
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Tipo de dato [string, double, float, decimal, int]:");
    Console.WriteLine("=> float [7 digitos, 32 bits] \n=> double [15-16 digitos, 64 bits] \n=> decimal [28-29 digitos, 128 bits]");
    Console.WriteLine("Año: {0}, double: {1} Nombre: {2} Nombres: {3} decimal: {4} flotante: {5}", year, doble, nombre, nombres, decimales, flotante);
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Tipo de dato [bool, char y estructuras para almacenar datos]:");
    Console.WriteLine("Valida: {0}, Letra: {1}, Decimal: {2}, Valida2: {3}", valida, letra, de, valor);
    Console.ReadLine();
  }

  public void functionArray(String separador)
  {
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Array Tipo String:");

    string[] cadenas = new string[5];
    cadenas[0] = "Carmen";
    cadenas[1] = "Sherly";
    cadenas[2] = "Michael";
    cadenas[3] = "Alberto";
    cadenas[4] = "Jolberth";
    string[] name = { "Carmen", "Alberto", "Michael", "Sherly", "Jolberth" };

    Console.WriteLine("Longuitud Cadena: {0}, Posicion[1]: {1}  Name: {2}, Posicion[1]: {3}", cadenas.Length, cadenas[1], name.Length, name[1]);

    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Array Tipo Int:");

    int[] age = new int[5];
    age[0] = 5;
    age[1] = 15;
    age[2] = 50;
    age[3] = 55;
    age[4] = 95;
    int[] ages = { 5, 15, 50, 95, 55 };

    Console.WriteLine("Longuitud Age: {0}, Posicion[1]: {1}, Longuitud Ages: {2}, Posicion[3]: {3}", age.Length, age[2], ages.Length, ages[3]);

    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Array multidimencional:");
    Console.WriteLine("bidimencional:");
    double[,] doble = new double[2, 2] {
                                          {6, 3.0}, {6.3, 5.6}
                                        };
    Console.WriteLine("Longuitud doble: {0}, Posicion[1][0]: {1}, Posicion[0][1]: {2}", doble.Length, doble[1, 0], doble[0, 1]);

    Console.WriteLine("tridimencional:");
    double[,,] doble2 = new double[2, 2, 3]  {
                                              {
                                                {3, 6.9, 8.4}, {6.8, 4.6, 7.3}
                                              },
                                              {
                                                {4.7, 5.2, 7.4}, {7.2, 6.7, 9.4}
                                              }
                                            };
    Console.WriteLine("Longuitud doble: {0}, Posicion[1, 0, 2]: {1}, Posicion[0, 1, 1]: {2}", doble2.Length, doble2[1, 0, 2], doble2[0, 1, 1]);

    Console.ReadLine();
  }

  public void functionCicloFor(String separador)
  {
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Bucle Ciclo For:");
    Console.WriteLine("Incremento:");

    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine("Posicion[{0}]", i);
    }

    Console.WriteLine("Decremento:");

    for (int j = 10; j > 0; j--)
    {
      Console.WriteLine("Posicion[{0}]", j);
    }

    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Bucle Ciclo ForEach:");
    string[] name = { "Carmen", "Alberto", "Michael", "Sherly", "Jolberth" };

    foreach (var item in name)
    {
      Console.WriteLine("Nombre: {0}", item);
    }

    Console.ReadLine();
  }

  public void trianguloPascal(String separador)
  {
    Console.WriteLine(separador + separador + separador + separador);
    Console.WriteLine("Triangulo de Pascal:");
    int pisos = 0;
    int[] arreglo = new int[1];
    // Mostramos un mensaje y capturamos el dato ingresado desde la consola
    Console.WriteLine("Ingrese el numero de pisos: ");
    pisos = Convert.ToInt16(Console.ReadLine());
    /* Declaramos el primer ciclo for que va a recorrer dependiendo 
       el dato ingresado que está almacenado en la variable pisos */
    for (int i = 1; i <= pisos; i++)
    {
      /* Colocamos un arreglo y la variable i del ciclo for que será el tamaño
         que tendrá el arreglo, cada vez que el ciclo for se ejecute */
      int[] pascal = new int[i];
      // Ciclo for que se decrementa para formar el triangulo
      for (int j = pisos; j < i; j++)
      {
        Console.WriteLine(" ");
      }
      // Ciclo for que genera la suma de las cifras
      for (int k = 0; k < i; k++)
      {
        // Condicion que evalúa la variable del ciclo for
        if (k == 0 || k == (i - 1))
        {
          pascal[k] = 1;
        }
        else
        {
          /* Sumamos los numeros que estan en cada posicion del arreglo
             para formar el triangulo */
          pascal[k] = arreglo[k] + arreglo[k - 1];
        }
        Console.Write("[" + pascal[k] + "]");
      }
      arreglo = pascal;
      Console.WriteLine(" ");
    }

    Console.ReadLine();
  }
}
